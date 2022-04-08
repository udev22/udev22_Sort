using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Diagnostics; //Time
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Counting_Sort_Namespace
{
    class Counting_Sort_Class
    {
        public static void Counting_Sort()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] array = { 56, 29, -11, -97, -47, -58, -65, -23, -65, -26, -60, -13, 27, 57, 63 };

            Write("Berilgan Massiv: ");
            foreach (int aa in array)
                Write(aa + " ");

            int[] sortedArray = new int[array.Length];

            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            int[] counts = new int[maxVal - minVal + 1];

            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            Write("\n" + "Saralangan Massiv: ");
            foreach (int aa in sortedArray)
                Write(aa + " ");
            Write("\n");

            stopwatch.Stop();
            WriteLine($"Time: {stopwatch.ElapsedMilliseconds} Milliseconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds} Seconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalMinutes} Minutes");
        }
    }
}
