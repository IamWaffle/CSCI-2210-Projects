using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Driver
{
   class PigLatin
        {
            public string Original { get; set; }
            public string delimiters = " .,;:!?";
            public string translatedString = "";

            public PigLatin(String inString)
            {
                Original = inString;
                translatedString = Tools.Format(Translate(Tools.Tokenize(Original, delimiters)));

            }

            static List<string> Translate(List<String> original)
            {
                List<string> results = new List<string>();


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

