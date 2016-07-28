using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;

namespace Test.FunctionalLibrary
{
    public class Main : IMain
    {
        public Main()
        {
        }

        private void Maximize_Window()
        {
            MailWasher.UiMap.MainWindow.MaximizeWindow_Button.Click();
        }

        IMain IMain.Maximize_Window()
        {
            this.Maximize_Window();
            return this;
        }

        private void Minimize_Window()
        {
            MailWasher.UiMap.MainWindow.MinimizeWindow_Button.Click();
        }

        IMain IMain.Minimize_Window()
        {
            this.Minimize_Window();
            return this;
        }

        private void Close_Window()
        {
            MailWasher.UiMap.MainWindow.MinimizeWindow_Button.Click();
        }

        IMain IMain.Close_Window()
        {
            this.Close_Window();
            return this;
        }

        private INavigator Navigator
        {
            get
            {
                return new Navigator.Navigator();
            }
        }

        Navigator.INavigator IMain.Navigator
        {
            get
            {
                return this.Navigator;
            }
        }
    }
}