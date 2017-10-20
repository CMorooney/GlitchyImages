﻿using System.Collections.Generic;

namespace ImageMusic
{
    public class FrequencyDictionary : Dictionary<int, int[]>
    {
        readonly int[] CKeyIndicies = { 0, 2, 4, 5, 7, 9, 11 };

        public FrequencyDictionary ()
        {
            Add(0, new[] { 16, 17, 18, 20, 21, 22, 23, 25, 26, 28, 29, 31 });
            Add(1, new[] { 33, 35, 37, 39, 41, 44, 46, 49, 52, 55, 58, 62 });
            Add(2, new[] { 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 117, 124 });
            Add(3, new[] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 });
            Add(4, new[] { 262, 278, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 });
            Add(5, new[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 });
            Add(6, new[] { 1047, 1109, 1175, 1245, 1319, 1397, 1475, 1568, 1661, 1760, 1865, 1976 });
            //Add(7, new[] { 2093, 2218, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 });
            //Add(8, new[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 });
        }

        public List<int> CKeyForOctave (int octave)
        {
            var notes = new List<int> ();

            foreach (var index in CKeyIndicies)
            {
                notes.Add(this[octave][index]);
            }

            return notes;
        }
    }
}