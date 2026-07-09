using Icarus_Zero_Reactor.Services;
using Terminal.Gui.Views;

namespace Icarus_Zero_Reactor.SimulationUI
{
    public class MainUI
    {
        internal TGuiSchemes tGuiSchemes = new TGuiSchemes();
        public Window RootWindow { get; private set; }
        public void InitializeUI()
        {
            createRootWindow();
            createWindows();
            createLabels();
            createButtons();
            createTextFields();
            createProgressIndicators();
            createEvents();
        }
        private void createRootWindow()
        {
            RootWindow = new Window()
            {
                X = 0,
                Y = 0
            };
            RootWindow.BorderStyle = Terminal.Gui.Drawing.LineStyle.None;
        }
        private void createWindows()
        {
        }
        private void createLabels()
        {
        }
        private void createButtons()
        {
        }
        private void createTextFields()
        {
        }
        private void createProgressIndicators()
        {
        }
        private void createEvents()
        {
        }
    }
}
