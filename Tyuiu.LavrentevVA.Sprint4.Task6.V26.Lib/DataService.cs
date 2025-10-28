using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.LavrentevVA.Sprint4.Task6.V26.Lib
{
    public class DataService : ISprint4Task6V26
    {
        public string[] Calculate(string[] array)
        {
            // Дан строковый массив данных ["Тюмень", "Тамбов", "Томск", "Омск", "Орёл"], используя класс Array, выведите элементы массива, длина которых больше 5 символов.
            //  Не надо упрощать код, пойдем через трудный путь

            List<string> resultList = new List<string>();
            foreach (var str in array)
            {
                if (str.Length > 5)
                {
                    resultList.Add(str);
                }
            }
            return resultList.ToArray();


        }
    }
}
