using System;
using System.ComponentModel;
using System.Threading;

// 1
Parent parent = new();
Child child = new();
parent.Work();
child.Work();

Console.WriteLine() ;

// 1-2
Animal animal = new();
animal.Eat();
Cat cat = new();
cat.Eat();

Console.WriteLine() ;

// 2
Child child1 = new Child();
child1.Say();     // new: 자식 메서드
child1.Run();     // new: 자식 메서드  
child1.Walk();
Parent parent1 = child1;
parent.Say();    // new: 부모 메서드 (!)
parent.Run();    // new: 부모 메서드 (!)
parent.Walk();   // 자식 클래스 Child에서 오버라이드를 했으므로, Child의 Work 메서드가 출력됨

Console.WriteLine(); 

// 3
Calculator calc = new();
Console.WriteLine(calc.Add(1, 2));
Console.WriteLine(calc.Add(2.5, 1.5));
Console.WriteLine(calc.Add(2, 2, 2));

Console.WriteLine();

// 4-1
child.Greet();

Console.WriteLine();

// 4-2

parent.Work();
child.Work();
GrandChild grandchild = new();
grandchild.Work();

Console.WriteLine();

// 5
new Parent().Work();
new Child().Work();
new GrandChild().Work();
new GrandChild().Play();

Console.WriteLine();

// 6-1
Person person = new("erer");
Console.WriteLine(person);

Console.WriteLine();

// 6-2
Person person1 = new("박용준");
Console.WriteLine(person1.ToString());

// 7-1
Character warrior = new Warrior ("전사");
Character mage = new Mage("법사");
Character archer = new Archer("아처");

Console.WriteLine(warrior);
Console.WriteLine(mage);
Console.WriteLine(archer);
Console.WriteLine();

warrior.Attack();
mage.Attack();
archer.Attack();

Console.WriteLine();


// 7-2
Character[] characters = new Character[]  // 배열은 전부 써야함
{
    new Warrior("전사"),
    new Mage("마법사"),
    new Archer("궁수")
};
Console.WriteLine("=== 파티 공격 ===");
foreach (Character members in characters)
{
    members.Attack();
}