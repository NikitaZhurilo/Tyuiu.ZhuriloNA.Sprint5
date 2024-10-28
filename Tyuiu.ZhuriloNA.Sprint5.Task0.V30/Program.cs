using Tyuiu.ZhuriloNA.Sprint5.Task0.V30.Lib;
namespace Tyuiu.ZhuriloNA.Sprint5.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил Журило Н. А. | ИБКСб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #30                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить        *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до     *");
            Console.WriteLine("* трёх знаков после запятой                                                   *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
