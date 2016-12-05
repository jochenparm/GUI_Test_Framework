using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Sync
{
    public class SyncNavigator : NavigatorBase, ISyncNavigator
    {
        public SyncNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Sync_Button.Click();
        }

        public Account.IAccountNavigator Account
        {
            get
            {
                return new Account.AccountNavigator();
            }
        }

        public Mobile.IMobileNavigator Mobile
        {
            get
            {
                return new Mobile.MobileNavigator();
            }
        }
    }
}