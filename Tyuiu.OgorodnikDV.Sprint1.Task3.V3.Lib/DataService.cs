using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OgorodnikDV.Sprint1.Task3.V3.Lib
{
    public class DataService : ISprint1Task3V3
    {
        public double ParallelepipedVolume(double length, double width, double height)
        {
            double y =  length * width * height;
            double roundedNumber = Math.Round(y, 3);
            return roundedNumber;
        }
    }
}
