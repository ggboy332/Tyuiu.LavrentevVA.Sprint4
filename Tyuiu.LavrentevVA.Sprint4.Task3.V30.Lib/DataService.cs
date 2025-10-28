using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.LavrentevVA.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            // Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 1 до 6. Найдите максимальный элемент в третьей строке массива. 2, 4, 3, 5, 1, ; 6, 6, 1, 2, 6, ; 3, 3, 2, 1, 5, ; 6, 4, 1, 3, 3, ; 5, 1, 1, 6, 4
            int maxElement = array[2, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[2, j] > maxElement)
                {
                    maxElement = array[2, j];
                }
            }
            return maxElement;

        }
    }
}
