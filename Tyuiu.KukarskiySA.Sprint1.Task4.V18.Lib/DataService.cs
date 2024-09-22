using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KukarskiySA.Sprint1.Task4.V18.Lib
{
    public class DataService : ISprint1Task4V18
    {
        public double Calculate(double x, double y)
        {
            double result = Math.Sqrt(3 + x) / ((x * y) * (x * y));
            return (Math.Round(result,3));
        }
    }
}
