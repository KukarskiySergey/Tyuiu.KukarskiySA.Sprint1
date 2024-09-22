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
        string text = "��� ���� ���"; // "���" - ��������� �����, ������� �����������

        // Act
        bool result = dataService.CheckLastWordRepetiton(text);

        // Assert
        Assert.IsTrue(result, $"���������, ��� ��������� ����� \"{text.Split(' ').Last()}\" ����������� � ������.");
    }

    [TestMethod]
    public void CheckLastWordRepetiton_ShouldReturnFalse_WhenLastWordDoesNotRepeat()
    {
        // Arrange
        DataService dataService = new DataService();
        string text = "��� �������� ������"; // "������" - ��������� �����, ������� �� �����������

        // Act
        bool result = dataService.CheckLastWordRepetiton(text);

        // Assert
        Assert.IsFalse(result, $"���������, ��� ��������� ����� \"{text.Split(' ').Last()}\" �� ����������� � ������.");
    }

    [TestMethod]
    public void CheckLastWordRepetiton_ShouldReturnFalse_WhenInputIsEmpty()
    {
        // Arrange
        DataService dataService = new DataService();
        string text = ""; // ������ ����

        // Act
        bool result = dataService.CheckLastWordRepetiton(text);

        // Assert
        Assert.IsFalse(result, "���������, ��� ��� ������� ����� ��������� ����� false.");
    }

    [TestMethod]
    public void CheckLastWordRepetiton_ShouldReturnFalse_WhenInputHasOneWord()
    {
        // Arrange
        DataService dataService = new DataService();
        string text = "����"; // ���� ������� �� ������ �����

        // Act
        bool result = dataService.CheckLastWordRepetiton(text);

        // Assert
        Assert.IsFalse(result, "���������, ��� ��� ����� � ����� ������ ����� ������ false.");
    }
}