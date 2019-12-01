using System;

namespace CN_Modeling
{
    public class Movie_Model
    {
        // deklarasi Variable
        public string MovieName;
        public string MovieIMDB;
        public string MovieDescription;
        public string MovieImage;
        public string SlideImage;
        public string Duration;
        public string ReleasedDate;
        public string IsReleased;
        public string MovieID;
        public String _MovieName
        {
            get
            { return MovieName; }
            set
            { MovieName = value; }
        }
        public string _MovieIMDB
        {
            get
            { return MovieIMDB; }
            set
            { MovieIMDB = value; }
        }
        public string _MovieDescription
        {
            get
            { return MovieDescription; }
            set
            { MovieDescription = value; }
        }
        public string _MovieImage
        {
            get
            {
                return MovieImage;
            }

            set
            {
                MovieImage = value;
            }
        }
        public string _SlideImage
        {
            get
            {
                return SlideImage;
            }

            set
            {
                SlideImage = value;
            }
        }
        public string _Duration
        {
            get
            {
                return Duration;
            }

            set
            {
                Duration = value;
            }
        }
        public string _ReleasedDate
        {
            get
            {
                return ReleasedDate;
            }

            set
            {
                ReleasedDate = value;
            }
        }
        public string _IsReleased
        {
            get
            {
                return IsReleased;
            }

            set
            {
                IsReleased = value;
            }
        }

        public string _MovieID
        {
            get
            {
                return MovieID;
            }

            set
            {
                MovieID = value;
            }
        }

    }
}
