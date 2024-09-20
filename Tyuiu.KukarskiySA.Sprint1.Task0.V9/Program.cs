using Tyuiu.KukarskiySA.Sprint1.Task0.V9.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #9                                                           *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая вычисляет выражение (9/3)*4/3/2+1        *");
Console.WriteLine("* и печатает результат на экране.                                      *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* (9/3)*4/3/2+1                                                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

double result = dataService.Calculate();
Console.WriteLine(result);
Console.ReadKey();