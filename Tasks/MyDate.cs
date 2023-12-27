using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class MyDate
    {
        protected int year;
        protected int month;
        protected int day;
        protected int hours;
        protected int minutes;

        public int Year
        {
            get { return year; }
            protected set { year = value; }
        }
        public int Month
        {
            get { return month; }
            protected set { month = value; }
        }
        public int Day
        {
            get { return day; }
            protected set { day = value; }
        }
        public int Hours
        {
            get { return hours; }
            protected set { hours = value; }
        }
        public int Minutes
        {
            get { return minutes; }
            protected set { minutes = value; }
        }

        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public MyDate()
        {
            Year = 1;
            Month = 1;
            Day = 1;
            Hours = 1;
            Minutes = 0;
        }
        public MyDate(DateTime dateTime)
        {
            Year = dateTime.Year;
            Month = dateTime.Month;
            Day = dateTime.Day;
            Hours = dateTime.Hour;
            Minutes = dateTime.Minute;
        }
        public MyDate(MyDate myDate)
        {
            Year = myDate.Year;
            Month = myDate.Month;
            Day = myDate.Day;
            Hours = myDate.Hours;
            Minutes = myDate.Minutes;
        }
    }
}