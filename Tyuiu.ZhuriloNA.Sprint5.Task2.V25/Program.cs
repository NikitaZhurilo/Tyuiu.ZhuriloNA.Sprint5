using Tyuiu.ZhuriloNA.Sprint5.Task2.V25.Lib;
namespace Tyuiu.ZhuriloNA.Sprint5.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил Журило Н. А. | ИБКСб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #25                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями *");
            Console.WriteLine("* с клавиатуры. Заменить нечетные элементы массива на 0. Результат сохранить  *");
            Console.WriteLine("* в файл OutPutFileTask2.csv и вывести на консоль                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int[,] matrix = { 
                { 4, 8, 5 }, 
                { 1, 4, 2 }, 
                { 4, 9, 9 } 
            };
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
