using System;
using System.Collections.Generic;
using System.Text;

class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal Eat");
    }
}

class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cat Eat");
    }
}