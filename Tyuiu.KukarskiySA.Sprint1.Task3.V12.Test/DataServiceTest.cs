using Tyuiu.KukarskiySA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetAnswerValid()
        {
            DataService dataService = new DataService();
            double lengthCathetus1 = 2;
            double lengthCathetus2 = 4;
            double result = dataService.TriangleArea(lengthCathetus1, lengthCathetus2);

            Assert.AreEqual(4, result);
        }
    }
}