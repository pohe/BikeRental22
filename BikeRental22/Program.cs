// See https://aka.ms/new-console-template for more information

using BikeRental22;

BikeCatalog bikeCatalog = new BikeCatalog();

Bike bike1 = new Bike("Model1", 2022, "Blue", 1);
Bike bike2 = new Bike("Model2", 2010, "Red", 2);
Bike bike3 = new Bike("Model3", 2020, "Green", 3);

// Test af AddBike
bikeCatalog.AddBike(bike1);
bikeCatalog.AddBike(bike2);
bikeCatalog.AddBike(bike3);

// Test af PrintBikeList
bikeCatalog.PrintBikeList();

// Test af SearchBike
Bike foundBike = bikeCatalog.SearchBike(2);
Console.WriteLine(foundBike);

// Test af ArgumentException
Bike bike4 = new Bike("Model2", 2010, "Red", 4);
Bike bike5 = new Bike("Model3", 2020, "Green", 4);

try
{
    bikeCatalog.AddBike(bike4);
    bikeCatalog.AddBike(bike5);
}
catch (ArgumentException e)
{
    Console.WriteLine($"Cannot add bike.\n{e.Message}");
}

// Test af inheritance
EBike eBike1 = new EBike("Model4", 2019, "Purple", 6, 700);
EBike eBike2 = new EBike("Model4", 2016, "Yellow", 7, 750);

bikeCatalog.AddBike(eBike1);
bikeCatalog.AddBike(eBike2);

bikeCatalog.PrintBikeList();

// Test af DeleteBike
bikeCatalog.DeleteBike(6);

bikeCatalog.PrintBikeList();

// Test af SearchBikesOfModel
List<Bike> model3List = new List<Bike>();
model3List = bikeCatalog.SearchBikesOfModel("model3List");

foreach (Bike item in model3List)
{
    Console.WriteLine(item);
}

// Test af DeleteAllBikesOfModel
bikeCatalog.DeleteAllBikesOfModel("Model2");

bikeCatalog.PrintBikeList();

Console.ReadKey();
