///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Tools.cs
//	Description:       The tools class has methods to assist the translator to complete translation. Such as formatting
//                      and preparing for translation
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Thursday, Apr 18 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Project_5
{
    /// <summary>
    ///  This class has methods to assist the translator to complete translation. Such as formatting
    //   and preparing for translation
    /// </summary>
    internal static class Tools
    {
        #region Tokenize

        /// <summary>
        /// Tokenize -  accepts a string, find the delimiters, returns list with each word/delimiter split
        /// </summary>
        /// <param name="strIn">the string that is sent in to be formatted into a list</param>
        /// <param name="strDelims">the delimiters that are used to format the string</param>
        /// <return name = "outList">Output List</return>
        public static List<String> Tokenize(string strIn, string strDelims)
        {
            StringBuilder builder = new StringBuilder(strIn);
            string newString = "";
            char[] delims = strDelims.ToCharArray();

            int y = 0;
            while (y < strDelims.Length)
            {
                int i = 0;
                while (i < strIn.Length)
                {
                    string a = strIn[i].ToString();
                    string b = strDelims[y].ToString();

                    if (a == b)
                    {
                        builder.Replace(a, "|");
                        newString = builder.ToString();
                    }

                    i++;
                }
                y++;
            }
            List<string> outList = newString.Split('|').ToList();
            outList = outList.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            return outList;
        }

        #endregion Tokenize

        #region PressAnyKey

        /// <summary>
        /// Display a Press Any Key to ... message at the bottom of the screen
        /// </summary>
        /// <param name="strVerb">term in the Press Any Key to ... message; default: "continue . . ."</param>
        public static void PressAnyKey(string strVerb = "continue ...")
        {
            Console.Write("Press any key to " + strVerb);
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        } // End PressAnyKey

        #endregion PressAnyKey

        #region Skip

        /// <summary>
        /// Skip n lines in the console window
        /// </summary>
        /// <param name="n">the number of lines to skip - defaults to 1</param>
        public static void Skip(int n = 1)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
            }
        }

        #endregion Skip

        #region DisplayWelcomeExit

        /// <summary>
        /// displayWelcome - displays a welcome message asking for user credentials, then verifies
        /// and returns the name phone and email of the person
        ///
        /// </summary>
        /// <param name = "inName">the name string passed in</param>
        /// <param name = "inPhone">the phone string passed in</param>
        /// <param name = "inEmail">the email string passed in</param>
        /// <out name>the string that contains a persons name</out>
        /// <out phone>the phone number string</out>
        /// <out email>the email string</out>
        public static void displayWelcome(out string name, out string phone, out string email, string inName, string inPhone, string inEmail)
        {
            string tempphone;
            string tempemail;

            if (string.IsNullOrEmpty(inName))
            {
                name = null;
                throw new Exception("No Name");
            }
            else
            {
                name = inName;
            }

            tempphone = inPhone;

            try
            {
                if (string.IsNullOrEmpty(tempphone))
                {
                    phone = null;
                    throw new Exception("Phone number invalid");
                }
                else
                {
                    var r = new Regex(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$");
                    if (r.IsMatch(tempphone) == true)
                    {
                        phone = tempphone;
                    }
                    else
                    {
                        phone = null;
                        throw new Exception("Phone number invalid");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            tempemail = inEmail;
            try
            {
                if (string.IsNullOrEmpty(tempemail))
                {
                    email = null;
                    throw new Exception("Email not valid");
                }
                else
                {
                    var r = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");

                    if (r.IsMatch(tempemail) == true)
                    {
                        email = tempemail;
                    }
                    else
                    {
                        email = null;
                        throw new Exception("Email not valid");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// displayExit - displays a message that shows the credentials. a name phone and email
        ///
        /// </summary>
        /// <param name>the string that contains a persons name</param>
        /// <param phone>the phone number string</param>
        /// <param email>the email string</param>
        public static void displayExit(string name, string phone, string email)
        {
            Skip();
            Console.WriteLine("Goodbye " + name + "!" +
                              "\nThank you for using the program!\n\n\n\nYour credentials:\nName: " + name +
                              "\nPhone: " + phone + "\nEmail: " + email);
        }
    }

    #endregion DisplayWelcomeExit
}