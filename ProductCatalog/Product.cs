using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

class Product
{
    string Name;
    int Price { get; set; }

    public Product (string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - ₩{Price:N0}";
    }

    public virtual void GetDescription()
    {

    }
   
}

class Electronics : Product
{
    int Warranty { get; set; } = 24;
    public Electronics() : base("노트북", 1500000) { }
    public override string ToString()
    {
        return $"{base.ToString()} + (보증: [{Warranty}] 개월)";
    }
    public override void GetDescription()
    {
        Console.WriteLine("-> 전자기기 입니다. 취급에 주의하세요.");
    }
}
class Clothing : Product
{
    char Size { get; set; } = 'M';
    public Clothing() : base("청바지", 89000) { }
    public override string ToString()
    {
        return $"{base.ToString()} + (사이즈: [{Size}])";
    }
    public override void GetDescription()
    {
        Console.WriteLine(" -> 의류입니다. 세탁 방법을 확인하세요");
    }
}

class Food : Product
{
    string ExpirationDate { get; set; } = "2026-06-14";

    public Food() : base("우유", 3500) { }
    public override string ToString()
    {
        return $"{base.ToString()} + (유통기한: [{ExpirationDate}])";
    }

    public override void GetDescription()
    {
        Console.WriteLine(" -> 식품입니다. 냉장 보관하세요");
    }
}
