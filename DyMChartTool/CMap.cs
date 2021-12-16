using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace DyMChartTool
{
    public class CMap
    {
        public enum RegionType
        {
            MIXER,
            PAD,
            MULTI
        }

        public string m_path;
        public float m_barPerMin;
        public float m_timeOffset;
        public RegionType m_leftRegion;
        public RegionType m_rightRegion;
        public string m_mapID;
        public NoteCollection m_notes;
        public NoteCollection m_notesLeft;
        public NoteCollection m_notesRight;
        public CMapArguments m_argument;

        public CMap()
        {
            m_path = "";
            m_barPerMin = 120;
            m_timeOffset = 0;
            m_leftRegion = RegionType.MIXER;
            m_rightRegion = RegionType.PAD;
            m_mapID = "";
            m_notes = new NoteCollection();
            m_notesLeft = new NoteCollection();
            m_notesRight = new NoteCollection();
            m_argument = new CMapArguments();
        }

        public void Serialise(string path)
        {
            FileStream writer = new FileStream(path, FileMode.Create);
            XmlSerializer serialiser = new XmlSerializer(GetType());
            serialiser.Serialize(writer, this);
            writer.Close();
        }

        public static CMap Deserialise(string path)
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                XmlSerializer serialiser = new XmlSerializer(typeof(CMap));
                CMap retVal = (CMap)serialiser.Deserialize(reader);
                reader.Close();
                return retVal;
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException || e is DirectoryNotFoundException || e is ArgumentException || e is IOException)
                    throw new LoadFailedException();
                throw e;
            }
        }
    }

    [Serializable]
    public class LoadFailedException : Exception
    {
        public LoadFailedException() { }
        public LoadFailedException(string message) : base(message) { }
        public LoadFailedException(string message, Exception inner) : base(message, inner) { }
        protected LoadFailedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    public class CMapArguments
    {
        public CBpmchange[] m_bpmchange;

        public CMapArguments()
        {
            m_bpmchange = new CBpmchange[0];
        }
    }

    public class CBpmchange
    {
        public float m_time;
        public float m_value;

        public CBpmchange()
        {
            m_time = 0;
            m_value = 120;
        }
    }

    public class NoteCollection
    {
        public CMapNoteAsset[] m_notes;

        public NoteCollection()
        {
            m_notes = new CMapNoteAsset[0];
        }
    }

    public class CMapNoteAsset
    {
        public enum Type
        {
            NORMAL,
            HOLD,
            SUB,
            CHAIN
        }

        public int m_id;
        public Type m_type;
        public float m_time;
        public float m_position;
        public float m_width;
        public int m_subId;
        public string status;

        public CMapNoteAsset()
        {
            m_id = 0;
            m_type = Type.NORMAL;
            m_time = 1;
            m_position = 0.9f;
            m_width = 1;
            m_subId = -1;
            status = "Perfect";
        }

        public CMapNoteAsset Copy()
        {
            CMapNoteAsset copy = new CMapNoteAsset();
            copy.m_id = m_id;
            copy.m_type = m_type;
            copy.m_time = m_time;
            copy.m_position = m_position;
            copy.m_width = m_width;
            copy.m_subId = m_subId;
            copy.status = status;
            return copy;
        }

        /// <summary>
        /// Convert this CMapNoteAsset object into a Note object and returns it
        /// </summary>
        /// <param name="sub">The sub note that matches this object. Only needed if m_type is HOLD.</param>
        /// <returns>This CMapNoteAsset object converted into a Note object</returns>
        /// <exception cref="ArgumentNullException">sub is null when m_type is HOLD</exception>"
        /// <exception cref="ArgumentException">m_type is SUB</exception>
        public Note toNote(CMapNoteAsset sub = null)
        {
            switch (m_type)
            {
                case Type.SUB:
                    throw new Exception("m_type is SUB");
                case Type.HOLD:
                    if (sub == null)
                        throw new ArgumentNullException("sub was null when m_type was HOLD");
                    return new Note(m_time, sub.m_time - m_time, m_position, m_width);
                default:
                    return new Note(m_type, m_time, m_position, m_width);
            }
        }
    }
}
