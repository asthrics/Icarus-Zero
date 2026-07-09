using Terminal.Gui.App;
using Terminal.Gui.Views;
namespace Icarus_Zero_Reactor;

internal class Program
{
    static void Main()
    {
        using IApplication app = Application.Create();
        app.Init();

        // Step 1: Create the root window
        var root = new Window()
        {
            Title = "My First Window"
            
        };
        // --------------------------------

        // Step 2: These are all your "Elements" that you can add to the root window. You can create buttons, labels, text fields, etc.
        var label = new Label()
        {
            X = 2 /*X Coordinate*/, Y = 1 /*Y Coordinate*/, Text = "Hello, ICARUS-ZERO!"
        };
        var testLabel = new Label()
        {
            X = 2,
            Y = 2,
            Text = "This is a test label."
        };
        // --------------------------------

        // Here we connect all the elements together
        root.Add(label);
        root.Add(testLabel);
        // --------------------------------

        app.Run(root); /*<- This just runs the whole things (always comes at the end)*/
    }
}