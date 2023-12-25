
using Tasks;


MyDate myStartDate = new MyDate(2023, 12, 11, 16, 0);
MyDate myFinishDate = new MyDate(2023, 12, 11, 16, 30);

Airplane myAirplane = new Airplane("Місто1", "Місто2", myStartDate, myFinishDate);
Console.WriteLine(myAirplane.GetTotalTime());
Console.WriteLine(myAirplane.IsArrivingToday());