using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public struct HireDate
    {
        int day, month, year;

        public HireDate(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public int Day
        {
            get { return day; }
        }

        public int Month
        {
            get {return month; }
        }

        public int Year
        {
            get { return Year; }
        }

    }
}
