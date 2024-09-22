using Tyuiu.KukarskiySA.Sprint1.Task3.V12.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #3                                                           *");
Console.WriteLine("* Вариант #12                                                          *");
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
Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника*");
Console.WriteLine("* по длинам двух катетов. Ответ округлите до 3 знаков после запятой.   *");
Console.WriteLine("************************************************************************");
Console.Write("Введите длину первого катета: ");
double lengthCathetus1 = double.Parse(Console.ReadLine());
Console.Write("Введите длину второго катета: ");
double lengthCathetus2 = double.Parse(Console.ReadLine());
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine($"Площадь прямоугольного треугольника: " +
    $"{dataService.TriangleArea(lengthCathetus1, lengthCathetus2)}");