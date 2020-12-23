using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public struct HireDate
    {
        int day, month, year;

        public HireDate(int d,int m,int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public int getDay()
        {
            return day;
        }

        public int getMonth()
        {
            return month;
        }

        public int getyear()
        {
            return year;
        }

    }
}
