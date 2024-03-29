﻿using System;
namespace Exercise5
{
    public class InsertionSort : extends SuperSorter
    {
        public InsertionSort()
        {
        }

        public static void IntArrayInsertionSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    exchange(data, i, i - 1);
                }
            }
        }

    }
}

