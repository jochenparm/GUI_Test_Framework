using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Sync.Mobile
{
    public class Mobile : NavigatorBase, IMobile
    {
        public Mobile()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Sync.Mobile_Button.Click();
        }
    }
}