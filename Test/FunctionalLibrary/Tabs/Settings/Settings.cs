using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Settings.Accounts;
using Test.FunctionalLibrary.Tabs.Settings.General;

namespace Test.FunctionalLibrary.Tabs.Settings
{
    public class Settings : ISettings
    {
        public Settings()
        {
            MailWasher.Navigator.Tabs.Settings.Navigate();
        }

        private ISettingsAccounts Accounts
        {
            get
            {
                return new Accounts.SettingsAccounts();
            }
        }

        ISettingsAccounts ISettings.Accounts
        {
            get
            {
                return this.Accounts;
            }
        }

        private ISettingsGeneral General
        {
            get
            {
                return new General.SettingsGeneral();
            }
        }

        ISettingsGeneral ISettings.General
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}