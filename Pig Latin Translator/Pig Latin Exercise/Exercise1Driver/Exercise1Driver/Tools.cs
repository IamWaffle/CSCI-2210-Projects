///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  PigLatin_Exercise/PigLatin_Exercise
//	File Name:         Tools.cs
//	Description:       The tools class has methods to assist the translator to complete translation. Such as formatting
//                      and preparing for translation
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1Driver
{
    /// <summary>
    ///  This class has methods to assist the translator to complete translation. Such as formatting
    //   and preparing for translation
    /// </summary>
    static class Tools
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

            // int y = 0;
            // while (y < strIn.Length)
            // {
            //     int i = 0;
            //    while (i < strDelims.Length)
            //    {
            //        string a = strIn[y].ToString();
            //        string b = strDelims[i].ToString();
            //
            //        if (a == b)
            //       {
            //           builder.Replace(a, "|" + a + "|");
            //           newString = builder.ToString();
            //       }
            //       i++;
            //   }
            //   y++;
            // }
            List<string> outList = newString.Split(delims).ToList();

            for (int x = 0; x < outList.Count; x++)
            {
                Console.WriteLine(outList[x]);
            }
            return outList;
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
            String formString = string.Join("", listIn);
            return formString;
        }

        #endregion Format
    }
}