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
        public String personNameFull;
        public String phoneNumber;
        public String email;

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
            if (other.firstName.ToLower() == firstName.ToLower() 
                && other.middle.ToLower() == middle.ToLower()
                && other.lastName.ToLower() == lastName.ToLower() 
                && other.end.ToLower() == end.ToLower())
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
            return 3;
        }

        public String firstNameFirst()
        {
            String output = firstName + middle + lastName + end;
            return output;
        }

        public String lastNameFirst()
        {
            String output = lastName + firstName + middle + end;
            return null;
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