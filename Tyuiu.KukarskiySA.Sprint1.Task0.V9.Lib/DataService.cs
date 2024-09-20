namespace Tyuiu.KukarskiySA.Sprint1.Task0.V9.Lib
{
    public class DataService
    {
        public static int GetResult(int a, int b, int c, int d, int e)
        {
            int result = (a / b) * c / b / d + e;
            return result;
        }
    }
}
