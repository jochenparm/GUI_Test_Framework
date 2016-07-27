using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Application
{
    public interface IGeneralApplicationScreen
    {
        UiMapItems.DropDownMenu.IDropDownMenu Language_DropDownMenu { get; }
        UiMapItems.DropDownMenu.IDropDownMenu Font_DropDownMenu { get; }
        UiMapItems.DropDownMenu.IDropDownMenu Startup_DropDownMenu { get; }
        UiMapItems.CheckBox.ICheckBox Minimize_MailWasher_When_X_Clicked_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Minimize_MailWasher_When_Mail_Program_Launched_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Start_MailWasher_Minimized_CheckBox { get; }
        UiMapItems.RadioButton.IRadioButton Minimize_To_System_Tray_RadioButton { get; }
        UiMapItems.RadioButton.IRadioButton Minimize_To_Task_Bar_RadioButton { get; }
        UiMapItems.Button.IButton Save_Button { get; }
        UiMapItems.Button.IButton Reset_Button { get; }
        UiMapItems.TextBox.ITextBox Restore_MailWasher_Hotkey_TextBox { get; }
    }
}