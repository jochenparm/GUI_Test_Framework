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

        private IMenuNavigator Menu
        {
            get
            {
                return new Menu.MenuNavigator();
            }
        }

        IMenuNavigator INavigator.Menu
        {
            get
            {
                return this.Menu;
            }
        }

        private ITabsNavigator Tabs
        {
            get
            {
                return new Tabs.TabNavigator();
            }
        }

        ITabsNavigator INavigator.Tabs
        {
            get
            {
                return this.Tabs;
            }
        }
    }
}