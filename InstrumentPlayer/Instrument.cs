using System;
using System.Collections.Generic;
using System.Text;

class Instrument
{
    private string _name;

    public Instrument(string name)
    {
        _name = name;
    }

    public virtual void Play()
    {
        Console.WriteLine($"[{_name}]을(를) 연주합니다");
    }

    public virtual void Tune()
    {
        Console.WriteLine($"[{_name}]을(를) 조율합니다");
    }

}

class Piano : Instrument
{
    // 자식 클래스의 생성자가 부모 클래스의 생성자를 불러옴 
    // Instrument (string name) 을 base()로 불러옴
    public Piano() : base("피아노")   
    {
        
    } 
   

    public override void Play()
    {
        Console.WriteLine($"🎹 피아노 건반을 누릅니다 - 딩동댕~");
    }

    public override void Tune()
    {
        Console.WriteLine($"피아노 현을 조율합니다");
    }
   
}

class Guitar : Instrument
{
    public Guitar() : base("기타")
    {
        
    }

    public override void Play()
    {
        Console.WriteLine($"🎸 기타 줄을 튕깁니다 - 통통통~");
    }
    public override void Tune()
    {
        Console.WriteLine($"기타 줄을 조율합니다");
    }
}
class Drum : Instrument
{
    public Drum() : base("드럼")
    {
        
    }

    public override void Play()
    {
        Console.WriteLine("🥁 드럼을 두드립니다 - 둥둥둥~");
    }
}