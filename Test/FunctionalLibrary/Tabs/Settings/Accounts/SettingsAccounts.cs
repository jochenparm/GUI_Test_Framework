using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.Factory;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.General;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.Incoming;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.Outgoing;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts
{
    public class SettingsAccounts : ISettingsAccounts
    {
        private readonly IFunctionalSettingsAccountsFactory _settingsAccountsFactory;

        public SettingsAccounts()
        {
            this._settingsAccountsFactory = new FunctionalSettingsAccountsFactory();
            MailWasher.Navigator.Tabs.Settings.Accounts.Navigate();
        }

        private void Select_Email_Account(string accountName)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Accounts_List.Select(accountName);
        }

        private void Add_Email_Account(string accountName, string accountEmailAddress)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Add_Email_Account_Button.Click();
            MailWasher.Main.Tabs.Settings.Accounts.General
                .Set_Account_Description(accountName)
                .Set_Account_Email_Address(accountEmailAddress)
                .Save();
        }

        ISettingsAccounts ISettingsAccounts.Add_Email_Account(string accountName, string accountEmailAddress)
        {
            this.Add_Email_Account(accountName, accountEmailAddress);
            return this;
        }

        private void Remove_Email_Account(string accountName)
        {
            this.Select_Email_Account(accountName);
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Remove_Account_Button.Click();
        }

        ISettingsAccounts ISettingsAccounts.Remove_Email_Account(string accountName)
        {
            this.Remove_Email_Account(accountName);
            return this;
        }

        private bool Exists(string accountName)
        {
            return MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Accounts_List.Exists(accountName);
        }

        bool ISettingsAccounts.Exists(string accountName)
        {
            return this.Exists(accountName);
        }

        ISettingsAccountsGeneral ISettingsAccounts.General
        {
            get
            {
                return this._settingsAccountsFactory.Get_General();
            }
        }

        ISettingsAccountsIncoming ISettingsAccounts.Incoming
        {
            get
            {
                return this._settingsAccountsFactory.Get_Incoming();
            }
        }

        ISettingsAccountsOutgoing ISettingsAccounts.Outgoing
        {
            get
            {
                return this._settingsAccountsFactory.Get_Outgoing();
            }
        }
    }
}