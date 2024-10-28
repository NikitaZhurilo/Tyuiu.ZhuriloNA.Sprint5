using Tyuiu.ZhuriloNA.Sprint5.Task0.V30.Lib;
namespace Tyuiu.ZhuriloNA.Sprint5.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\azhur\source\repos\Tyuiu.ZhuriloNA.Sprint5\Tyuiu.ZhuriloNA.Sprint5.Task0.V30\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path); 
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}