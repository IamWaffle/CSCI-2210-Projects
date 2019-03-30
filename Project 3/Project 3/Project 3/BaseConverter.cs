using System;
using System.Collections.Generic;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         BaseConverter.cs
//	Description:       this is a class with static methods to convert a decimal number to and from a base
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Friday, Mar 29 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_3
{
    internal class BaseConverter
    {
        /// <summary>
        ///  This method converts a number from a specified base to base 10 decimal
        /// </summary>
        /// <param name="inValue">the value of the number to be converted</param>
        /// <param name="inBase">the base to convert from</param>
        /// <returns>result - the transtated integer</returns>
        public static int toDecimal(string inValue, int inBase)
        {
            try
            {
                int result = 0;
                Stack<int> resultStack = new Stack<int>();

                resultStack.Push(1);
                resultStack.Push(1);
                resultStack.Push(0);

                for (int i = 0; i < resultStack.Count; i++)
                {
                    result += resultStack.Pop();
                }

                return result;
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong!");
            }
        }

        /// <summary>
        /// This method converts a number from base 10 to a specified base
        /// </summary>
        /// <param name="inValue">the value of the number to be converted</param>
        /// <param name="inBase">the base to convert to</param>
        /// <returns>result - the transtated integer as a string</returns>
        public static string fromDecimal(int inValue, int inBase)
        {
            try
            {
                string result = "";

                int Decimal = inValue;
                int rem;
                Stack<string> resultStack = new Stack<string>();

                while (Decimal != 0)
                {
                    rem = Decimal % inBase;
                    Decimal /= inBase;

                    if (rem >= 10)
                    {
                        if (rem == 10)
                        {
                            resultStack.Push('A'.ToString());
                        }
                        else if (rem == 11)
                        {
                            resultStack.Push('B'.ToString());
                        }
                        else if (rem == 12)
                        {
                            resultStack.Push('C'.ToString());
                        }
                        else if (rem == 13)
                        {
                            resultStack.Push('D'.ToString());
                        }
                        else if (rem == 14)
                        {
                            resultStack.Push('E'.ToString());
                        }
                        else if (rem == 15)
                        {
                            resultStack.Push('F'.ToString());
                        }
                        
                    }
                    else
                    {
                        resultStack.Push(rem.ToString());
                    }
                }

                int count = resultStack.Count;

                for (int i = 0; i < count; i++)
                {
                    result += resultStack.Pop();
                }

                return result;
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong!");
            }
        }
    }
}