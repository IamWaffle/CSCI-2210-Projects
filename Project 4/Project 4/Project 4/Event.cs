using System;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:        Event.cs
//	Description:       The event class creates events for a customer entering and entering the checkout queue.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Apr 09 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_4
{
    internal enum EVENTTYPE
    { ENTER, LEAVE };

    internal class Event : IComparable
    {
        public EVENTTYPE Type { get; set; }
        public DateTime Time { get; set; }
        public int Patron { get; set; }

        public Event()
        {
            Type = EVENTTYPE.ENTER;
            Time = DateTime.Now;
            Patron = -1;
        }

        public Event(EVENTTYPE type, DateTime time, int patron)
        {
            Type = type;
            Time = time;
            Patron = patron;
        }

        public override string ToString()
        {
            String str = "";
            str += String.Format("Patron {0} ", Patron.ToString().PadLeft(3));
            str += Type + "'s";
            str += String.Format(" at {0} ", Time.ToShortTimeString().PadLeft(8));

            return str;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Event))
            {
                throw new ArgumentException("The argument is not an Event object.");
            }

            Event r = (Event)obj;
            return (r.Time.CompareTo(Time));
        }
    }
}