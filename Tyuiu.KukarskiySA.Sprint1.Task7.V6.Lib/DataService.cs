using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KukarskiySA.Sprint1.Task7.V6.Lib
{
    public class DataService : ISprint1Task7V6
    {
        public double Calculate(double x, double y)
        {
            // Проверка на нулевое значение для x
            if (x == 0)
            {
                throw new ArgumentException("Значение x не может быть равно нулю.");
            }

            double result = (1 + (1 / (x * x))) * (1 + 1 / (x * x)) - 12 * (x * x) * y;
            return Math.Round(result, 3);
        }
    }
}
