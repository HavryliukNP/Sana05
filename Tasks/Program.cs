
using Tasks;


MyDate myStartDate = new MyDate(2023, 12, 11, 16, 0);
MyDate myFinishDate = new MyDate(2023, 12, 11, 18, 30);

Airplane myAirplane = new Airplane("Місто1", "Місто2", myStartDate, myFinishDate);
Console.WriteLine($"Час польоту: {myAirplane.GetTotalTime()} хвилин");
Console.WriteLine($"Виліт та посадка в один день: {myAirplane.IsArrivingToday()}");
var currency = new Currency("USD", 37);
var product = new Product("Телевізор", 100, currency, 5, "Samsung", 10);

Console.WriteLine($"Ціна товару в гривнях: {product.GetPriceInUAH()}");
Console.WriteLine($"Загальна ціна товару в гривнях: {product.GetTotalPriceInUAH()}");
Console.WriteLine($"Загальна вага усіх товарів: {product.GetTotalWeight()}");
