using Tyuiu.LavrentevVA.Sprint4.Task0.V17.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint4.Task0.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            int[] numsArray = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            Console.WriteLine("Исходный массив");

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            int sumEven = ds.GetSumEvenArrEl(numsArray);

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }


            Console.WriteLine(sumEven);
            Console.ReadKey();

        }
    }
}

