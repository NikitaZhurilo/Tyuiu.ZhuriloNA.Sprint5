using Tyuiu.ZhuriloNA.Sprint5.Task5.V5.Lib;
namespace Tyuiu.ZhuriloNA.Sprint5.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\azhur\AppData\Local\Temp\DataSprint5\InPutDataFileTask5V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}