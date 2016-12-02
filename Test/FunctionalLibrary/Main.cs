using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Menu;
using Test.FunctionalLibrary.Navigator;
using Test.FunctionalLibrary.Tabs;

namespace Test.FunctionalLibrary
{
    public class Main : IMain
    {
        public Main()
        { }

        private void Maximize_Window(bool writeToLog)
        {
            try
            {
                MailWasher.UiMap.MainWindow.MaximizeWindow_Button.Click();
                if(writeToLog)
                {
                    Log.Information("Invoked {MethodName:l} method", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch(Exception)
            {
                Log.Error("Failed to invoke {MethodName:l} method", MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        IMain IMain.Maximize_Window()
        {
            this.Maximize_Window(true);
            return this;
        }

        private void Minimize_Window()
        {
            MailWasher.UiMap.MainWindow.MinimizeWindow_Button.Click();
        }

        IMain IMain.Minimize_Window()
        {
            try
            {
                this.Minimize_Window();
                Log.Information("Invoked {MethodName:l} method", MethodBase.GetCurrentMethod().Name);
                return this;
            }
            catch(Exception)
            {
                Log.Error("Failed to invoke {MethodName:l} method", MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        private void Close_Window()
        {
            MailWasher.UiMap.MainWindow.MinimizeWindow_Button.Click();
        }

        IMain IMain.Close_Window()
        {
            try
            {
                this.Close_Window();
                Log.Information("Invoked {MethodName:l} method", MethodBase.GetCurrentMethod().Name);
                return this;
            }
            catch(Exception)
            {
                Log.Error("Failed to invoke {MethodName:l} method", MethodBase.GetCurrentMethod().Name);
                throw;
            }
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

        private ITabs Tabs
        {
            get
            {
                return new Tabs.Tabs();
            }
        }

        ITabs IMain.Tabs
        {
            get
            {
                return this.Tabs;
            }
        }
    }
}