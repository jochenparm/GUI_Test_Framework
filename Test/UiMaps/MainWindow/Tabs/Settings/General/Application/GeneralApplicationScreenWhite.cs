using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Application
{
    public class GeneralApplicationScreenWhite : AppScreen, IGeneralApplicationScreen
    {
        public GeneralApplicationScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.ListBoxItems.ComboBox CmbBxLanguageSelector; // Dropdown menu 'Language'
        private TestStack.White.UIItems.ListBoxItems.ComboBox CmbBxFontSelector; // Dropdown menu 'Font'
        private TestStack.White.UIItems.ListBoxItems.ComboBox CmbBxStartupOption; // Dropdown menu 'Startup'
        private TestStack.White.UIItems.CheckBox ChkBxMinimiseOnClose; // CheckBox 'Minimize MailWasher when X clicked'
        private TestStack.White.UIItems.CheckBox ChkBxMinimiseOnLaunchMail; // CheckBox 'Minimize MailWasher when mail program launched'
        private TestStack.White.UIItems.CheckBox ChkBxStartMinimised; // CheckBox 'Start MailWasher minimized'
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
        private TestStack.White.UIItems.RadioButton RdoBtnMinimiseToTray; // RadioButton 'Minimize to System Tray'
        private TestStack.White.UIItems.RadioButton RdoBtnMinimiseToTaskbar; // RadioButton 'Minimize to Task Bar'
        private TestStack.White.UIItems.TextBox TxtBxRestoreHotKey; //TextBox 'Restore MailWasher Hotkey'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning
        private readonly string ResetButtonText = "Reset";

        private UiMapItems.DropDownMenu.IDropDownMenu Language_DropDownMenu
        {
            get
            {
                return new UiMapItems.DropDownMenu.DropDownMenuWhite(this.CmbBxLanguageSelector);
            }
        }

        UiMapItems.DropDownMenu.IDropDownMenu IGeneralApplicationScreen.Language_DropDownMenu
        {
            get
            {
                return this.Language_DropDownMenu;
            }
        }

        private UiMapItems.DropDownMenu.IDropDownMenu Font_DropDownMenu
        {
            get
            {
                return new UiMapItems.DropDownMenu.DropDownMenuWhite(this.CmbBxFontSelector);
            }
        }

        UiMapItems.DropDownMenu.IDropDownMenu IGeneralApplicationScreen.Font_DropDownMenu
        {
            get
            {
                return this.Font_DropDownMenu;
            }
        }

        private UiMapItems.DropDownMenu.IDropDownMenu Startup_DropDownMenu
        {
            get
            {
                return new UiMapItems.DropDownMenu.DropDownMenuWhite(this.CmbBxStartupOption);
            }
        }

        UiMapItems.DropDownMenu.IDropDownMenu IGeneralApplicationScreen.Startup_DropDownMenu
        {
            get
            {
                return this.Startup_DropDownMenu;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Minimize_MailWasher_When_X_Clicked_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxMinimiseOnClose);
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralApplicationScreen.Minimize_MailWasher_When_X_Clicked_CheckBox
        {
            get
            {
                return this.Minimize_MailWasher_When_X_Clicked_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Minimize_MailWasher_When_Mail_Program_Launched_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxMinimiseOnLaunchMail);
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralApplicationScreen.Minimize_MailWasher_When_Mail_Program_Launched_CheckBox
        {
            get
            {
                return this.Minimize_MailWasher_When_Mail_Program_Launched_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Start_MailWasher_Minimized_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxStartMinimised);
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralApplicationScreen.Start_MailWasher_Minimized_CheckBox
        {
            get
            {
                return this.Start_MailWasher_Minimized_CheckBox;
            }
        }

        private UiMapItems.RadioButton.IRadioButton Minimize_To_System_Tray_RadioButton
        {
            get
            {
                return new UiMapItems.RadioButton.RadioButtonWhite(this.RdoBtnMinimiseToTray);
            }
        }

        UiMapItems.RadioButton.IRadioButton IGeneralApplicationScreen.Minimize_To_System_Tray_RadioButton
        {
            get
            {
                return this.Minimize_To_System_Tray_RadioButton;
            }
        }

        private UiMapItems.RadioButton.IRadioButton Minimize_To_Task_Bar_RadioButton
        {
            get
            {
                return new UiMapItems.RadioButton.RadioButtonWhite(this.RdoBtnMinimiseToTaskbar);
            }
        }

        UiMapItems.RadioButton.IRadioButton IGeneralApplicationScreen.Minimize_To_Task_Bar_RadioButton
        {
            get
            {
                return this.Minimize_To_Task_Bar_RadioButton;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnSave);
            }
        }

        UiMapItems.Button.IButton IGeneralApplicationScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }

        private UiMapItems.Button.IButton Reset_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.Window.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText(this.ResetButtonText)));
            }
        }

        UiMapItems.Button.IButton IGeneralApplicationScreen.Reset_Button
        {
            get
            {
                return this.Reset_Button;
            }
        }

        private UiMapItems.TextBox.ITextBox Restore_MailWasher_Hotkey_TextBox
        {
            get
            {
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxRestoreHotKey);
            }
        }

        UiMapItems.TextBox.ITextBox IGeneralApplicationScreen.Restore_MailWasher_Hotkey_TextBox
        {
            get
            {
                return this.Restore_MailWasher_Hotkey_TextBox;
            }
        }
    }
}