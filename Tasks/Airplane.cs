using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Airplane
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public MyDate StartDate { get; set; }
        public MyDate FinishDate { get; set; }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public int GetTotalTime()
        {
            DateTime startDateTime = new DateTime(StartDate.Year, StartDate.Month, 
                StartDate.Day, StartDate.Hours, StartDate.Minutes, 0);
            DateTime finishDateTime = new DateTime(FinishDate.Year, FinishDate.Month, 
                FinishDate.Day, FinishDate.Hours, FinishDate.Minutes, 0);
            TimeSpan getTotalTime = finishDateTime - startDateTime;

            return (int)getTotalTime.TotalMinutes;
        }
        public bool IsArrivingToday()
        {
            bool isArrivingToday = false;

            if(StartDate.Day == FinishDate.Day)
                isArrivingToday = true;

            return isArrivingToday;
        }
    }
}
