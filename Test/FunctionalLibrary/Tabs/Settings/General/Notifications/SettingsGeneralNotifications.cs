using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Notifications
{
    public class SettingsGeneralNotifications : ISettingsGeneralNotifications
    {
        public SettingsGeneralNotifications()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications_Button.Click();
        }

        private void Display_Balloon_Notifications_When_New_Mail_Arrives(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox.Set(enable);
        }

        ISettingsGeneralNotifications ISettingsGeneralNotifications.Display_Balloon_Notifications_When_New_Mail_Arrives(bool enable)
        {
            this.Display_Balloon_Notifications_When_New_Mail_Arrives(enable);
            return this;
        }

        private void Dont_Notify_Me_When_Mail_Is_Spam(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Dont_Notify_Me_When_Mail_Is_Spam_CheckBox.Set(enable);
        }

        ISettingsGeneralNotifications ISettingsGeneralNotifications.Dont_Notify_Me_When_Mail_Is_Spam(bool enable)
        {
            this.Dont_Notify_Me_When_Mail_Is_Spam(enable);
            return this;
        }

        private void Play_Sound_When_Error_Occurs(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Play_Sound_When_Error_Occurs_CheckBox.Set(enable);
        }

        ISettingsGeneralNotifications ISettingsGeneralNotifications.Play_Sound_When_Error_Occurs(bool enable)
        {
            this.Play_Sound_When_Error_Occurs(enable);
            return this;
        }

        private void Play_Sound_When_New_Mail_Arrives(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Play_Sound_When_New_Mail_Arrives_CheckBox.Set(enable);
        }

        ISettingsGeneralNotifications ISettingsGeneralNotifications.Play_Sound_When_New_Mail_Arrives(bool enable)
        {
            this.Play_Sound_When_New_Mail_Arrives(enable);
            return this;
        }

        private void Save()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Save_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Save_Button.Click();
            }
        }

        ISettingsGeneralNotifications ISettingsGeneralNotifications.Save()
        {
            this.Save();
            return this;
        }

        private void Set_Display_Duration(int seconds)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Display_Duration_Slider.Value = seconds;
        }

        ISettingsGeneralNotifications ISettingsGeneralNotifications.Set_Display_Duration(int seconds)
        {
            this.Set_Display_Duration(seconds);
            return this;
        }
    }
}