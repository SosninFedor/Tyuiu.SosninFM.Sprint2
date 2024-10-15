
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SosninFM.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            {
                if (m == 31)
                {
                    n += 1;
                    m -= 30;
                }
                else if (m < 31)
                {
                    if ((n == 2) && (m == 28))
                    {
                        n += 1;
                        m -= 27;
                    }
                    else if ((n == 4) && (m == 30))
                    {
                        n += 1;
                        m -= 29;
                    }
                    else if ((n == 6) && (m == 30))
                    {
                        n += 1;
                        m -= 29;
                    }
                    else if ((n == 9) && (m == 30))
                    {
                        n += 1;
                        m -= 29;
                    }
                    else if ((n == 11) && (m == 30))
                    {
                        n += 1;
                        m -= 29;
                    }
                    else
                    {
                        m += 1;
                    }

                }
                string res;
                switch (n)
                {
                    case 1:
                        res = "01";
                        break;
                    case 2:
                        res = "02";
                        break;
                    case 3:
                        res = "03";
                        break;
                    case 4:
                        res = "04";
                        break;
                    case 5:
                        res = "05";
                        break;
                    case 6:
                        res = "06";
                        break;
                    case 7:
                        res = "07";
                        break;
                    case 8:
                        res = "08";
                        break;
                    case 9:
                        res = "09";
                        break;
                    case 10:
                        res = "10";
                        break;
                    case 11:
                        res = "11";
                        break;
                    case 12:
                        res = "12";
                        break;
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");
                }
                string res2;
                res2 = m + "." + res;
                return res2;

            }

        }
    }
}
