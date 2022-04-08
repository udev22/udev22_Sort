using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Diagnostics; //Time
using System.Collections.Generic;

namespace Bubble_Sort_Namespace
{
    class Bubble_Sort_Class
    {
        public static void Bubble_Sort()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] a = { 56, 29, -11, -97, -47, -58, -65, -23, -65, -26, -60, -13, 27, 57, 63 };
            int t;
            Write("Besilgan Massiv: ");
            foreach (int aa in a)
                Write(aa + " ");

            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Write("\n"+"Saralangan Massiv: ");
            foreach (int aa in a)
                Write(aa + " ");
            Write("\n");

            stopwatch.Stop();
            WriteLine($"Time: {stopwatch.ElapsedMilliseconds} Milliseconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds} Seconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalMinutes} Minutes");
        }
    }
}
