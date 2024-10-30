﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OgorodnikDV.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((Math.Cos(Math.PI / x) / (3 * Math.Pow(Math.E, x + y))), 3);
            return res;
        }
    }
}
