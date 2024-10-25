using Cars.Model;

class Program
{
    static void Main(string[] args)
    {
        var car1 = new CarBuilder()
            .SetMake("Toyota")
            .SetModel("Camry")
            .SetYear(2020)
            .SetColor("Red")
            .Build();

        var car2 = new CarBuilder()
            .SetMake("Honda")
            .SetModel("Civic")
            .SetYear(2021)
            .SetColor("Blue")
            .Build();

        Console.WriteLine(car1);
        Console.WriteLine(car2);
    }
}
