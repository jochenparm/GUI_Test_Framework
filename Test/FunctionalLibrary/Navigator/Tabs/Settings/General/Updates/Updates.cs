using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Updates
{
    public class Updates : NavigatorBase, IUpdates
    {
        public Updates()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates_Button.Click();
        }
    }
}