﻿using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZhuriloNA.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = (x * x + 1) / (3 * x + 4);
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
