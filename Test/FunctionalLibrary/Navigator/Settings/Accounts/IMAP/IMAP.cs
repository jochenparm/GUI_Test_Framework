using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.Accounts.IMAP
{
    public class IMAP : NavigatorBase, IIMAP
    {
        public IMAP()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.IMAP_Button.Click();
        }
    }
}