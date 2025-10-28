﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.LavrentevVA.Sprint4.Task5.V7.Lib
{
    public class DataService : ISprint4Task5V7
    {
        public int Calculate(int[,] matrix)
        {
            // Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными значениями в диапазоне от -7 до 7. Найти количество отрицательных элементов.
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            return count;

        }
    }
}
