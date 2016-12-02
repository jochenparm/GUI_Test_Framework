using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Application
{
    public class SettingsGeneralApplication : ISettingsGeneralApplication
    {
        public SettingsGeneralApplication()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application_Button.Click();
        }

        private const string FontIdentifierSegoe = "Segoe UI";

        private const string StartupIdentifierDisable = "None";
        private const string StartupIdentifierEnable = "Launch when Windows starts up";

        private void Select_Font(FontOptions font)
        {
            string fontIdentifier;
            switch(font)
            {
                case FontOptions.Segoe:
                    fontIdentifier = FontIdentifierSegoe;
                    break;

                default:
                    fontIdentifier = font.ToString();
                    break;
            }
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Font_DropDownMenu.Select(fontIdentifier);
        }

        ISettingsGeneralApplication ISettingsGeneralApplication.Select_Font(FontOptions font)
        {
            this.Select_Font(font);
            return this;
        }

        private void Startup_With_Windows(bool enable)
        {
            string startupIdentifier;
            if(enable)
            {
                startupIdentifier = StartupIdentifierEnable;
            }
            else
            {
                startupIdentifier = StartupIdentifierDisable;
            }
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Startup_DropDownMenu.Select(startupIdentifier);
        }

        ISettingsGeneralApplication ISettingsGeneralApplication.Startup_With_Windows(bool enable)
        {
            this.Startup_With_Windows(enable);
            return this;
        }

        private void Minimize_MailWasher_When_X_Clicked(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_MailWasher_When_X_Clicked_CheckBox.Set(enable);
        }

        ISettingsGeneralApplication ISettingsGeneralApplication.Minimize_MailWasher_When_X_Clicked(bool enable)
        {
            this.Minimize_MailWasher_When_X_Clicked(enable);
            return this;
        }

        private void Minimize_MailWasher_When_Mail_Program_Launched(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_MailWasher_When_Mail_Program_Launched_CheckBox.Set(enable);
        }

        ISettingsGeneralApplication ISettingsGeneralApplication.Minimize_MailWasher_When_Mail_Program_Launched(bool enable)
        {
            this.Minimize_MailWasher_When_Mail_Program_Launched(enable);
            return this;
        }

        private void Start_MailWasher_Minimized(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Start_MailWasher_Minimized_CheckBox.Set(enable);
        }

        ISettingsGeneralApplication ISettingsGeneralApplication.Start_MailWasher_Minimized(bool enable)
        {
            this.Start_MailWasher_Minimized(enable);
            return this;
        }

        private void Minimize_MailWasher_To(MinimizeDestinations destination)
        {
            switch(destination)
            {
                case MinimizeDestinations.System_Tray:
                    MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_To_System_Tray_RadioButton.Select();
                    break;

                case MinimizeDestinations.Task_Bar:
                    MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_To_Task_Bar_RadioButton.Select();
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        ISettingsGeneralApplication ISettingsGeneralApplication.Minimize_MailWasher_To(MinimizeDestinations destination)
        {
            this.Minimize_MailWasher_To(destination);
            return this;
        }

        private void Save()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Save_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Save_Button.Click();
            }
        }

        ISettingsGeneralApplication ISettingsGeneralApplication.Save()
        {
            this.Save();
            return this;
        }

        private void Reset_MailWasher_HotKey()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Reset_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Reset_Button.Click();
            }
        }

        ISettingsGeneralApplication ISettingsGeneralApplication.Reset_MailWasher_HotKey()
        {
            this.Reset_MailWasher_HotKey();
            return this;
        }
    }
}