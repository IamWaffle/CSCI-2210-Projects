using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Program.cs
//	Description:        Write a short program that fills different list<int>’s of 100 integers with the same random non-negative integer values,
//                      sorts them using the Sink, Selection, Insertion, Mergesort, Quicksort (original), Quicksort (median-of-three),
//                      Shell (gap determined using 2.2 as in the lecture), Counting, and Radix (base 10, least significant digit) routines

//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Mar 19 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace ProfilingResearch
{
    class Program
    {
        private static int N = 100;
        private static Random ran = new Random();

        static void Main(string[] args)
        {
           List<int> intList = new List<int>(N);


        }

        private static void sinkSort(List<int> inList)
        {
            bool sorted = false;
            int pass = 0;

            while (!sorted && (pass < N))
            {
                pass++;
                sorted = true;

                for (int i = 0; i < N - pass; i++)
                {
                    if (inList[i] > inList[i + 1])
                    {
                        Swap(inList, i, i + 1);
                        sorted = false;
                    }
                }
            }
        }

        private static void Swap(List<int> inList, int n, int m)
        {
            int temp = inList[n];
            inList[n] = inList[m];
            inList[m] = temp;
        }

        private static void InsertionSort(List<int> inList)
        {
            int temp, j;
            for(int i = 1; i < N; i++)
            {
                temp = inList[i];

                for (j = i; j > 0 && temp < inList[j - 1]; j--)
                {
                    inList[j] = inList[j - 1];
                }

                inList[j] = temp;
            }
        }

        private static void SelectionSort(List<int> list, int n)
        {
            if (n <= 1)
            {
                return;
            }

            int max = Max(list, n);

            if (list[max] != list[n - 1])
            {
                Swap(list, max, n - 1);

            }

            SelectionSort(list, n - 1);

        }

        private static int Max(List<int> list, int n)
        {
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (list[max] < list[i])
                {
                    max = i;
                }
            }

            return max;
        }

        private static void OriginalQuickSort(List<int> list)
        {
            QuickSort(list, 0, list.Count - 1);
        }

        private static void QuickSort(List<int> list, int start, int end)
        {
            int left = start;
            int right = end;

            if (left >= right)
            {
                return;
            }

            while (left < right)
            {
                while (list[left] <= list[right] && left < right)
                {
                    right--;
                }

                if (left < right)
                {
                    Swap(list, left, right);
                }

                while (list[left] <= list[right] && left < right)
                {
                    left++;
                }

                if (left < right)
                {
                    Swap(list, left, right);
                }

                QuickSort(list, start, left - 1);  //sort left partition
                QuickSort(list, right + 1, end);    //sort right partition
            }


        }

        private static void QuickmedianOfThreeSort(List<int> list)
        {
            QuickMedOfThreeSort(list, 0, list.Count - 1);
        }

        private static void QuickMedOfThreeSort(List<int> list, int start, int end)
        {
            const int cutoff = 10;

            if (start + cutoff > end)
            {
                InsertSort(list, start, end);

            }
            else
            {
                int middle = (start + end) / 2;
                if (list[middle] < list[start])
                {
                    Swap(list, start, middle);

                }

                if (list[end] < list[start])
                {
                    Swap(list, start, end);
                }

                if (list[end] < list[middle])
                {
                    Swap(list, middle, end);
                }

                int pivot = list[middle];
                Swap(list, middle, end - 1);

                int left, right;
                for (left = start, right = end - 1;;)
                {
                    while (list[++left] < pivot)
                        ;
                    while (pivot < list[--right])
                        ;
                    if (left < right)
                    {
                        Swap(list, left, right);

                    }
                    else
                    {
                        break;
                    }
                }

                Swap(list, left, end - 1);

                QuickMedOfThreeSort(list, start, left - 1);
                QuickMedOfThreeSort(list, left + 1, end);
            }
        }

        private static void InsertSort(List<int> list, int start, int end)
        {
            int temp, j;
            for (int i = start + 1; i <= end; i++)
            {
                temp = list[i];
                for(j= i; j > start && temp < list[j - 1]; j--)
                {
                    list[j] = list[j - 1];
                }

                list[j] = temp;
            }
        }

        private static void ShellSort(List<int> list)
        {
            for (int gap = N / 2; gap > 0; gap = (gap == 2 ? 1 : (int) (gap / 2.2)))
            {
                int temp, j;
                for (int i = gap; i < N; i++)
                {
                    temp = list[i];

                    for (j = i; j >= gap && temp < list[j - gap]; j -= gap)
                    {
                        list[j] = list[j - gap];
                    }

                    list[j] = temp;
                }
            } 
        }

        private static List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            List<int> result = new List<int>();
            List<int> left = new List<int>();
            List<int> right= new List<int>();

            int middle = list.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }
            for(int i = middle; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            if (left[left.Count - 1] <= right[0])
            {
                return append(left, right);
            }

            result = merge(left, right);
            return result;


        }

        private static List<int> merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);

            }

            return result;
        }

        private static List<int> append(List<int> left, List<int> right)
        {
            List<int> result = new List<int>(left);
            foreach (int n in right)
            {
                result.Add(n);
            }

            return result;
        }

        private static List<int> CountingSort(List<int> list)
        {
            List<int> newList = new List<int>(list);

            int max = list.Max();
            int[] counts = new int[max + 1];
            for (int i = 0; i <= max; i++)
            {
                counts[i] = 0;
            }

            for (int i = 0; i < list.Count; i++)
            {
                counts[list[i]]++;
            }

            for (int i = 1; i <= max; i++)
            {
                counts[i] += counts[i - 1];
            }

            for (int i = 0; i < newList.Count; i++)
            {
                newList[counts[list[i]] - 1] = list[i];
                counts[list[i]]--;
            }

            return newList;
        }


        private static List<int> Radix10LSDSort(List<int> list)
        {
            List<List<int>> bin = new List<List<int>>(10);

            for (int i = 0; i < 10; i++)
            {
                bin.Add(new List<int>(list.Count));
            }

            int numDigits = list.Max().ToString().Length;

            for (int i = 0; i < numDigits; i++)
            {
                for (int n = 0; n < list.Count; n++)
                {
                    bin[Digit(list[n], i)].Add(list[n]);
                }

                CopyToResult(bin, list);

                for (int x = 0; x < 10; x++)
                {
                    bin[i].Clear();
                }
            }

            return list;
        }

        private static void CopyToResult(List<List<int>> bin, List<int> result)
        {
            result.Clear();
            for (int i = 0; i < 10; i++)
            {
                foreach (int j in bin[i])
                {
                    result.Add(j);
                }
            }
        }

        private static int Digit(int value, int digitPosition)
        {
            return (value / (int) Math.Pow(10, digitPosition) % 10);
        }
    }
}
