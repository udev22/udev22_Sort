using System;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Iterative_Heap_Sort_Namespace
{
	class Iterative_Heap_Sort_Class
	{
		//Har bir bolaning qiymati har doim ota-onasining qiymatidan kichikroq bo'lgan Max Heap funktsiyasi
		static void buildMaxHeap(int[] arr, int n)
		{
			for (int i = 1; i < n; i++)
			{
				// Agar bola ota-onadan katta bo'lsa
				if (arr[i] > arr[(i - 1) / 2])
				{
					int j = i;

					// ota-ona kichikroq bo'lguncha bola va ota-onani almashtiring
					while (arr[j] > arr[(j - 1) / 2])
					{
						swap(arr, j, (j - 1) / 2);
						j = (j - 1) / 2;
					}
				}
			}
		}
		public static void heapSort(int[] arr, int n)
		{
			buildMaxHeap(arr, n);

			for (int i = n - 1; i > 0; i--)
			{

				// Birinchi indekslangan qiymatni oxirgi indekslangan bilan almashtirish
				swap(arr, 0, i);

				// Har bir almashtirishdan keyin yig'ish xususiyatini saqlash
				int j = 0, index;
				do
				{
					index = (2 * j + 1);

					// agar chap bola kichikroq bo'lsa
					// o'ng pastki nuqta indeks o'zgaruvchisi
					// o'ng bolaga
					if (index < (i - 1) && arr[index] < arr[index + 1])	index++;

					// agar ota-ona boladan kichik bo'lsa
					// keyin ota-onani bolaga almashtirish
					// yuqori qiymatga ega
					if (index < i && arr[j] < arr[index])	swap(arr, j, index);

					j = index;

				} while (index < i);
			}
		}

		public static void swap(int[] a, int i, int j)
		{
			int temp = a[i];
			a[i] = a[j];
			a[j] = temp;
		}

		// N-o‘lchamli massivni chop etish uchun yordamchi dastur
		public static void printArray(int[] arr)
		{
			int n = arr.Length;
			for (int i = 0; i < n; i++)
				Write(arr[i] + " ");
			WriteLine();
		}
	}
}

// This code is contributed by udev22