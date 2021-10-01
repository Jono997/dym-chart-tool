using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaMirror
{
    public class CMap
    {
        public enum RegionType
        {
            MIXER,
            PAD
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
    }
}
