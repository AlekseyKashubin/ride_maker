public class Vehicle
{

    //Feilds
    public string CarMake;
    public int NumOfPass;
    public string Color;
    public bool Engine;
    public int TopSpeed;
    public int Miles = 0;

//Constructors
    public Vehicle(string carMake, int numOfPass, string color, bool engine, int topSpeed)
    {
        CarMake = carMake;
        NumOfPass = numOfPass;
        Color = color;
        Engine = engine;
        TopSpeed = topSpeed;

    }

    public Vehicle(string carMake, string color)
    {
        CarMake = carMake;
        NumOfPass = 5;
        Color = color;
        Engine = true;
        TopSpeed = 100;

    }

//Methods
    public string ShowInfo()
    {
        return $"Make :{CarMake} Number of Passengers :{NumOfPass} Color :{Color} Has Engine :{Engine} Top Speed :{TopSpeed} Miles Traveled : {Miles}";
    }

    public void Travel(int mile)
    {
        Miles = mile + Miles;
        Console.WriteLine($"You drove {mile} miles. Your car mileage is {Miles}");

    }





    
}


