using Terminal.Gui.App;
using Terminal.Gui.Views;
namespace Icarus_Zero_Reactor.Logic;

public class StartStopReactor
{
    public void Start()
    {
        Application.Init();

        Window window1 = new()
        {
            Text = "Hi bitch 1"
        };
        Window window2 = new()
        {
            Text = "Hi bitch 2"
        };
        
        window1.Add();
        window2.Add();
        app.Run(window1);
        app.Run(window2);
    }
}
