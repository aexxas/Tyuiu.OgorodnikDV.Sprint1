using Tyuiu.OgorodnikDV.Sprint1.Task1.V29.Lib;

namespace Tyuiu.OgorodnikDV.Sprint1.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Огородник Д. В. | ИСПб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Огородник Д. В. | ИСПб-24-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле a*b*c/(a+b+c) и печатает его на экран.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            double a, b, c;

            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение B:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение C:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a,b,c));
            Console.ReadLine();

        }
    }
}
