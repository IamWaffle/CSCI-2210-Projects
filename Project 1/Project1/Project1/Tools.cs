///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Tools.cs
//	Description:       The tools class has methods to assist the translator to complete translation. Such as formatting
//                      and preparing for translation
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Tuesday, Feb 19 2019
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
            List<String> Tokens = new List<String>();
            String Work = strIn.Trim(" /t".ToCharArray());

            while (!String.IsNullOrEmpty(Work))
            {
                int Col = Work.IndexOfAny(strDelims.ToCharArray());
                if (Col == -1)
                {
                    Tokens.Add(Work);
                    Work = "";
                }
                else
                {
                    if (Col < 0 || Col > 0)
                    {
                        Tokens.Add(Work.Substring(0, Col));
                    }

                    if (Col + 1 < Work.Length)
                    {
                        Work = Work.Substring(Col + 1);
                    }
                    else
                    {
                        Work = "";
                    }
                }

                for (int i = 0; i < Tokens.Count; i++)
                {
                    Console.WriteLine(Tokens[i]);
                }
            }

            return Tokens;
        }
    


#endregion Tokenize

        #region Format

        /// <summary>
        /// Format  Method
        /// </summary>
        /// <param name="listIn">the list that is sent in to be formatted into one string</param>
        /// <return name = "formString">Formatted String</return>

        public static String Format(List<String> listIn)
        {
            String formString = string.Join(" \n", listIn);
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

        public static void displayWelcome(out string name, out string phone, out string email)
        {
            string tempphone;
            string tempemail;
            Console.WriteLine("Welcome to the program!\n");
            Console.WriteLine("Please enter your name.. ");
            name = (Console.ReadLine());
            Console.WriteLine("Please enter your phone number: ");
            tempphone = (Console.ReadLine());
            Console.WriteLine("Please enter your email address: ");
            tempemail = (Console.ReadLine());

            try
            {
                if (string.IsNullOrEmpty(tempphone))
                {
                    phone = "(XXX)-XXX-XXXX";
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
                        phone = "(XXX)-XXX-XXXX";
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                if (string.IsNullOrEmpty(tempemail))
                {
                    email = "default@email.com";
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
                        email = "default@email.com";
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void displayExit(string name, string phone, string email)
        {
            Skip();
            Console.WriteLine("Goodbye " + name +
                              "\nThank you for using the program!\n\n\n\nYour credentials:\nName: " + name +
                              "\nPhone: " + phone + "\nEmail: " + email);
        }
    }
}