using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class SelectionSort
    {
        public static void selectionSort(int [] arr)
        {
            int min;
            for(int i = 0; i < arr.Length-1; i++)
            {
                min = i;
                for(int j = i; j < arr.Length-1; j++)
                {
                    if( arr[j+1] < arr[min])
                    {
                        min = j + 1;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
