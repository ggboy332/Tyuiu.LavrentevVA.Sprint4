using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.LavrentevVA.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            // Дана строка из одноразрядных цифр "135792468". Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел.
            if (value.Length != n * m)
            {
                throw new ArgumentException("Длина строки не соответствует размеру матрицы.");
            }
            int[,] matrix = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;

        }
    }
}
