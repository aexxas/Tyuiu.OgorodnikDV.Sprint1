using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Tyuiu.OgorodnikDV.Sprint1.Task2.V13.Lib
{
    public class DataService : ISprint1Task2V13
    {
        public double ConvertMilesToKm(int value)
        {
            double y = value * 1.6093;
            double roundedNumber = Math.Round(y, 3);
            return roundedNumber;
        }
    }
}
