using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Outgoing
{
    public interface IAccountsOutgoingScreen
    {
        UiMapItems.TextBox.ITextBox SMTP_Server_Address_TextBox { get; }
        UiMapItems.TextBox.ITextBox Server_Port_Number_TextBox { get; }
        UiMapItems.TextBox.ITextBox Username_TextBox { get; }
        UiMapItems.TextBox.ITextBox Password_TextBox { get; }
        UiMapItems.CheckBox.ICheckBox SMTP_Server_Requires_Authentication_CheckBox { get; }
        UiMapItems.Button.IButton Advanced_Button { get; }
        UiMapItems.Button.IButton Restore_Default_Button { get; }
        UiMapItems.Button.IButton Save_Button { get; }
        UiMapItems.DropDownMenu.IDropDownMenu Secure_Connection_DropDownMenu { get; }
        UiMapItems.RadioButton.IRadioButton Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton { get; }
        UiMapItems.RadioButton.IRadioButton Use_The_Following_Login_RadioButton { get; }
    }
}