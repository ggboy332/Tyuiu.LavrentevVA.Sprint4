using Tyuiu.LavrentevVA.Sprint4.Task7.V1.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint4.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
 

            int n = 3;
            int m = 3;
            string value = "135792468";
            Console.WriteLine("Исходные данные:");
            Console.WriteLine($"n = {n}, m = {m}, value = {value}");
            int result = ds.Calculate(n, m, value);
            Console.WriteLine("Количество четных чисел в матрице:");
            Console.WriteLine(result);


            Console.ReadKey();

        }
    }
}