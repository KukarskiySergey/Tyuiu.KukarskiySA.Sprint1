using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KukarskiySA.Sprint1.Task3.V12.Lib
{
    public class DataService : ISprint1Task3V12
    {
        public double TriangleArea(double lengthCathetus1, double lengthCathetus2)
        {
            double s = 0.5 * lengthCathetus1 * lengthCathetus2;
            return Math.Round(s,3);
        }
    }
}
