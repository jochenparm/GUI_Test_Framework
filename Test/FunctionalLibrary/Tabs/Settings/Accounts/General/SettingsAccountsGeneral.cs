using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts.General
{
    public class SettingsAccountsGeneral : ISettingsAccountsGeneral
    {
        public SettingsAccountsGeneral()
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.General.Navigate();
        }

        private void Include_In_Default_Mail_Check(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Include_In_Default_Mail_Check_CheckBox.Set(enable);
        }

        ISettingsAccountsGeneral ISettingsAccountsGeneral.Include_In_Default_Mail_Check(bool enable)
        {
            this.Include_In_Default_Mail_Check(enable);
            return this;
        }

        private void Save()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Save_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Save_Button.Click();
            }
        }

        ISettingsAccountsGeneral ISettingsAccountsGeneral.Save()
        {
            this.Save();
            return this;
        }

        private void Set_Account_Description(string accountName)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Account_Description_TextBox.Content = accountName;
        }

        ISettingsAccountsGeneral ISettingsAccountsGeneral.Set_Account_Description(string accountName)
        {
            this.Set_Account_Description(accountName);
            return this;
        }

        private void Set_Account_Email_Address(string accountEmailAddress)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Account_Description_TextBox.Content = accountEmailAddress;
        }

        ISettingsAccountsGeneral ISettingsAccountsGeneral.Set_Account_Email_Address(string accountEmailAddress)
        {
            this.Set_Account_Email_Address(accountEmailAddress);
            return this;
        }
    }
}