using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Checking_Mail
{
    public class SettingsGeneralCheckingMail : ISettingsGeneralCheckingMail
    {
        public SettingsGeneralCheckingMail()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail_Button.Click();
        }

        private void Check_Default_Accounts_When_MailWasher_Starts(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Check_Default_Accounts_When_MailWasher_Starts_CheckBox.Set(enable);
        }

        ISettingsGeneralCheckingMail ISettingsGeneralCheckingMail.Check_Default_Accounts_When_MailWasher_Starts(bool enable)
        {
            this.Check_Default_Accounts_When_MailWasher_Starts(enable);
            return this;
        }

        private void Periodically_Check_Mail(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Periodically_Check_Mail_CheckBox.Set(enable);
        }

        ISettingsGeneralCheckingMail ISettingsGeneralCheckingMail.Periodically_Check_Mail(bool enable)
        {
            this.Periodically_Check_Mail(enable);
            return this;
        }

        private void Reset_Check_Throttle()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Check_Throttle_Reset_Button.Click();
        }

        ISettingsGeneralCheckingMail ISettingsGeneralCheckingMail.Reset_Check_Throttle()
        {
            this.Reset_Check_Throttle();
            return this;
        }

        private void Reset_Spam_Throttle()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Spam_Throttle_Reset_Button.Click();
        }

        ISettingsGeneralCheckingMail ISettingsGeneralCheckingMail.Reset_Spam_Throttle()
        {
            this.Reset_Spam_Throttle();
            return this;
        }

        private void Save()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Save_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Save_Button.Click();
            }
        }

        ISettingsGeneralCheckingMail ISettingsGeneralCheckingMail.Save()
        {
            this.Save();
            return this;
        }

        private void Set_Check_Period(int minutes)
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Mail_Check_Interval_TextBox.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Mail_Check_Interval_TextBox.Content = minutes.ToString();
            }
        }

        ISettingsGeneralCheckingMail ISettingsGeneralCheckingMail.Set_Check_Period(int minutes)
        {
            this.Set_Check_Period(minutes);
            return this;
        }

        private void Set_Check_Throttle(int numberOfAccounts)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Check_Throttle_Slider.Value = numberOfAccounts;
        }

        ISettingsGeneralCheckingMail ISettingsGeneralCheckingMail.Set_Check_Throttle(int numberOfAccounts)
        {
            this.Set_Check_Throttle(numberOfAccounts);
            return this;
        }

        private void Set_Spam_Throttle(int numberOfLines)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Spam_Throttle_Slider.Value = numberOfLines;
        }

        ISettingsGeneralCheckingMail ISettingsGeneralCheckingMail.Set_Spam_Throttle(int numberOfLines)
        {
            this.Set_Spam_Throttle(numberOfLines);
            return this;
        }
    }
}