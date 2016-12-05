using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.General.CheckingMail
{
    public class CheckingMailNavigator : NavigatorBase, ICheckingMailNavigator
    {
        public CheckingMailNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail_Button.Click();
        }
    }
}