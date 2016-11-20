using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Menu;
using Test.FunctionalLibrary.Navigator.Tabs;

namespace Test.FunctionalLibrary.Navigator
{
    public class Navigator : INavigator
    {
        public Navigator()
        {
        }

        private IMenu Menu
        {
            get
            {
                return new Menu.Menu();
            }
        }

        IMenu INavigator.Menu
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

        ITabs INavigator.Tabs
        {
            get
            {
                return this.Tabs;
            }
        }
    }
}