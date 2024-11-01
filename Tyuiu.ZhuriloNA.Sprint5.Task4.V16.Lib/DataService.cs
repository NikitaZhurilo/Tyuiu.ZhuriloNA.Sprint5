using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhuriloNA.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
{
    public double LoadFromDataFile(string path)
    {
        // Проверка на существование файла
        if (!File.Exists(path))
            throw new FileNotFoundException("Data file not found at the specified path.");

        string data = File.ReadAllText(path);
        if (!double.TryParse(data, out double x))
            throw new FormatException("The data in the file is not a valid double value.");

        double y = Math.Cos(x) + Math.Pow(x, 2) - 2 * x / 1.2;

        return Math.Round(y, 3);
    }
}
}