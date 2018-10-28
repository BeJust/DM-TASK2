using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public static class InsertionSortAnalyser
    {     
        public static int[]  BinaryInsertionSort(int[] array, out int n)
        {
            n = 0;
            for (int i = 1; i < array.Length; i++)
            {
                int low = 0;
                int high = i - 1;
                int temp = array[i];
                //Find
                while (low <= high)
                {
                    n++;
                    int mid = (low + high) / 2;
                    if (temp < array[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                //backward shift
                for (int j = i - 1; j >= low; j--)
                {
                    array[j + 1] = array[j];
                }

                array[low] = temp;
            }
            return array;
        }

        public static int[] InsertionSort(int[] arraySort, out int n)
        {
            n = 0;
            int[] result = new int[arraySort.Length];
            for (int i = 0; i < arraySort.Length; i++)
            {

                int j = i;
                while (j > 0 && result[j - 1] > arraySort[i])
                {
                    n++;
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = arraySort[i];
            }
            return result;
        }
        
        public static void OutputArrToConsole(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }

   
}
