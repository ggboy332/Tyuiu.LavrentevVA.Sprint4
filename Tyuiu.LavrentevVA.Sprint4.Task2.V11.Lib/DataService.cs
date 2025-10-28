using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.LavrentevVA.Sprint4.Task2.V11.Lib
{
    public class DataService : ISprint4Task2V11
    {
        public int Calculate(int[] array)
        {
            // Дан одномерный целочисленный массив на 15 элементов заполненный случайными в диапазоне от 3 до 8 подсчитать сумму четных элементов массива.
            int sumArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;

        }
    }
}
