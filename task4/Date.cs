using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    enum Month : int
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12,
    }
    class Date
    {
        private int day, year;
        public Month Month;
        public int Day { get => day; set => day = value; }
        public int Year { get => year; set => year = value; }

        public Date()
        {
            this.day = DateTime.Now.Day;
            this.Month = (Month)DateTime.Now.Month;
            this.year = DateTime.Now.Year;
        }
        public Date(int day, int year, int month)
        {
            this.day = day;
            this.year = year;
            this.Month = (Month)month;
        }
        public override string ToString()
            => $"{nameof(Date)}: year = {this.year}, month = {this.Month}, day = {this.day}.";

        public static double operator -(Date x, Date y)
        {
            DateTime a = new DateTime(x.year, (int)x.Month, x.day);
            DateTime b = new DateTime(y.year, (int)y.Month, y.day);
            TimeSpan timeSpan = a - b;
            return timeSpan.TotalDays;
        }

        public static Date operator +(Date date, int x)
        {
            if (x >= 365)
            {
                date.year += x / 365;
                x %= 365;
            }
            if (x >= 30)
            {
                date.Month += x / 30;
                x %= 30;
            }
            date.day += x;

            return date;
        }
    }
}
