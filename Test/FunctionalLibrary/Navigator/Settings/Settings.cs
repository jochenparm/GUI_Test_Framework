using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings
{
    public class Settings : NavigatorBase, ISettings
    {
        public Settings()
        {
            MailWasher.UiMap.MainWindow.SettingsTab_Button.Click();
        }

        public Accounts.IAccounts Accounts
        {
            get
            {
                return new Accounts.Accounts();
            }
        }

        public Sync.ISync Sync
        {
            get
            {
                return new Sync.Sync();
            }
        }
    }
}