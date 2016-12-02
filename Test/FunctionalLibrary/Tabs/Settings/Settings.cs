using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General;

namespace Test.FunctionalLibrary.Tabs.Settings
{
    public class Settings : ISettings
    {
        public Settings()
        {
            MailWasher.UiMap.MainWindow.Settings_Tab.Open();
        }

        IAccounts ISettings.Accounts
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IGeneral ISettings.General
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}