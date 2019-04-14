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
namespace Project_4
{
    /// <summary>
    /// Interface for IContainer for a priority queue
    /// </summary>
    /// <typeparam name="T">type T</typeparam>
    public interface IContainer<T>
    {
        void Clear();

        bool IsEmpty();

        int Count { get; set; }
    }
}