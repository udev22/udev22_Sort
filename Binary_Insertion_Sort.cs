using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Binary_Insertion_Sort_Namespace
{
    class Binary_Insertion_Sort_Class
    {
        public static void sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int x = array[i];

                // Find location to insert using
                // binary search
                int j = Math.Abs(
                    Array.BinarySearch(array, 0, i, x) + 1);

                // Shifting array to one location right
                System.Array.Copy(array, j, array, j + 1, i - j);

                // Placing element at its correct
                // location
                array[j] = x;
            }
        }
    }
}

// This code is contributed by udev22