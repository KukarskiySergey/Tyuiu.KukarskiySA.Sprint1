using Tyuiu.KukarskiySA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.KukarskiySA.Sprint1.Task6.V12.Test;

[TestClass]
public class DataServiceTests
{
    [TestMethod]
    public void CheckLastWordRepetiton_ShouldReturnTrue_WhenLastWordRepeats()
    {
        // Arrange
        DataService dataService = new DataService();
        string text = "сам себе сам"; // "сам" - последнее слово, которое повторяется

        // Act
        bool result = dataService.CheckLastWordRepetiton(text);

        // Assert
        Assert.IsTrue(result, $"Ожидалось, что последнее слово \"{text.Split(' ').Last()}\" повторяется в тексте.");
    }

    [TestMethod]
    public void CheckLastWordRepetiton_ShouldReturnFalse_WhenLastWordDoesNotRepeat()
    {
        // Arrange
        DataService dataService = new DataService();
        string text = "Это тестовая строка"; // "строка" - последнее слово, которое не повторяется

        // Act
        bool result = dataService.CheckLastWordRepetiton(text);

        // Assert
        Assert.IsFalse(result, $"Ожидалось, что последнее слово \"{text.Split(' ').Last()}\" не повторяется в тексте.");
    }

    [TestMethod]
    public void CheckLastWordRepetiton_ShouldReturnFalse_WhenInputIsEmpty()
    {
        // Arrange
        DataService dataService = new DataService();
        string text = ""; // Пустой ввод

        // Act
        bool result = dataService.CheckLastWordRepetiton(text);

        // Assert
        Assert.IsFalse(result, "Ожидалось, что для пустого ввода результат будет false.");
    }

    [TestMethod]
    public void CheckLastWordRepetiton_ShouldReturnFalse_WhenInputHasOneWord()
    {
        // Arrange
        DataService dataService = new DataService();
        string text = "Тест"; // Ввод состоит из одного слова

        // Act
        bool result = dataService.CheckLastWordRepetiton(text);

        // Assert
        Assert.IsFalse(result, "Ожидалось, что для ввода с одним словом метод вернет false.");
    }
}