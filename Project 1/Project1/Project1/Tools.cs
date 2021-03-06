﻿///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Tools.cs
//	Description:       The tools class has methods to assist the translator to complete translation. Such as formatting
//                      and preparing for translation
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Sunday, Feb 24 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Project1
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

        #region Format

        /// <summary>
        /// Format  Method
        /// </summary>
        /// <param name="listIn">the list that is sent in to be formatted into one string</param>
        /// <return name = "formString">Formatted String</return>

        public static String Format(List<Name> listIn)
        {
            String formString = string.Join(" \n", listIn.ToString());
            return formString;
        }

        #endregion Format

        #region PressAnyKey

        /// <summary>
        /// Display a Press Any Key to ... message at the bottom of the screen
        /// </summary>
        /// <param name="strVerb">term in the Press Any Key to ... message; default: "continue . . ."</param>
        public static void PressAnyKey(string strVerb = "continue ...")
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (Console.CursorTop < Console.WindowHeight - 1)
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
            else
                Console.SetCursorPosition(0, Console.CursorTop + 2);

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
        /// <out name>the string that contains a persons name</out>
        /// <out phone>the phone number string</out>
        /// <out email>the email string</out>
        public static void displayWelcome(out string name, out string phone, out string email)
        {
            string tempphone;
            string tempemail;
            Console.WriteLine("Welcome to the program!\n");
            Console.WriteLine("Please enter your name..");
            name = (Console.ReadLine());
            phone = null;
            email = null;

            bool phoneVerification = true;
            while (phoneVerification == true)
            {
                Console.WriteLine("Please enter your phone number: ");
                tempphone = (Console.ReadLine());

                try
                {
                    if (string.IsNullOrEmpty(tempphone))
                    {
                        phone = "(XXX)-XXX-XXXX";
                        Console.WriteLine("Please enter a valid phone number.");
                        phoneVerification = true;
                    }
                    else
                    {
                        var r = new Regex(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$");
                        if (r.IsMatch(tempphone) == true)
                        {
                            phone = tempphone;
                            phoneVerification = false;
                        }
                        else
                        {
                            phone = "(XXX)-XXX-XXXX";
                            Console.WriteLine("Please enter a valid phone number.");
                            phoneVerification = true;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            bool emailVerification = true;
            while (emailVerification == true)
            {
                Console.WriteLine("Please enter your email address: ");
                tempemail = (Console.ReadLine());
                try
                {
                    if (string.IsNullOrEmpty(tempemail))
                    {
                        email = "default@email.com";
                        Console.WriteLine("Please enter a valid email.");
                        emailVerification = true;
                    }
                    else
                    {
                        var r = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
                        if (r.IsMatch(tempemail) == true)
                        {
                            email = tempemail;
                            emailVerification = false;
                        }
                        else
                        {
                            email = "default@email.com";
                            Console.WriteLine("Please enter a valid email.");
                            emailVerification = true;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
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