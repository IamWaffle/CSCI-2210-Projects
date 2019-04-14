namespace Project_4
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    //	File Name:         IContainer.cs
    //	Description:       This is a required class for a priority queue.
    //
    //	Course:            CSCI 2210 - Data Structures
    //	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
    //	Created:           Tuesday, Apr 09 2019
    //
    //
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public interface IContainer<T>
    {
        void Clear();

        bool IsEmpty();

        int Count { get; set; }
    }
}