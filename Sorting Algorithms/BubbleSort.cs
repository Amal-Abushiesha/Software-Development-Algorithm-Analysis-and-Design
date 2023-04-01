using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort
    {
        public static void bubbleSort(int [] arr)
        {
            bool sorted = true;
            int n = arr.Length;
            for(int i = 0; i < n-1; i++)
            {
                 for(int j = 0; j < n-i-1; j++)
                {
                    if(arr[j+1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        sorted = false;
                    }
                }
                 if(sorted)
                {
                    break;
                }
            }
        }
    }
}
