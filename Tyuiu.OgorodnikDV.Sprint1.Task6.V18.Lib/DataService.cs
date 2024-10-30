using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OgorodnikDV.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            try
            {
                int res = Convert.ToInt32(value);
                if (res != null)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
