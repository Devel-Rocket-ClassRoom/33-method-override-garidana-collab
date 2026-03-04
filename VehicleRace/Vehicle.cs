using System;
using System.Collections.Generic;
using System.Text;

class Vehicle
{
    protected string Name { get; set; }
    protected int Speed { get; set; }

    public Vehicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name}이(가) 이동합니다. 속도: {Speed}km/h");
    }
}

class Car : Vehicle
{

    public Car(string name) : base(name, 120) { }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 질주합니다! 속도: {Speed}km/h");
    }
}
class Airplane : Vehicle
{

    public Airplane(string name) : base(name, 120) { }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 질주합니다! 속도: {Speed}km/h");
    }
}
class Boat : Vehicle
{

    public Boat(string name) : base(name, 120) { }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 질주합니다! 속도: {Speed}km/h");
    }
}
