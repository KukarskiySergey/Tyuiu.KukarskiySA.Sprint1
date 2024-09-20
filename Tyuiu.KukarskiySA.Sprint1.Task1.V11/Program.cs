using Tyuiu.KukarskiySA.Sprint1.Task1.V11.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #11                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя               *");
Console.WriteLine("* исходные данные, вычисляет результат по формуле 5*x/(6*y)            *");
Console.WriteLine("* и печатает его на экране.                                            *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* 5*x/(6*y)                                                            *");
Console.WriteLine("************************************************************************");

Console.Write("Введите 1-е число: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введите 2-е число: ");
double y = double.Parse(Console.ReadLine());

Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(dataService.Calculate(x,y));
Console.ReadLine();