using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KukarskiySA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double result =  x - Math.Truncate(x);
            return (int)Math.Floor(result * 10);
        }
    }
}
