using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts.Outgoing
{
    public class SettingsAccountsOutgoing : ISettingsAccountsOutgoing
    {
        public SettingsAccountsOutgoing()
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Navigate();
        }

        private void Save()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Save_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Save_Button.Click();
            }
        }

        ISettingsAccountsOutgoing ISettingsAccountsOutgoing.Save()
        {
            this.Save();
            return this;
        }

        private void Set_Authentication_Custom(string username, string password)
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Use_The_Following_Login_RadioButton.Select();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Username_TextBox.Content = username;
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Password_TextBox.Content = password;
        }

        ISettingsAccountsOutgoing ISettingsAccountsOutgoing.Set_Authentication_Custom(string username, string password)
        {
            this.Set_Authentication_Custom(username, password);
            return this;
        }

        private void Set_Authentication_Same_As_Incoming_Server()
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton.Select();
        }

        ISettingsAccountsOutgoing ISettingsAccountsOutgoing.Set_Authentication_Same_As_Incoming_Server()
        {
            this.Set_Authentication_Same_As_Incoming_Server();
            return this;
        }

        private void Set_Secure_Connection_Protocol(SecureConnectionProtocols protocol)
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.
                Secure_Connection_DropDownMenu.Select(protocol.ToString().Replace("_", " "));
        }

        ISettingsAccountsOutgoing ISettingsAccountsOutgoing.Set_Secure_Connection_Protocol(SecureConnectionProtocols protocol)
        {
            this.Set_Secure_Connection_Protocol(protocol);
            return this;
        }

        private void Set_Server_Port_Number(int portNumber)
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Server_Port_Number_TextBox.Content = portNumber.ToString();
        }

        ISettingsAccountsOutgoing ISettingsAccountsOutgoing.Set_Server_Port_Number(int portNumber)
        {
            this.Set_Server_Port_Number(portNumber);
            return this;
        }

        private void Set_SMTP_Server_Address(string serverAddress)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.SMTP_Server_Address_TextBox.Content = serverAddress;
        }

        ISettingsAccountsOutgoing ISettingsAccountsOutgoing.Set_SMTP_Server_Address(string serverAddress)
        {
            this.Set_SMTP_Server_Address(serverAddress);
            return this;
        }

        private void SMTP_Server_Requires_Authentication(bool enable)
        {
            MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate();
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.SMTP_Server_Requires_Authentication_CheckBox.Set(enable);
        }

        ISettingsAccountsOutgoing ISettingsAccountsOutgoing.SMTP_Server_Requires_Authentication(bool enable)
        {
            this.SMTP_Server_Requires_Authentication(enable);
            return this;
        }
    }
}