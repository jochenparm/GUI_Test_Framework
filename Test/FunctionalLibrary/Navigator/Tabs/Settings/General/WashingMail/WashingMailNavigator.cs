using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.General.WashingMail
{
    public class WashingMailNavigator : NavigatorBase, IWashingMailNavigator
    {
        public WashingMailNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail_Button.Click();
        }
    }
}