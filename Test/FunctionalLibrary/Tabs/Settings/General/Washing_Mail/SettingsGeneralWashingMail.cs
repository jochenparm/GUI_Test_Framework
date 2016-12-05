using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Washing_Mail
{
    public class SettingsGeneralWashingMail : ISettingsGeneralWashingMail
    {
        public SettingsGeneralWashingMail()
        {
            MailWasher.Navigator.Tabs.Settings.General.Washing_Mail.Navigate();
        }

        private void Launch_After_Wash_Mail(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Launch_Email_Program_After_Wash_Mail_CheckBox.Set(enable);
        }

        ISettingsGeneralWashingMail ISettingsGeneralWashingMail.Launch_After_Wash_Mail(bool enable)
        {
            this.Launch_After_Wash_Mail(enable);
            return this;
        }

        private void Minimize_MailWasher_After_Wash_Mail(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Minimize_MailWasher_After_Wash_Mail_CheckBox.Set(enable);
        }

        ISettingsGeneralWashingMail ISettingsGeneralWashingMail.Minimize_MailWasher_After_Wash_Mail(bool enable)
        {
            this.Minimize_MailWasher_After_Wash_Mail(enable);
            return this;
        }

        private void Save()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Save_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Save_Button.Click();
            }
        }

        ISettingsGeneralWashingMail ISettingsGeneralWashingMail.Save()
        {
            this.Save();
            return this;
        }

        private void Use_Default_Email_Program_Icon(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Use_Default_Email_Program_Icon_CheckBox.Set(enable);
        }

        ISettingsGeneralWashingMail ISettingsGeneralWashingMail.Use_Default_Email_Program_Icon(bool enable)
        {
            this.Use_Default_Email_Program_Icon(enable);
            return this;
        }
    }
}