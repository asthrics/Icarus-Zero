namespace Icarus_Zero_Reactor.Models;

public class Core
{
    public int Temperature { get; set; } // in Celsius
    public bool IsActive { get; set; }

    public Core()
    {
        Temperature = 0;
        IsActive = false;
    }
}