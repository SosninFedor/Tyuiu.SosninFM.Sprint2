
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SosninFM.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ( ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 4)) || ((x == 4) && (y >= 5) && (y <= 10)) || ((x >= 3) && (x <= 5) && (y == 11)) ||
                (x >= 6 && (x <= 12) && (y <= 11) && (y > 9)) || ((x >= 9) && (x <= 12) && (y <= 8) && (y >= 3)) || ((x <= 10) && (x >= 7) && (y == 12)) ||
                ((x == 8) && (y <= 8) && (y >= 5)) || ((x == 13) && (y <= 8) && (y >= 6)) || ((x == 7) && (y == 6)) )
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
