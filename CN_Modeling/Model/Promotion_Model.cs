using System;

namespace CN_Modeling
{
    public class Promotion_Model
    {
        // deklarasi Variable
        public string Movie_URL;
        public string Movie_name;
        public string Promotion_ID;
        public String _Movie_name
        {
            get
            { return Movie_name; }
            set
            { Movie_name = value; }
        }
        public string _Movie_URL
        {
            get
            { return Movie_URL; }
            set
            { Movie_URL = value; }
        }
        public string _Promotion_ID
        {
            get
            { return Promotion_ID; }
            set
            { Promotion_ID = value; }
        }


    }
}
