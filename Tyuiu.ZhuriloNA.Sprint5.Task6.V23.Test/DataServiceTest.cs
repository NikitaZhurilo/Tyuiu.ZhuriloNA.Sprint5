using Tyuiu.ZhuriloNA.Sprint5.Task6.V23.Lib;
namespace Tyuiu.ZhuriloNA.Sprint5.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\azhur\AppData\Local\Temp\DataSprint5\InPutDataFileTask6V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        } 
    }
}