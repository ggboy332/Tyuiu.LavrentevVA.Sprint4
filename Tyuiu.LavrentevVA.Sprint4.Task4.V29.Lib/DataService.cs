using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.LavrentevVA.Sprint4.Task4.V29.Lib
{
    public class DataService : ISprint4Task4V29
    {
        public int Calculate(int[,] matrix)
        {
            //Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры в диапазоне от 4 до 8. Найдите сумму четных элементов массива. 5, 6, 5, 6, 5, ; 5, 5, 5, 8, 4, ; 8, 5, 5, 8, 8, ; 6, 5, 4, 4, 8, ; 8, 5, 6, 8, 8,

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;

        }
    }
}
