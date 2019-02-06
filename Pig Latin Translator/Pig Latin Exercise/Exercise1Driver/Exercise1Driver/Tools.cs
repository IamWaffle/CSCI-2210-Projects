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
    internal static class Tools
    {
        public static List<String> Tokenize(string strIn, string strDelims)
        {
            StringBuilder builder = new StringBuilder(strIn);
            string newString = "";

            int y = 0;
            while (y < strIn.Length)
            {
                int i = 0;
                while (i < strDelims.Length)
                {
                    string a = strIn[y].ToString();
                    string b = strDelims[i].ToString();

                    if (a == b)
                    {
                        builder.Replace(a, "|" + a + "|");
                        newString = builder.ToString();
                    }
                    i++;
                }
                y++;
            }
            List<string> outList = newString.Split('|').ToList();

            return outList;
        }

        public static String Format(List<String> listIn)
        {
            String formString = string.Join("", listIn);
            return formString;
        }
    }
}