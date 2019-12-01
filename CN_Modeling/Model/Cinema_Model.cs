using System;

namespace CN_Modeling
{
    public class Cinema_Model
    {
        // deklarasi Variable
        public string Cinema_Name;
        public string Movie_name;
        public string Theather;
        public string Time;
        public string Class;
        public string Cinema_Id;
        public String _Cinema_Name
        {
            get
            { return Cinema_Name; }
            set
            { Cinema_Name = value; }
        }
        public string _Movie_name
        {
            get
            { return Movie_name; }
            set
            { Movie_name = value; }
        }
        public string _Theather
        {
            get
            { return Theather; }
            set
            { Theather = value; }
        }
        public string _Time
        {
            get
            {
                return Time;
            }

            set
            {
                Time = value;
            }
        }
        public string _Class
        {
            get
            {
                return Class;
            }

            set
            {
                Class = value;
            }
        }
        public string _CinemaId
        {
            get
            {
                return Cinema_Id;
            }

            set
            {
                Cinema_Id = value;
            }
        }


    }
}
