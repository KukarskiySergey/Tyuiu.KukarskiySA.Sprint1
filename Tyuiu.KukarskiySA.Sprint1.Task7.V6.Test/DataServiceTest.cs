using Tyuiu.KukarskiySA.Sprint1.Task7.V6.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService _dataService;

        [TestInitialize]
        public void Setup()
        {
            _dataService = new DataService();
        }

        [TestMethod]
        public void Calculate_ShouldReturnExpectedResult_WhenGivenValidInputs()
        {
            // Arrange
            double x = 2.0;
            double y = 1.0;
            double expected = (1 + (1 / (x * x))) * (1 + 1 / (x * x)) - 12 * (x * x) * y;
            expected = Math.Round(expected, 3); // Округляем ожидаемое значение

            // Act
            double result = _dataService.Calculate(x, y);

            // Assert
            Assert.AreEqual(expected, result, 0.001, "Результат вычисления не соответствует ожидаемому значению.");
        }

        [TestMethod]
        public void Calculate_ShouldThrowException_WhenXIsZero()
        {
            // Arrange
            DataService dataService = new DataService();
            double x = 0.0;
            double y = 0.0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => dataService.Calculate(x, y), "Значение x не может быть равно нулю.");
        }

        [TestMethod]
        public void Calculate_ShouldHandleNegativeValues()
        {
            // Arrange
            double x = -1.0;
            double y = -1.0;
            double expected = (1 + (1 / (x * x))) * (1 + 1 / (x * x)) - 12 * (x * x) * y;
            expected = Math.Round(expected, 3); // Округляем ожидаемое значение

            // Act
            double result = _dataService.Calculate(x, y);

            // Assert
            Assert.AreEqual(expected, result, 0.001, "Результат для отрицательных входных данных не соответствует ожидаемому значению.");
        }
    }
}