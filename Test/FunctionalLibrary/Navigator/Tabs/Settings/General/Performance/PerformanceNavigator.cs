using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Performance
{
    public class PerformanceNavigator : NavigatorBase, IPerformanceNavigator
    {
        public PerformanceNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance_Button.Click();
        }
    }
}