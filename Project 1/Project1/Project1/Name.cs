using System;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Name.cs
//	Description:
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Tuesday, Feb 21 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project1
{
    internal class Name : IEquatable<Name>, IComparable<Name>
    {
        private String _personNameFull;

        public String personNameFull
        {
            get;
            set;
        }

        public String lastName, firstName, middle;
        public String last, rest, suffix;

        public Name()
        {
            personNameFull = null;
        }

        public Name(Name original)
        {
            personNameFull = original.personNameFull;
        }

        public Name(string inName)
        {
            personNameFull = inName;
        }

        public bool Equals(Name other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Name other)
        {
            throw new NotImplementedException();
        }

        public String firstNameFirst()
        {
            return null;
        }

        public String lastNameFirst()
        {
            return null;
        }

        public void nameBreakdown(String nameFull)
        {
        }
    }
}