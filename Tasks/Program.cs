
using Tasks;


MyDate myStartDate = new MyDate(2023, 12, 11, 16, 0);
MyDate myFinishDate = new MyDate(2023, 12, 11, 18, 30);

Airplane myAirplane = new Airplane("Місто1", "Місто2", myStartDate, myFinishDate);
Console.WriteLine(myAirplane.GetTotalTime());
Console.WriteLine(myAirplane.IsArrivingToday());
var currency = new Currency("USD", 37);
var product = new Product("Телевізор", 100, currency, 5, "Samsung", 10);

Console.WriteLine(product.GetPriceInUAH());
Console.WriteLine(product.GetTotalPriceInUAH());
Console.WriteLine(product.GetTotalWeight());
