using System;
using System.Collections.Generic;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Name.cs
//	Description:
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Thursday, Feb 21 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project1
{
    internal class Name : IEquatable<Name>, IComparable<Name>
    {
        public String personNameFull { get; set; }
        public String phoneNumber { get; set; }
        public String email { get; set; }

        public String firstName, middle, lastName, end;

        private List<string> nameParts = new List<string>();

        public Name()
        {
            personNameFull = null;
        }

        public Name(Name original)
        {
            personNameFull = original.personNameFull;
            Tools.Tokenize(original.personNameFull, " ");
        }

        public Name(string inName)
        {
            personNameFull = inName;
            nameBreakdown(inName);
        }

        public bool Equals(Name other)
        {
            if (other.personNameFull == personNameFull)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(Name other)
        {
            int output;

            if (personNameFull.Length > other.personNameFull.Length)
            {
                output = 1;
            }
            return 3;
        }

        public String firstNameFirst()
        {

            String output;

            if (end == null)
            {
                output = firstName + " " + middle + " " + lastName;
            }
            else
            {
                output = firstName + " " + middle + " " + lastName + ", " + end;
            }
            
            return output;
        }

        public String lastNameFirst()
        {
            String output;

            if (end == null)
            {
                output = lastName + ", " + firstName + " " + middle;
            }
            else
            {
                output = lastName + ", " + firstName + " " + middle + ", " + end;
            }
            return output;
        }

        public void nameBreakdown(String nameFull)
        {
            nameParts = Tools.Tokenize(nameFull, " ");

            if (nameParts.Count == 1)
            {
                firstName = nameParts[0];
            }
            else if (nameParts.Count == 2)
            {
                firstName = nameParts[0];
                lastName = nameParts[1];
            }
            else if (nameParts.Count == 3)
            {
                firstName = nameParts[0];
                middle = nameParts[1];
                lastName = nameParts[2];

            }
            else if (nameParts.Count == 4)
            {
                firstName = nameParts[0];
                middle = nameParts[1];
                lastName = nameParts[2];
                end = nameParts[3];
            }
            else
            {
                
            }
        }

        public String ToString()
        {
            return personNameFull;
        }
    }
}