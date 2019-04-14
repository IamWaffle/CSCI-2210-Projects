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
    /// <summary>
    /// Enum type for enter and leaving events.
    /// </summary>
    internal enum EVENTTYPE
    { ENTER, LEAVE };

    /// <summary>
    /// This is the event class that creates random entering and leaving events
    /// </summary>
    internal class Event : IComparable
    {
        public EVENTTYPE Type { get; set; }
        public DateTime Time { get; set; }
        public int Patron { get; set; }


        #region Constructors
        /// <summary>
        /// Basic no arg constructor if needed
        /// </summary>
        public Event()
        {
            Type = EVENTTYPE.ENTER;
            Time = DateTime.Now;
            Patron = -1;
        }

        /// <summary>
        /// Constructor that generates an event based on parameters
        /// </summary>
        /// <param name="type"> the type of the event</param>
        /// <param name="time"> the time the event occured</param>
        /// <param name="patron">the number of the patron
</param>
        public Event(EVENTTYPE type, DateTime time, int patron)
        {
            Type = type;
            Time = time;
            Patron = patron;
        }
        #endregion Constructors

        #region Override Methods
        /// <summary>
        /// ToString returns a formatted string that includes the time event type and patron number
        /// </summary>
        /// <returns>str - the output string</returns>
        public override string ToString()
        {
            String str = "";
            str += String.Format("Patron {0} ", Patron.ToString().PadLeft(3));
            str += Type + "'s";
            str += String.Format(" at {0} ", Time.ToShortTimeString().PadLeft(8));

            return str;
        }
        /// <summary>
        /// Compare to compares the time of the two events to see if they are greater less than or equal to the
        /// other event object passed in
        /// </summary>
        /// <param name="obj">the object to compare.</param>
        /// <returns>int 1, 0, -1</returns>
        public int CompareTo(object obj)
        {
            if (!(obj is Event))
            {
                throw new ArgumentException("The argument is not an Event object.");
            }

            Event r = (Event)obj;
            return (r.Time.CompareTo(Time));
        }
        #endregion Override Methods
    }
}