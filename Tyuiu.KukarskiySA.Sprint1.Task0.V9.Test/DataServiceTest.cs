using Tyuiu.KukarskiySA.Sprint1.Task0.V9.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetAnswerValid()
        {
            DataService dataService = new DataService();
            var result = dataService.Calculate();

            Assert.AreEqual(3, result);
        }
    }
}