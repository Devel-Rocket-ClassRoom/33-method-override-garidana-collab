using System;
using static System.Console;
// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 악기 연주회 ===");
Instrument[] instruments = new Instrument[]
{
    new Piano(),
    new Guitar(),
    new Drum()
};
foreach (Instrument instrument in instruments)
{
    instrument.Tune();
    instrument.Play();
}
