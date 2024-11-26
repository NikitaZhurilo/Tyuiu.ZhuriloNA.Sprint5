using Tyuiu.ZhuriloNA.Sprint5.Task6.V23.Lib;
namespace Tyuiu.ZhuriloNA.Sprint5.Task6.V23
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
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #23                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле . Вычислить     *");
            Console.WriteLine("* значение по формуле (Полученное значение округлить до трёх знаков после     *");
            Console.WriteLine("* запятой) и вернуть полученный результат на консоль                          *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask6V23.txt");
            Console.WriteLine("Данные файла находятся в " + path);
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
