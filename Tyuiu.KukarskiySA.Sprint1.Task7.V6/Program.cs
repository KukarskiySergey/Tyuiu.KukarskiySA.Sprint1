using Tyuiu.KukarskiySA.Sprint1.Task7.V6.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #6                                                           *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по    *");
Console.WriteLine("* исходным значениям данных, вводимых пользователем.                   *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                           *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");


Console.Write("Введите 1-е число: ");
double number1 = double.Parse(Console.ReadLine());

Console.Write("Введите 2-е число: ");
double number2 = double.Parse(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine($"Результат вычисления = {dataService.Calculate(number1,number2)}");