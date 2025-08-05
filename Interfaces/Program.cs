using System;

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        Bicycle myBicycle = new Bicycle();

        Console.WriteLine("\nDemonstrating Interfaces:");
        myCar.Move();
        myBicycle.Move();
    }
}
