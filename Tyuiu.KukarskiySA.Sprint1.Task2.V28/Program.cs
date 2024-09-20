using Tyuiu.KukarskiySA.Sprint1.Task2.V28.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Арифметические операторы в C#.                                 *");
Console.WriteLine("* Задание #2                                                           *");
Console.WriteLine("* Вариант #28                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя               *");
Console.WriteLine("* исходные данные, выполняет указанные расчёты и                       *");
Console.WriteLine("* печатает результат на экране.                                        *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

int celsius = int.Parse(Console.ReadLine());
Console.WriteLine($"{celsius} градусов Цельсия.");

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine(dataService.Calculate(celsius) + "градусов Кельвина");