using System;

// README.md를 읽고 코드를 작성하세요.


Console.WriteLine("=== 경주 시작 ===");
Vehicle[] vehicles = new Vehicle[]
{
    new Car("스포츠카"),
    new Airplane("보잉 747"),
    new Boat("요트")
};

foreach (Vehicle vehicle in vehicles)
{
    vehicle.Move();
}
