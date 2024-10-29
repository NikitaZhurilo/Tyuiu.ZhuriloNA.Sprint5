using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZhuriloNA.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Cos(Convert.ToDouble(strX)) + Math.Pow(Convert.ToDouble(strX), 2) - (2 * Convert.ToDouble(strX)) / 1.2;
            res = Math.Round(res, 3);
            return res;
        }
    }
}
