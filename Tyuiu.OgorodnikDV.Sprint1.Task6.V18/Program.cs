using Tyuiu.OgorodnikDV.Sprint1.Task6.V18.Lib;

namespace Tyuiu.OgorodnikDV.Sprint1.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Огородник Д. В. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Огородник Д. В. | ИСПб-24-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка    *");
            Console.WriteLine("* является символьным представлением натурального числа                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string x;
            Console.WriteLine("* Введите число:                                                           ");
            x = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат - " + ds.CheckNumber(x!));
            Console.ReadKey();
        }
    }
}
