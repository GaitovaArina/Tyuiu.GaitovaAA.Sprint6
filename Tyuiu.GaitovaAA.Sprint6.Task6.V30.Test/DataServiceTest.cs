using System.IO;
using Tyuiu.GaitovaAA.Sprint6.Task6.V30.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask6V30.txt");
            string testData =
                "один два три четвертое пять\n" +
                "первое второе третье слово4 пятое\n" +
                "короткая строка\n" +
                "раз два три финальное";

            File.WriteAllText(path, testData);

            string str = "";
            string res = ds.CollectTextFromFile(str, path);
            string wait = "четвертое слово4 финальное";

            Assert.AreEqual(wait, res);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
