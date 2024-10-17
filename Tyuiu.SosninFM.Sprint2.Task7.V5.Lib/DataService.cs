
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SosninFM.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            bool a = (y >= (Math.Exp(-x)) && (y <= (Math.Pow(x, 2))));
            bool b = (y >= (Math.Pow(x, 2)) && (y <= (Math.Exp(x))));

            if (a && b)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
