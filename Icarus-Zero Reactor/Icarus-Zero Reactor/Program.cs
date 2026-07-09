using Terminal.Gui.App;
using Terminal.Gui.Drawing;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;
namespace Icarus_Zero_Reactor;

public class Program
{
    static void Main()
    {
        using IApplication app = Application.Create();
        app.Init();

        // Root Window
        var root = new Window()
        {
        };
        // --------------------------------

        var reactorStatus = new Window()
        {
            X = 0,
            Y = 0,
            Width = Dim.Percent(50),
            Height = Dim.Percent(50)
        };
        var reactorControl = new Window()
        {
            X = 0,
            Y = Pos.Bottom(reactorStatus),
            Width = Dim.Percent(50),
            Height = Dim.Fill()
        };
        var reactorLog = new Window()
        {
            X = Pos.Right(reactorStatus), 
            Y = 0,
            Width = Dim.Fill(),
            Height = Dim.Fill()
        };

        root.Add(reactorStatus);
        root.Add(reactorControl);
        root.Add(reactorLog);

        root.BorderStyle = LineStyle.None;

        app.Run(root); 
    }
}