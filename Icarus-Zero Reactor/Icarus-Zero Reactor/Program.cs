using Icarus_Zero_Reactor.SimulationUI;
using Terminal.Gui.App;
namespace Icarus_Zero_Reactor;

public class Program
{
    static void Main()
    {
        using IApplication app = Application.Create();
        app.Init();

        MainUI mainUi = new MainUI();
        mainUi.InitializeUI();

        app.Run(mainUi.RootWindow);
    }
}