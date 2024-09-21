using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KukarskiySA.Sprint1.Task1.V11.Lib
{
    public class DataService : ISprint1Task1V11
    {
        public double Calculate(double x, double y)
        {
            double result = 5 * x / (6 * y);
            return result;
        }
    }
}
