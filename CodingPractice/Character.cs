using System;

class Character
{
    public string Name;
    public int AttackPower;

    public Character(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다. 데미지: {AttackPower}");
    }

    public override string ToString()
    {
        return $"[{Name}] 공격력: {AttackPower}";
    }
}

class Warrior : Character
{
    public Warrior(string name) : base(name, 50) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 칼로 베어냅니다! 데미지: {AttackPower}");
    }
}

class Mage : Character
{
    public Mage(string name) : base(name, 30) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 파이어볼을 시전합니다! 데미지: {AttackPower * 2}");
    }
}

class Archer : Character
{
    public Archer(string name) : base(name, 40) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 화살을 쏩니다! 데미지: {AttackPower}");
    }
}