using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class BaseConverter
    {

        //THIS IS TEMP<<<<<
        // NEED TO REDO WITH THE STACK CLASS
        public static int toDecimal(string inValue, int inBase)
        {
            try
            {
                int result;
                result = Convert.ToInt32(inValue, inBase);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong!");
            }
        }

        public static string fromDecimal(int inValue, int inBase)
        {
            try
            {
                string result = "";
                result = Convert.ToString(inValue, inBase);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong!");
            }
            
        }
    }
}
