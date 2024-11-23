
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZhuriloNA.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {

        public double LoadFromDataFile(string path)
        {
            string n = File.ReadAllText(path);
            double x = double.Parse(n.Replace('.', ','));
            double result = Math.Cos(x) + Math.Pow(x, 2) - 2 * x / 1.2;
            return Math.Round(result, 3);
        }
    }
}
