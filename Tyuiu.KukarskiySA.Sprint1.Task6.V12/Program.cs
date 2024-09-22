
using Tyuiu.KukarskiySA.Sprint1.Task6.V12.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #18                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу: пользователь вводит текст.                       *");
Console.WriteLine("* Проверить, что последнее слово строки входит в нее еще раз.          *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");

Console.Write("Введите текст: ");
string userString = Console.ReadLine();

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine($"Слово встречается в тексте ещё раз - " +
    $"{dataService.CheckLastWordRepetiton(userString)}");