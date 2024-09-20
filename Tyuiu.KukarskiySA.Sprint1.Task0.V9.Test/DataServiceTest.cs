using Tyuiu.KukarskiySA.Sprint1.Task0.V9.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetAnswerValid()
        {
            int result = 3;
            var answer = DataService.GetResult(9, 3, 4, 3, 2);

            Assert.AreEqual(result, answer);
        }
    }
}