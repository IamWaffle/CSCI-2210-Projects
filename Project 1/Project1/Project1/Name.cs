using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{   
    class Name
    {
        public String personName { get; set; }

        public Name()
        {

        }

        public Name(Name original)
        {
            personName = original.personName;
        }

       public Name(string inName)
        {

        }

    }


}
