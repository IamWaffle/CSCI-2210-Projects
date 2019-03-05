using System;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Program.cs
//	Description:       This is where the main method is stored.
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Monday, Mar 04 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSpash());
            Application.Run(new frmMain());
        }
    }
}