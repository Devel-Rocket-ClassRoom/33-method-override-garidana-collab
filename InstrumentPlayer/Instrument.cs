using System;
using System.Collections.Generic;
using System.Text;

class Instrument
{
    private string _name;

    public Instrument(string name)
    {

    }

    public virtual string Play()
    {
        return $"[{_name}]을(를) 연주합니다";
    }

    public virtual string Tune()
    {
        return $"[{_name}]을(를) 조율합니다";
    }

}

class Piano : Instrument
{
    public Piano(string name) : base("피아노")  // 현재의 생성자가 부모 클래스의 생성자를 불러온다
    {
        
    }

    public override string Play()
    {
        return $"🎹 피아노 건반을 누릅니다 - 딩동댕~";
    }
}

class Guitar : Instrument
{
    public Guitar()
    {

    }
}