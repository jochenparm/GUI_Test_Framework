using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts
{
    public class SettingsAccounts : ISettingsAccounts
    {
        public SettingsAccounts()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts_Button.Click();
        }

        private void Select_Email_Account(string accountName)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Accounts_List.Select(accountName);
        }

        private void Add_Email_Account(string accountName, string accountEmailAddress)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Add_Email_Account_Button.Click();
            MailWasher.Main
        }

        void ISettingsAccounts.Add_Email_Account(string accountName, string accountEmailAddress)
        {
            throw new NotImplementedException();
        }

        void ISettingsAccounts.Remove_Email_Account(string accountName)
        {
            this.Select_Email_Account(accountName);
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Remove_Account_Button.Click();
        }
    }
}