using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.WashingMail
{
    public interface IGeneralWashingMailScreen
    {
        UiMapItems.CheckBox.ICheckBox Minimize_MailWasher_After_Wash_Mail_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Launch_Email_Program_After_Wash_Mail_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Use_Default_Email_Program_Icon_CheckBox { get; }
        UiMapItems.DropDownMenu.IDropDownMenu Email_Program_DropDownMenu { get; }
        UiMapItems.TextBox.ITextBox Email_Program_Path_TextBox { get; }
        UiMapItems.Button.IButton Save_Button { get; }
    }
}