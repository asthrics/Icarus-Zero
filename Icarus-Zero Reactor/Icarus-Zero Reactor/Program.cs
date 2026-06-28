using JetBrains.Annotations;

namespace Icarus_Zero_Reactor;

internal class Program
{
    static void Main()
    {
        Logic.StartStopReactor startStop = new();
        startStop.Start();
        Console.ReadKey();
    }
}
