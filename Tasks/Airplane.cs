using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Airplane
    {
        protected string StartCity { get; set; }
        protected string FinishCity { get; set; }
        protected MyDate StartDate { get; set; }
        protected MyDate FinishDate { get; set; }

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
        public Airplane()
        {
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
            FinishDate = airplane.FinishDate;
        }
        public Airplane(string startCity, string finishCity, DateTime startDate, DateTime finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new MyDate(startDate);
            FinishDate = new MyDate(finishDate);
        }
    }
}
