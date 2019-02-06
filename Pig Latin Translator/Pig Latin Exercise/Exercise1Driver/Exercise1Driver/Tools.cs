using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Driver
{
    static class Tools
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
            String formString = string.Join(",", listIn);
            return formString;
        }
    }
}
