using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Sorting_Algorithms_CS
    {
        public static void Quicksort(List<int> arr, int p, int q)
        {
            if (q > p)
            {
                int pivot = partition(arr, p, q);
                Quicksort(arr, p, pivot - 1);
                Quicksort(arr, pivot + 1, q);
            }
        }


        static int partition(List<int> arr, int p, int q)
        {
            int pivot = q;
            int i = p - 1;
            for (int j = p; j < pivot; j++)
            {
                if (arr[j] < arr[pivot])
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            pivot = i + 1;
            int value = arr[q];
            arr.RemoveAt(q);
            arr.Insert(pivot, value);
            return pivot;
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 10, 5, 1, 4, 6, 18, 12, 56, 3, 0 };
            foreach (int num in arr)
            {
                Console.Write("{0} -> ", num);
            }
            Console.WriteLine();
            Quicksort(arr, 0, arr.Count -1);
            foreach (int num in arr)
            {
                Console.Write("{0} -> ", num);
            }
        }
    }
}
