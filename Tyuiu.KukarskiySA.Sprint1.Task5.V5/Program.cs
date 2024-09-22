using Tyuiu.KukarskiySA.Sprint1.Task5.V5.Lib;

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
Console.WriteLine("* Написать программу, которая решает следующую задачу:                 *");
Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части           *");
Console.WriteLine("* положительного вещественного числа x                                 *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* (так, если x=32.597, то d=5).                                        *"); Console.WriteLine("* по длинам двух катетов. Ответ округлите до 3 знаков после запятой.   *");
Console.WriteLine("************************************************************************");
Console.Write("Введите число: ");
double number = double.Parse(Console.ReadLine());
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine($"Первая цифра из дробной части положительного вещественного числа = " +
    $"{dataService.Calculate(number)}");