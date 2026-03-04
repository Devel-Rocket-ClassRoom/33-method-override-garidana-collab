using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console;




// Parent Class
class Parent
{
    // work
    public virtual void Work()
    {
        WriteLine("프로그래머");
    }
    // Greet
    public virtual void Greet()
    {
        Console.WriteLine("안녕하세요");
    }
   
    // Say
    public void Say()
    {
        Console.WriteLine("부모_안녕하세요.");
    }
    // Run
    public void Run()
    {
        Console.WriteLine("부모_달리다.");
    }
    // virtual Walk
    public virtual void Walk()
    {
        Console.WriteLine("부모_걷다.");
    }
}


// Child Class
class Child : Parent
{
   
    public sealed override void Work()
    {
        base.Work();
    }

    public new void Say()
    {
        Console.WriteLine("자식_안녕하세요.");
    }
    public new void Run()
    {
        Console.WriteLine("자식_달리다.");
    }
    public override void Walk()
    {
        Console.WriteLine("자식_걷다");
    }

    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("반갑습니다");
    }
}

//GrandChild class
class GrandChild : Child
{
    //public override void Work()
    //{
    //    Console.WriteLine("프로게이");
    //}

    public void Play()
    {
        Console.WriteLine("프로게이머");
    }
}

