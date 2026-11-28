using System.IO;
using Tyuiu.GaitovaAA.Sprint6.Task7.V13.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask7V13.csv");
            string testCsv =
                "1;2;3;4;5;4\n" +
                "1;2;3;4;5;-2\n" +
                "1;2;3;4;5;7\n" +
                "1;2;3;4;5;0";

            File.WriteAllText(path, testCsv);

            int[,] res = ds.GetMatrix(path);
            int[,] wait =
            {
                { 1, 2, 3, 4, 5, 111 },
                { 1, 2, 3, 4, 5, -2 },
                { 1, 2, 3, 4, 5, 7 },
                { 1, 2, 3, 4, 5, 0 }
            };

            CollectionAssert.AreEqual(wait, res);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
