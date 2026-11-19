using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GaitovaAA.Sprint6.Task0.V12.Lib
{
    public class DataService : ISprint6Task0V12
    {
        public double Calculate(int x)
        {
            double underRoot = 4 * Math.Pow(x, 2) - 3;
            double y = (Math.Pow(x, 2) + 1) / Math.Sqrt(underRoot);
            return Math.Round(y, 3);
        }
    }
}
