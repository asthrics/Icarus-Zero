using Terminal.Gui.App;
using Terminal.Gui.Views;
namespace Icarus_Zero_Reactor;

internal class Program
{
    static void Main()
    {
        using IApplication app = Application.Create();
        app.Init();

        // Root Window
        var root = new Window()
        {
            Title = "My First Window"
            
        };
        // --------------------------------

        // Elements
        var label = new Label()
        {
            X = 2 , Y = 1 , Text = "Hello, ICARUS-ZERO!"
        };
        var statusLabel = new Label() // here we added a Label to show the status of the button click
        {
            X = 2 ,
            Y = 5, 
            Text = "Status: No button was clicked yet..." // FIrst thing that stands there. you can leave this empty (or out, not sure yet)
        };
        var button = new Button() // thats a button. Its under the label and above the status label.
        {
            X = 2, Y = 3, // IMPORTANT: Make sure you leave atleast 2 spaces! if only 1 space is left, itll bug.
            Text = "Click Me!"
        };
        // --------------------------------
        // Button Click Events
        button.Accepting += (_,_) => // button.Accepting = sees if the button is pressed. += (_,_) => is basically just random ahh shit. ignore that ig. the _,_ is basically empty because usually theres data to save. idk
        {
            statusLabel.Text = "Status: Button Clicked!";
        };

        // Connecting Elements to Root Window
        root.Add(label);
        root.Add(statusLabel);
        root.Add(button);
        // --------------------------------

        app.Run(root); 
    }
}