using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{

    enum EVENTTYPE { ENTER, LEAVE};
    class Evnt : IComparable
    {
        public EVENTTYPE Type { get; set;  }
        public DateTime Time { get; set; }
        public int Patron { get; set;  }


        public Evnt()
        {
            Type = EVENTTYPE.ENTER;
            Time = DateTime.Now;
            Patron = -1;
        }

        public Evnt (EVENTTYPE type, DateTime time, int patron)
        {
            Type = type;
            Time = time;
            Patron = patron;
        }

        public override string ToString()
        {
            String str = "";
            str += String.Format("Patron {0}", Patron.ToString().PadLeft(3));
            str += Type + "'s";
            str += String.Format(" at {0}", Time.ToShortTimeString().PadLeft(8));

            return str;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Evnt))
            {
                throw new ArgumentException("The argument is not an Evnt object.");
            }

            Evnt r = (Evnt)obj;
            return (r.Time.CompareTo(Time));
        }
    }
}
