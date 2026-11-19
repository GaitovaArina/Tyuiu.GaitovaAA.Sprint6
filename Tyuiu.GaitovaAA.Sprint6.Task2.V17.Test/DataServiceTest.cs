using Tyuiu.GaitovaAA.Sprint6.Task2.V17.Lib;

namespace Tyuiu.GaitovaAA.Sprint6.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] valueWaitArray = { 4.67, 0.43, -8.26, -9.87, -3.98, 1.00, 0.02, -1.87, 3.74, 16.43, 24.67 };

            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
