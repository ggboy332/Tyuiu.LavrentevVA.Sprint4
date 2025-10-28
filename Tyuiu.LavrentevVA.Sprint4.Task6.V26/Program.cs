using Tyuiu.LavrentevVA.Sprint4.Task6.V26.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint4.Task6.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string[] strArray = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
            Console.WriteLine("Исходный массив:");
            foreach (var str in strArray)
            {
                Console.WriteLine(str);
            }
            string[] result = ds.Calculate(strArray);
            Console.WriteLine("число элементов массива, длина которых больше 5 символов:");
            Console.WriteLine(result.Length);


            Console.ReadKey();

        }
    }
}