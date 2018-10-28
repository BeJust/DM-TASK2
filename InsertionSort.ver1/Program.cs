using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace InsertionSort.ver1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка вставками");
            Console.WriteLine("Введите массив для сортировки, разделяя элементы пробелом: ");
            string[] strelems = Console.ReadLine().Split(' ');
            int[] arrToSort = new int[strelems.Length];
            for (int i = 0; i < strelems.Length; i++)
            {
                arrToSort[i] = int.Parse(strelems[i]);
            }
            int n = 0;
            arrToSort = InsertionSortAnalyser.InsertionSort(arrToSort, out n);
            InsertionSortAnalyser.OutputArrToConsole(arrToSort);
            Console.WriteLine("Количество операций: {0}", n);
        }
    }
}
