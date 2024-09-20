using Tyuiu.KukarskiySA.Sprint1.Task1.V11.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetAnswerValid()
        {
            int numberOne = 5;
            int numberTwo = 6;
            var answer = DataService.ResultCalculation(5,6);

            Assert.AreEqual(answer, numberOne, numberTwo);
        }
    }
}