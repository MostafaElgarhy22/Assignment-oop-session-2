using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class HiringDate
    {
        public HiringDate() 
        {
             private int year;
             private int month;
             private int day;


        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Month
        {
            get => month; set => month = value;
        }
        public int Day
        {
            get => day; set => day = value;
        }

        #region Constructor

        public HiringDate(int year , int Month , int Day)
        {
            year = Year;
            Month = month;
            Day = day;
        }

        public override string ToString()
        {
            return $"Year = {Year} , Month = {Month} , Day = {Day}";
        }
        #endregion





    }
}
