using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyMChartTool
{
    /// <summary>
    /// A note object that has been processed
    /// </summary>
    public class Note
    {
        /// <summary>
        /// The type of the note<br />
        /// Should not be SUB
        /// </summary>
        public CMapNoteAsset.Type type;
        public float time;

        /// <summary>
        /// The duration the note is held for<br />
        /// Only applies if type is HOLD
        /// </summary>
        public float length;
        public float position;
        public float width;

        /// <summary>
        /// Base constructor. Meant to be used by other constructors
        /// </summary>
        public Note(CMapNoteAsset.Type type, float time, float length, float position, float width)
        {
            this.type = type;
            this.time = time;
            this.length = length;
            this.position = position;
            this.width = width;
        }

        /// <summary>
        /// Constructor for NORMAL and CHAIN type notes
        /// </summary>
        public Note(CMapNoteAsset.Type type, float time, float position, float width) : this(type, time, 0f, position, width) { }

        /// <summary>
        /// Constructor for HOLD notes
        /// </summary>
        public Note(float time, float length, float position, float width) : this(CMapNoteAsset.Type.HOLD, time, length, position, width) { }

        /// <summary>
        /// Converts this Note object into one or more CMapNoteAsset objects and returns an array of them.
        /// </summary>
        /// <param name="m_id">The m_id value the note should have. If the type parameter of the Note object is HOLD, m_subId will one greater than this value.</param>
        /// <returns>An array containing:<br />
        /// 0: The original Note objct converted into a CMapNoteAsset object.<br />
        /// 1: If the original Note object's type was HOLD, this will contain the corresponding sub note. If it was any other type, this will contain null.</returns>
        public CMapNoteAsset[] toCMapNoteAsset(int m_id)
        {
            CMapNoteAsset[] retVal = new CMapNoteAsset[2];
            retVal[0] = new CMapNoteAsset()
            {
                m_id = m_id,
                m_type = type,
                m_time = time,
                m_position = position,
                m_width = width,
                m_subId = -1,
                status = "Perfect"
            };

            if (type == CMapNoteAsset.Type.HOLD)
            {
                int subId = m_id + 1;
                retVal[0].m_subId = subId;
                retVal[1] = new CMapNoteAsset()
                {
                    m_id = subId,
                    m_type = CMapNoteAsset.Type.SUB,
                    m_time = time + length,
                    m_position = position,
                    m_width = width,
                    m_subId = -1,
                    status = "Perfect"
                };
            }
            else
                retVal[1] = null;
            return retVal;
        }
    }
}
