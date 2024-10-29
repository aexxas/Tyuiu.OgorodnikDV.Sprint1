using Tyuiu.OgorodnikDV.Sprint1.Task3.V3.Lib;

namespace Tyuiu.OgorodnikDV.Sprint1.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Огородник Д. В. | ИСПб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Огородник Д. В. | ИСПб-24-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 9;
            double y = 7.5;
            double z = 5;
            Console.WriteLine("Длина параллелепипеда X = " + x);
            Console.WriteLine("Ширина параллелепипеда Y = " + y);
            Console.WriteLine("Высота параллелепипеда Z = " + z);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Объем параллелепипеда = " + ds.ParallelepipedVolume(x, y, z));
            Console.ReadKey();
        }
    }
}
