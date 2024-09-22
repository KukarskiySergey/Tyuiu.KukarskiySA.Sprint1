using Tyuiu.KukarskiySA.Sprint1.Task4.V18.Lib;

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
Console.WriteLine("* Написать программу, которая запрашивает у пользователя               *");
Console.WriteLine("* исходные данные, вычисляет результат по формуле                      *");
Console.WriteLine("* и печатает его на экране. Ответ округлите до 3 знаков после запятой. *");Console.WriteLine("* печатает результат на экране.                                        *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* Корень 3+x/(xy)^2                                                    *");Console.WriteLine("* по длинам двух катетов. Ответ округлите до 3 знаков после запятой.   *");
Console.WriteLine("************************************************************************");
Console.Write("Введите первое число: ");
double number1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = double.Parse(Console.ReadLine());
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine($"Площадь прямоугольного треугольника: " +
    $"{dataService.Calculate(number1, number2)}");