using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    abstract class MusicFile
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public MusicFile()
        {
        }

        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {

            this.Title = title;
            this.Artist = artist;
            this.YearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;

        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }
        private int DurationInSeconds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }

        public void changeTitle(string newTitle)
        {
            title = newTitle;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Music Title : " + title);
            Console.WriteLine("Music Artist : " + artist);
            Console.WriteLine("Music Release Year : " + yearOfRelease);
            Console.WriteLine("Music Duration Is " + durationInSeconds + " Seconds");
        }
    }
}
