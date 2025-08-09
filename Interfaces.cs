using System;

// Interface definition
interface IMovable
{
    void Move();
}

// Car class
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle class
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Interface
{
    static void Main()
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();      // Car is moving
        bicycle.Move();  // Bicycle is moving
    }
}
