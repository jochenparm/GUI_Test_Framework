using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Updates
{
    public class SettingsGeneralUpdates : ISettingsGeneralUpdates
    {
        public SettingsGeneralUpdates()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates_Button.Click();
        }

        private void Automatically_Check_For_Updates(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Automatically_Check_For_Update_CheckBox.Set(enable);
        }

        ISettingsGeneralUpdates ISettingsGeneralUpdates.Automatically_Check_For_Updates(bool enable)
        {
            this.Automatically_Check_For_Updates(enable);
            return this;
        }

        private void Save()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Save_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Save_Button.Click();
            }
        }

        ISettingsGeneralUpdates ISettingsGeneralUpdates.Save()
        {
            this.Save();
            return this;
        }

        private void Set_Update_Frequency(int days)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Update_Frequency_TextBox.Content = days.ToString();
        }

        ISettingsGeneralUpdates ISettingsGeneralUpdates.Set_Update_Frequency(int days)
        {
            this.Set_Update_Frequency(days);
            return this;
        }
    }
}