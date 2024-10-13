
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SosninFM.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            {
                if (n == 31)
                {
                    m += 1;
                    n -= 30;
                }
                else if (n < 31)
                {
                    if ((m == 2) && (n == 28))
                    {
                        m += 1;
                        n -= 27;
                    }
                    else if ((m == 4) && (n == 30))
                    {
                        m += 1;
                        n -= 29;
                    }
                    else if ((m == 6) && (n == 30))
                    {
                        m += 1;
                        n -= 29;
                    }
                    else if ((m == 9) && (n == 30))
                    {
                        m += 1;
                        n -= 29;
                    }
                    else if ((m == 11) && (n == 30))
                    {
                        m += 1;
                        n -= 29;
                    }
                    else
                    {
                        n += 1;
                    }

                }
                string res;
                switch (m)
                {
                    case 1:
                        res = "Января";
                        break;
                    case 2:
                        res = "Февраля";
                        break;
                    case 3:
                        res = "Марта";
                        break;
                    case 4:
                        res = "Апреля";
                        break;
                    case 5:
                        res = "Мая";
                        break;
                    case 6:
                        res = "Июня";
                        break;
                    case 7:
                        res = "Июля";
                        break;
                    case 8:
                        res = "Августа";
                        break;
                    case 9:
                        res = "Сентября";
                        break;
                    case 10:
                        res = "Октября";
                        break;
                    case 11:
                        res = "Ноября";
                        break;
                    case 12:
                        res = "Декабря";
                        break;
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
                string res2;
                res2 = n + " " + res;
                return res2;

            }

        }
    }
}
