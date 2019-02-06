using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Driver
{
   class PigLatin
        {
            public string Original { get; set; }
            public string delimiters = " .,;:!?";

            public PigLatin(String inString)
            {
                Original = inString;
                Console.WriteLine(Translate(Tools.Tokenize(Original, delimiters)));

            }

            static string Translate(List<String> original)
            {
                List<string> newWords = new List<string>();


                for (int i = 0; i < original.Count; i++)
                {
                    int vowelLocation = -2;
                    string word = "";

                    char[] vowelsList = new char[] { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };

                    foreach (char vowel in vowelsList)
                    {
                        if (original[i].Contains(vowel))
                        {
                            vowelLocation = original[i].IndexOf(vowel);

                        }
                    }

                    if (vowelLocation == 0)
                    {
                        word = original[i] += "lay";
                        newWords.Add(word);
                    }
                    else if (vowelLocation > 0)
                    {
                        string tempword1 = original[i].Substring(0, vowelLocation);
                        string tempword2 = original[i].Substring(vowelLocation);
                        word = tempword2 + tempword1 + "ay";
                        newWords.Add(word);
                    }
                    else
                    {

                        newWords.Add(original[i]);
                    }

                    Console.WriteLine(newWords[i]);
                }

                string hey = "f";
                return hey;
            }


        }
}

