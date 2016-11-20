using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Menu;
using Test.FunctionalLibrary.Navigator;

namespace Test.FunctionalLibrary
{
    public class Main : IMain
    {
        public Main()
        { }

        private void Maximize_Window()
        {
            MailWasher.UiMap.MainWindow.MaximizeWindow_Button.Click();
        }

        IMain IMain.Maximize_Window()
        {
            this.Maximize_Window();
            Log.Information("FunctionalLibrary.Main: Maximized Window");
            return this;
        }

        private void Minimize_Window()
        {
            MailWasher.UiMap.MainWindow.MinimizeWindow_Button.Click();
        }

        IMain IMain.Minimize_Window()
        {
            this.Minimize_Window();
            Log.Information("FunctionalLibrary.Main: Minimized Window");
            return this;
        }

        private void Close_Window()
        {
            MailWasher.UiMap.MainWindow.MinimizeWindow_Button.Click();
        }

        IMain IMain.Close_Window()
        {
            this.Close_Window();
            Log.Information("FunctionalLibrary.Main: Closed Window");
            return this;
        }

        private IMenu Menu
        {
            get
            {
                return new Menu.Menu();
            }
        }

        IMenu IMain.Menu
        {
            get
            {
                return this.Menu;
            }
        }
    }
}