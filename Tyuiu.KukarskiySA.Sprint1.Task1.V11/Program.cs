using Tyuiu.KukarskiySA.Sprint1.Task1.V11.Lib;

Console.Write("Введите 1-е число: ");
int numberOne = int.Parse(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int numberTwo = int.Parse(Console.ReadLine());

int result = DataService.ResultCalculation(numberOne, numberTwo);
Console.WriteLine(result);



Console.ReadLine();