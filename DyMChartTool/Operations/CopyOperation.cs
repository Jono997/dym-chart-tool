﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DyMChartTool.Operations
{
    class CopyOperation: ChartOperation
    {
        /// <summary>
        /// The path to the chart file notes are being copied from.<br />
        /// If null, notes are copied from the CMap file passed in to the apply method.
        /// </summary>
        public string source_path { get; private set; }

        /// <summary>
        /// The chart notes are being copied from.
        /// </summary>
        private CMap source_file;

        /// <summary>
        /// The start point of the paste
        /// </summary>
        public float destination_time { get; private set; }

        /// <summary>
        /// If true, destination_time will be treated as if it were the start_time of the destination.<br />
        /// If false, destination_time will be treated as the time of the first note of the destination.
        /// </summary>
        public bool start_from_start { get; private set; }

        public CopyOperation(float start_time, float end_time, float destination_time, byte track_flags, bool start_from_start)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            this.destination_time = destination_time;
            this.track_flags = track_flags;
            this.start_from_start = start_from_start;
            source_path = null;
            source_file = null;
        }

        public CopyOperation(float start_time, float end_time, float destination_time, bool main_track, bool left_track, bool right_track, bool start_from_start)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            this.destination_time = destination_time;
            track_flags = 0x00;
            if (main_track)
                track_flags = (byte)(track_flags | MainTrackFlag);
            if (left_track)
                track_flags = (byte)(track_flags | LeftTrackFlag);
            if (right_track)
                track_flags = (byte)(track_flags | RightTrackFlag);
            this.start_from_start = start_from_start;
            source_path = null;
            source_file = null;
        }

        public CopyOperation(float start_time, float end_time, float destination_time, byte track_flags, bool start_from_start, string source_path) : this(start_time, end_time, destination_time, track_flags, start_from_start)
        {
            this.source_path = source_path;
            source_file = source_path == null ? null : CMap.Deserialise(source_path);
        }

        public CopyOperation(float start_time, float end_time, float destination_time, bool main_track, bool left_track, bool right_track, bool start_from_start, string source_path) : this(start_time, end_time, destination_time, main_track, left_track, right_track, start_from_start)
        {
            this.source_path = source_path;
            source_file = source_path == null ? null : CMap.Deserialise(source_path);
        }

        public override string ToString()
        {
            string retVal = $"{(source_file == null ? "Internal" : "External")} copy {start_time} to {end_time}: ";
            if ((track_flags & MainTrackFlag) > 0)
                retVal += 'M';
            if ((track_flags & LeftTrackFlag) > 0)
                retVal += 'L';
            if ((track_flags & RightTrackFlag) > 0)
                retVal += 'R';
            retVal += $" at {destination_time}";
            return retVal;
        }

        public override CMap apply(CMap chart)
        {
            return apply_operate(source_file == null ? chart : source_file, chart);
        }

        #region Old version
        //float anchor;

        //private CMap apply_operate(CMap source, CMap dest)
        //{
        //    List<CMapNoteAsset>[] tracks = new List<CMapNoteAsset>[] { null, null, null };
        //    bool copy_main = (track_flags & MainTrackFlag) > 0;
        //    bool copy_left = (track_flags & LeftTrackFlag) > 0;
        //    bool copy_right = (track_flags & RightTrackFlag) > 0;

        //    anchor = start_from_start ? start_time : end_time;
        //    int[] lowest_available_ids = new int[3];
        //    Dictionary<int, int[]> subs = new Dictionary<int, int[]>();
        //    Dictionary<int, int> orphan_subs = new Dictionary<int, int>();

        //    if (copy_main)
        //    {
        //        apply_getNotes(tracks, lowest_available_ids, subs, orphan_subs, source.m_notes, 0, copy_main);
        //        apply_setNotes(lowest_available_ids[0], orphan_subs, dest.m_notes, tracks[0]);
        //    }
        //    if (copy_left)
        //    {
        //        apply_getNotes(tracks, lowest_available_ids, subs, orphan_subs, source.m_notesLeft, 1, copy_left);
        //        apply_setNotes(lowest_available_ids[1], orphan_subs, dest.m_notesLeft, tracks[1]);
        //    }
        //    if (copy_right)
        //    {
        //        apply_getNotes(tracks, lowest_available_ids, subs, orphan_subs, source.m_notesRight, 2, copy_right);
        //        apply_setNotes(lowest_available_ids[2], orphan_subs, dest.m_notesRight, tracks[2]);
        //    }
        //    return dest;
        //}

        //private void apply_getNotes(List<CMapNoteAsset>[] tracks, int[] lowest_available_ids, Dictionary<int, int[]> subs, Dictionary<int, int> orphan_subs, NoteCollection m_notes, int track, bool copy_track)
        //{
        //    tracks[track] = new List<CMapNoteAsset>();
        //    foreach (CMapNoteAsset note in m_notes.m_notes)
        //    {
        //        if (copy_track && ((note.m_time >= start_time && note.m_time < end_time) || (note.m_type == CMapNoteAsset.Type.SUB && subs.ContainsKey(note.m_id))))
        //        {
        //            tracks[track].Add(note.Copy());
        //            if (!start_from_start && anchor > note.m_time)
        //                anchor = note.m_time;
        //            if (note.m_type == CMapNoteAsset.Type.HOLD)
        //            {
        //                if (!subs.ContainsKey(note.m_subId))
        //                    subs.Add(note.m_subId, new int[] { track, note.m_subId, 0 });
        //                else
        //                {
        //                    subs[note.m_subId][1] = note.m_subId;
        //                    if (orphan_subs.ContainsKey(note.m_subId))
        //                        orphan_subs.Remove(note.m_subId);
        //                }
        //            }
        //            else if (note.m_type == CMapNoteAsset.Type.SUB)
        //            {
        //                if (!subs.ContainsKey(note.m_id))
        //                {
        //                    subs.Add(note.m_id, new int[] { track, 0, note.m_id });
        //                    orphan_subs.Add(note.m_id, 0);
        //                }
        //                else
        //                    subs[note.m_id][2] = note.m_id;
        //            }
        //        }
        //        if (lowest_available_ids[track] < note.m_id)
        //            lowest_available_ids[track] = note.m_id;
        //    }
        //}

        //private void apply_setNotes(int lowest_available_id, Dictionary<int, int> orphan_subs, NoteCollection m_notes, List<CMapNoteAsset> copy_notes)
        //{
        //    List<CMapNoteAsset> notes = m_notes.m_notes.ToList();
        //    Dictionary<int, int> new_sub_ids = new Dictionary<int, int>();

        //    #region Update note IDs
        //    foreach (CMapNoteAsset note in copy_notes)
        //    {
        //        if (!(note.m_type == CMapNoteAsset.Type.SUB && orphan_subs.ContainsKey(note.m_id)))
        //        {
        //            switch (note.m_type)
        //            {
        //                case CMapNoteAsset.Type.HOLD:
        //                    note.m_id = ++lowest_available_id;
        //                    if (!new_sub_ids.ContainsKey(note.m_subId))
        //                        new_sub_ids.Add(note.m_subId, ++lowest_available_id);
        //                    note.m_subId = new_sub_ids[note.m_subId];
        //                    break;
        //                case CMapNoteAsset.Type.SUB:
        //                    if (!new_sub_ids.ContainsKey(note.m_id))
        //                        new_sub_ids.Add(note.m_id, ++lowest_available_id);
        //                    note.m_id = new_sub_ids[note.m_id];
        //                    break;
        //                default:
        //                    note.m_id = ++lowest_available_id;
        //                    break;
        //            }
        //        }
        //    }
        //    #endregion

        //    #region Populate m_notes
        //    foreach (CMapNoteAsset note in copy_notes)
        //        if (!(note.m_type == CMapNoteAsset.Type.SUB && orphan_subs.ContainsKey(note.m_id)))
        //        {
        //            note.m_time -= anchor;
        //            note.m_time += destination_time;
        //            notes.Add(note);
        //        }
        //    m_notes.m_notes = notes.ToArray();
        //    #endregion
        //}
        #endregion

        private CMap apply_operate(CMap source, CMap dest)
        {
            float anchor = start_from_start ? start_time : end_time;
            List<Note>[] notes = new List<Note>[] { null, null, null };

            if ((track_flags & MainTrackFlag) > 0)
                anchor = get_notes(notes, 0, source.m_notes, anchor);
            if ((track_flags & LeftTrackFlag) > 0)
                anchor = get_notes(notes, 1, source.m_notesLeft, anchor);
            if ((track_flags & RightTrackFlag) > 0)
                anchor = get_notes(notes, 2, source.m_notesRight, anchor);

            if ((track_flags & MainTrackFlag) > 0)
                dest.m_notes = set_notes(notes[0], dest.m_notes, anchor);
            if ((track_flags & LeftTrackFlag) > 0)
                dest.m_notesLeft = set_notes(notes[1], dest.m_notesLeft, anchor);
            if ((track_flags & RightTrackFlag) > 0)
                dest.m_notesRight = set_notes(notes[2], dest.m_notesRight, anchor);

            return dest;
        }

        private float get_notes(List<Note>[] notes, int notes_index, NoteCollection m_notes, float anchor)
        {
            List<Note> note_list = NoteCollectionToNoteList(m_notes);
            notes[notes_index] = new List<Note>();
            foreach (int i in getApplyRange(note_list))
            {
                Note note = note_list[i];
                notes[notes_index].Add(note);
                if (!start_from_start && note.time < anchor && note.time >= start_time)
                    anchor = note.time;
            }
            return anchor;
        }

        private NoteCollection set_notes(List<Note> source_notes, NoteCollection dest_notes, float anchor)
        {
            List<Note> new_dest = NoteCollectionToNoteList(dest_notes);
            foreach (Note note in source_notes)
            {
                note.time = note.time - anchor + destination_time;
                new_dest.Add(note);
            }
            return NoteListToNoteCollection(new_dest);
        }

        //private CMap apply_operate(CMap source, CMap dest)
        //{
        //    if ((track_flags & MainTrackFlag) > 0)
        //        dest.m_notes = apply_track(source.m_notes, dest.m_notes);
        //    if ((track_flags & LeftTrackFlag) > 0)
        //        dest.m_notes = apply_track(source.m_notesLeft, dest.m_notesLeft);
        //    if ((track_flags & RightTrackFlag) > 0)
        //        dest.m_notes = apply_track(source.m_notesRight, dest.m_notesRight);
        //    return dest;
        //}

        //private NoteCollection apply_track(NoteCollection source, NoteCollection dest)
        //{
        //    List<Note> source_notes = NoteCollectionToNoteList(source);
        //    List<Note> dest_notes = NoteCollectionToNoteList(dest);
        //    List<int> applyTo = getApplyRange(source_notes);
        //    foreach (int i in applyTo)
        //        dest_notes.Add(source_notes[i]);
        //    return NoteListToNoteCollection(dest_notes);
        //}
    }
}
