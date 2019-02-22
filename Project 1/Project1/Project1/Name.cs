﻿using System;

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

        public String lastName, firstName, middle;
        public String last, rest, suffix;

        public string delimiters = "., -_   ''\n";

        public Name()
        {
            personNameFull = null;
        }

        public Name(Name original)
        {
            personNameFull = original.personNameFull;
            Tools.Tokenize(original.personNameFull, delimiters);
        }

        public Name(string inName)
        {
            nameBreakdown(inName);
        }

        public bool Equals(Name other)
        {
            if (other.last.ToLower() == last.ToLower() && other.middle.ToLower() == middle.ToLower() && other.suffix.ToLower() == suffix.ToLower())
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
            String output;
            return null;
        }

        public String lastNameFirst()
        {
            String output;
            return null;
        }

        public void nameBreakdown(String nameFull)
        {
        }

        public String ToString()
        {
            return personNameFull;
        }
    }
}