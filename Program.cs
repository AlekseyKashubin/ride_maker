// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//make 4 cars

Vehicle car1 = new Vehicle("Honda Civic", "Red");
Vehicle car2 = new Vehicle("Acura NSX", 2, "White", true, 195);
Vehicle car3 = new Vehicle("Audi R8", 2, "Black", true, 201);
Vehicle car4 = new Vehicle("School Buss", 40, "Yellow", true, 72);


//List all cars
List<Vehicle> carList = new List<Vehicle>();
{
    carList.Add(car1);
    carList.Add(car2);
    carList.Add(car3);
    carList.Add(car4);
};



//loop through the list and show info
foreach(Vehicle c in carList)
{
    c.ShowInfo();
}
//add 100 miles to the cars and show updated info
car1.Travel(100);
car2.Travel(45000);
car3.Travel(10400);
car4.Travel(83274);
car1.Travel(4500);

Console.WriteLine(car1.ShowInfo());
Console.WriteLine(car2.ShowInfo());
Console.WriteLine(car3.ShowInfo());
Console.WriteLine(car4.ShowInfo());