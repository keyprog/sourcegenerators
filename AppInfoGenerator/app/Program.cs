using MyApp;

Console.WriteLine(AppInfo.InfoLine);

Order order = new () {OrderID = "XYZ1", SecurityID = "XYZ", Price = 100m, Quantity = 1 };
Console.WriteLine(order);

