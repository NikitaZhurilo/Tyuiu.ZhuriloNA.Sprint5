using Tyuiu.ZhuriloNA.Sprint5.Task0.V30.Lib;
namespace Tyuiu.ZhuriloNA.Sprint5.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\azhur\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path); 
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}