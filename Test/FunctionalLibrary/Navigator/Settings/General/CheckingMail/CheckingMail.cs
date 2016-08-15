using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.General.CheckingMail
{
    public class CheckingMail : NavigatorBase, ICheckingMail
    {
        public CheckingMail()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail_Button.Click();
        }
    }
}