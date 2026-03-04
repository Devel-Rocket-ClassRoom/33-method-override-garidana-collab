using System;
using System.Collections.Generic;
using System.Text;

class Person
{
    public string Name;


    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"[Person 클래스: {Name}]";
    }
}