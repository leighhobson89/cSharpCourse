using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Class_Attributes
{
    class Song
    {
        public string title; //normal class attribute - unique (possibly) to each object
        public string artist;
        public int duration;

        public static int songCount = 0; //static class attribute - in main program referred to by class.attribute rather than instance.attribute e.g. "Song.songCount" rather than "holiday.artist"

        public Song (string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount ()
        {
            return songCount;
        }
    }
}
