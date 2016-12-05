using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts.Incoming
{
    public class SettingsAccountsIncoming : ISettingsAccountsIncoming
    {
        public SettingsAccountsIncoming()
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate();
        }

        private void Download_Read_Emails(bool enable)
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Advanced.Navigate();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Download_Read_Emails_CheckBox.Set(enable);
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Download_Read_Emails(bool enable)
        {
            this.Download_Read_Emails(enable);
            return this;
        }

        private void Remember_Password(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Remember_Password_CheckBox.Set(enable);
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Remember_Password(bool enable)
        {
            this.Remember_Password(enable);
            return this;
        }

        private void Save()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Save_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Save_Button.Click();
            }
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Save()
        {
            this.Save();
            return this;
        }

        private void Set_Password(string password)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Password_TextBox.Content = password;
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Set_Password(string password)
        {
            this.Set_Password(password);
            return this;
        }

        private void Set_Server_Address(string address)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Server_Address_TextBox.Content = address;
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Set_Server_Address(string address)
        {
            this.Set_Server_Address(address);
            return this;
        }

        private void Set_Server_Port_Number(int portNumber)
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Advanced.Navigate();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Server_Port_Number_TextBox.Content = portNumber.ToString();
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Set_Server_Port_Number(int portNumber)
        {
            this.Set_Server_Port_Number(portNumber);
            return this;
        }

        private void Set_Server_Type(ServerTypes type)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Server_Type_DropDownMenu.Select(type.ToString());
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Set_Server_Type(ServerTypes type)
        {
            this.Set_Server_Type(type);
            return this;
        }

        private void Set_Username(string username)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.User_Name_TextBox.Content = username;
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Set_Username(string username)
        {
            this.Set_Username(username);
            return this;
        }

        private void Store_Cached_Emails(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Store_Cached_Emails_CheckBox.Set(enable);
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Store_Cached_Emails(bool enable)
        {
            this.Store_Cached_Emails(enable);
            return this;
        }

        private void This_Server_Requires_A_Secure_Connection(bool enable)
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Advanced.Navigate();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.This_Server_Requires_A_Secure_Connection_CheckBox.Set(enable);
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.This_Server_Requires_A_Secure_Connection(bool enable)
        {
            this.This_Server_Requires_A_Secure_Connection(enable);
            return this;
        }

        private void Use_OAUTH(bool enable)
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Advanced.Navigate();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Use_OAUTH_CheckBox.Set(enable);
        }

        ISettingsAccountsIncoming ISettingsAccountsIncoming.Use_OAUTH(bool enable)
        {
            this.Use_OAUTH(enable);
            return this;
        }
    }
}