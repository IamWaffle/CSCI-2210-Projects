using System;
using System.Collections.Generic;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Name.cs
//	Description:       Name class contains attributes of a persons name.
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Monday, Feb 25 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project2
{
    internal class Name : IEquatable<Name>, IComparable<Name>
    {
        public String personNameFull { get; set; }
        public String phoneNumber { get; set; }
        public String email { get; set; }

        public String firstName, middle, lastName, end;

        private List<string> nameParts = new List<string>();

        #region Constructors

        /// <summary>
        ///  Basic constructor that does not take any parameters
        /// </summary>
        public Name()
        {
            personNameFull = null;
        }

        /// <summary>
        ///  Basic copy constructor. Takes in a name list and creates an identical new one.
        /// </summary>
        /// <param NameList original>the NameList to be copied</param>
        public Name(Name original)
        {
            personNameFull = original.personNameFull;
            Tools.Tokenize(original.personNameFull, " ");
            nameBreakdown(original.personNameFull);
        }

        /// <summary>
        ///  Basic constructor creates a name with the string passed in
        /// </summary>
        /// <param String inNames>string of names with a delimiter</param>
        public Name(string inName)
        {
            personNameFull = inName;
            nameBreakdown(inName);
            Tools.Tokenize(inName, " ");
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        ///  Equals - method that determines if a name equals another name
        /// </summary>
        /// <param name="other">the name passed in to be determined if it is equal</param>
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

        /// <summary>
        ///  CompareTo - method that determines how a name is greater or less than another name
        /// </summary>
        /// <param name="other">the name passed in</param>
        public int CompareTo(Name other)
        {
            if (personNameFull.Length > other.personNameFull.Length)
            {
                return -1;
            }

            if (personNameFull == other.personNameFull)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        ///  firstNameFirst - returns a string with the name ordered first name first
        /// </summary>
        /// <return name="output">the name passed out that is formatted</return>
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

        /// <summary>
        ///  lastNameFirst - returns a string with the name ordered last name first
        /// </summary>
        /// <return name="output">the name passed out that is formatted</return>
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

        /// <summary>
        ///  nameBreakdown - takes in a string and breaks it up into first middle last and end variables.
        /// </summary>
        /// <param name="nameFull">the full name</param>
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

        /// <summary>
        ///  ToString - formatted string
        /// </summary>
        /// <return name="personNameFull">the full name returned as it was read in</return>
        public override String ToString()
        {
            return personNameFull;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion Methods
    }
}