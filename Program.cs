using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics; //Time
using Iterative_Heap_Sort_Namespace;
using Binary_Insertion_Sort_2_Iterativ_Namespace;
using Binary_Insertion_Sort_Namespace;
using Radix_Sort_Namespace;
using Quick_Sort_Namespace;
using Shell_Sort_Namespace;
using Bubble_Sort_Namespace;
using Counting_Sort_Namespace;

namespace Sort_Seacher_Time_Size
{
    public class Program
    {
        public static void Memory()
        {
            // bu yerdagi metodimizning vazifasi sartirofka jarayoni qancha joy egallashi yani memory
            System.Diagnostics.Process proc = System.Diagnostics.Process.GetCurrentProcess();
            WriteLine("Current process: {0}", proc.ToString());

            WriteLine("Private Memory: {0}", proc.PrivateMemorySize64);
            WriteLine("Virtual Memory: {0}", proc.VirtualMemorySize64);
            WriteLine("Working Set: {0}", proc.WorkingSet64);
            WriteLine("Paged Memory: {0}", proc.PagedMemorySize64);
            WriteLine("Paged System Memory: {0}", proc.PagedSystemMemorySize64);
            WriteLine("Non-paged System Memory: {0}", proc.NonpagedSystemMemorySize64);
        }
        public static void Iterative_Heap_Sort_Main()
        {
            var stopwatch = new Stopwatch(); // Sartirofka uchun sarflangan vaqtni hisoblovchi qoshimcha codning bir qismi
            stopwatch.Start();

            int[] arr = { 56, 29, -11, -97, -47, -58, -65, -23, -65, -26, -60, -13, 27, 57, 63 };
            int n = arr.Length;

            Write("Berilgan Massiv: ");
            Iterative_Heap_Sort_Class.printArray(arr);

            Iterative_Heap_Sort_Class.heapSort(arr, n);

            Write("Saralangan Massiv: ");
            Iterative_Heap_Sort_Class.printArray(arr);

            stopwatch.Stop();
            WriteLine($"Time: {stopwatch.ElapsedMilliseconds} Milliseconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds} Seconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalMinutes} Minutes");
        }
        public static void Binary_Insertion_Sort_2_Iterativ_Main()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] a = { 56, 29, -11, -97, -47, -58, -65, -23, -65, -26, -60, -13, 27, 57, 63 };
            int n = a.Length, i;

            Binary_Insertion_Sort_2_Iterativ_Class.insertionSort(a, n);

            WriteLine("Berilgan Massiv: 56 29 -11 -97 -47 -58 -65 -23 -65 -26 -60 -13 27 57 63");
            Write("Saralangan Massiv: ");
            for (i = 0; i < n; i++)
                Write(a[i] + " ");

            WriteLine();
            stopwatch.Stop();
            WriteLine($"Time: {stopwatch.ElapsedMilliseconds} Milliseconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds} Seconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalMinutes} Minutes");
        }
        public static void Binary_Insertion_Sort_Main()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] arr = { 56, 29, -11, -97, -47, -58, -65, -23, -65, -26, -60, -13, 27, 57, 63 };
            Binary_Insertion_Sort_Class.sort(arr);
            WriteLine("Berilgan Massiv: 56 29 -11 -97 -47 -58 -65 -23 -65 -26 -60 -13 27 57 63");
            Write("Saralangan Massiv: ");
            for (int i = 0; i < arr.Length; i++)
                Write(arr[i] + " ");

            WriteLine();
            stopwatch.Stop();
            WriteLine($"Time: {stopwatch.ElapsedMilliseconds} Milliseconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds} Seconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalMinutes} Minutes");
        }
        public static void Radix_Sort_Main()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            
            int[] arr = new int[] { 56, 29, -11, -97, -47, -58, -65, -23, -65, -26, -60, -13, 27, 57, 63 };
            Write("Berilgan Massiv: ");
            foreach (var item in arr)
            {
                Write(" " + item);
            }
            WriteLine();

            Radix_Sort_Class.Sort(arr);
            Write("Saralangan Massiv: ");
            foreach (var item in arr)
            {
                Write(" " + item);
            }
            WriteLine();

            stopwatch.Stop();
            WriteLine($"Time: {stopwatch.ElapsedMilliseconds} Milliseconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds} Seconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalMinutes} Minutes");
        }
        public static void Quick_Sort_Main()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] arr = new int[] { 56, 29, -11, -97, -47, -58, -65, -23, -65, -26, -60, -13, 27, 57, 63 };

            Write("Berilgan Massiv: ");
            foreach (var item in arr)
            {
                Write(" " + item);
            }
            WriteLine();

            Quick_Sort_Class.Quick_Sort(arr, 0, arr.Length - 1);

            Write("Saralangan Massiv: ");
            foreach (var item in arr)
            {
                Write(" " + item);
            }
            WriteLine();

            stopwatch.Stop();
            WriteLine($"Time: {stopwatch.ElapsedMilliseconds} Milliseconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds} Seconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalMinutes} Minutes");
        }
        public static void Shell_Sort_Main()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] arr = new int[] { 56, 29, -11, -97, -47, -58, -65, -23, -65, -26, -60, -13, 27, 57, 63 };
            int n;

            n = arr.Length;
            Write("Besilgan Massiv: ");
            Shell_Sort_Class.show_array_elements(arr);
            Shell_Sort_Class.shellSort(arr, n);
            Write("Saralangan Massiv: ");
            Shell_Sort_Class.show_array_elements(arr);

            stopwatch.Stop();
            WriteLine($"Time: {stopwatch.ElapsedMilliseconds} Milliseconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds} Seconds");
            WriteLine($"Time: {stopwatch.Elapsed.TotalMinutes} Minutes");
        }
        public static void Main(String[] args)
        {
            WriteLine("\tIterative Heap Sort");
            Iterative_Heap_Sort_Main();
            Memory();
            WriteLine();
            ReadKey();
            WriteLine("\tBinary Insertion Sort 2 Iterativ");
            Binary_Insertion_Sort_2_Iterativ_Main();
            Memory();
            WriteLine();
            ReadKey();
            WriteLine("\tBinary Insertion Sort");
            Binary_Insertion_Sort_Main();
            Memory();
            WriteLine();
            ReadKey();
            WriteLine("\tRadix Sort");
            Radix_Sort_Main();
            Memory();
            WriteLine();
            ReadKey();
            WriteLine("\tQuick Sort");
            Quick_Sort_Main();
            Memory();
            WriteLine();
            ReadKey();
            WriteLine("\tShell Sort");
            Shell_Sort_Main();
            Memory();
            WriteLine();
            ReadKey();
            WriteLine("\tBubble Sort");
            Bubble_Sort_Class.Bubble_Sort();
            Memory();
            WriteLine();
            ReadKey();
            WriteLine("\tCounting Search");
            Counting_Sort_Class.Counting_Sort();
            Memory();
            WriteLine();
            ReadKey();
        }
    }
}