using System;

namespace CN_Modeling
{
    public class Ticket_Model
    {
        // deklarasi Variable
        public string Type;
        public string DayCode;
        public string Price;
        public string ticketid;

        public String _Type
        {
            get
            { return Type; }
            set
            { Type = value; }
        }
        public string _DayCode
        {
            get
            { return DayCode; }
            set
            { DayCode = value; }
        }
        public string _Price
        {
            get
            { return Price; }
            set
            { Price = value; }
        }
        public string _ticketid 
        { 
            get
            { return ticketid; }
            set
            { ticketid = value; }
        }
    }
}
