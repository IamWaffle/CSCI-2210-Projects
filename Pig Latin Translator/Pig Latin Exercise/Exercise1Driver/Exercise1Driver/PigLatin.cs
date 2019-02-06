///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  PigLatin_Exercise/PigLatin_Exercise
//	File Name:         PigLatin.cs
//	Description:       The PigLatin class accepts a string and can translate the string via the method into Pig Latin
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace Exercise1Driver
{
    internal class PigLatin
    {
        public string Original { get; set; }
        public string delimiters = " .,;:!?";
        public string translatedString = "";

        public PigLatin(String inString)
        {
            Original = inString;
            translatedString = Tools.Format(Translate(Tools.Tokenize(Original, delimiters)));
        }

        private static List<string> Translate(List<String> original)
        {
            List<string> results = new List<string>();
            string vowelsList = "aeiouAEIOU";

            for (int i = 0; i < original.Count; i++)
            {
                string word = "";

                int j = 0;
                int vowelLocation = -1;
                while (j < original[i].Length && vowelLocation < 0)
                {
                    if (vowelsList.Contains(original[i].Substring(j, 1)))
                        vowelLocation = j;
                    else
                        j += 1;
                }

                if (original[i] == ".")
                {
                    original[i] += "\n";
                }

                if (vowelLocation == 0)
                {
                    word = original[i] += "lay";
                    results.Add(word);
                }
                else if (vowelLocation > 0)
                {
                    string tempword1 = original[i].Substring(0, vowelLocation);
                    string tempword2 = original[i].Substring(vowelLocation);
                    word = tempword2 + tempword1 + "ay";
                    results.Add(word);
                }
                else
                {
                    results.Add(original[i]);
                }
            }

            return results;
        }

        public override string ToString()
        {
            string outString = translatedString;
            return outString;
        }
    }
}