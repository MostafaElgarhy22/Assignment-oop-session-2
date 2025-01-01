using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct HiringDate2
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HiringDate2(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public int CompareTo(HiringDate other)
        {
            DateTime thisDate = new DateTime(Year, Month, Day);
            DateTime otherDate = new DateTime(other.Year, other.Month, other.Day);
            return thisDate.CompareTo(otherDate);
        }
    }
}
