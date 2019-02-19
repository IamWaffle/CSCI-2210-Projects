using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Name.cs
//	Description:       
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Tuesday, Feb 19 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
