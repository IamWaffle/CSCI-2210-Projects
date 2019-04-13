///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Tools.cs
//	Description:       The tools class has methods to assist the translator to complete translation. Such as formatting
//                      and preparing for translation
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Apr 09 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Project4
{
    /// <summary>
    ///  This class has methods to assist the translator to complete translation. Such as formatting
    //   and preparing for translation
    /// </summary>
    internal static class Tools
    {

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
    }
}