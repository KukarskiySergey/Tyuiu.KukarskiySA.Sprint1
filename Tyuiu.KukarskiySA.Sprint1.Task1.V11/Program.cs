using Tyuiu.KukarskiySA.Sprint1.Task1.V11.Lib;

Console.Title = "Спринт #1 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #11                                                           *");
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



Console.Write("Введите 1-е число: ");
int numberOne = int.Parse(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int numberTwo = int.Parse(Console.ReadLine());





int result = DataService.ResultCalculation(numberOne, numberTwo);
Console.WriteLine("Результат: " + result);



Console.ReadLine();