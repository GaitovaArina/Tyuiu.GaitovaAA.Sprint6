using System.IO;
using Tyuiu.GaitovaAA.Sprint6.Task5.V22.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask5V22.txt");
            string testData = "-2\n5\n6.1234\n0\n12.5\n3.45\n5.001\n-10\n8.9999\n1\n2\n3\n4\n5\n6\n7\n8\n9\n10\n-5";
            File.WriteAllText(path, testData);

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 6.123, 12.5, 5.001, 9.0, 6, 7, 8, 9, 10 };

            CollectionAssert.AreEqual(wait, res);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
