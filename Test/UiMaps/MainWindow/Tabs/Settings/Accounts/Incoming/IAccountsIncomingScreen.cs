using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Incoming
{
    public interface IAccountsIncomingScreen
    {
        UiMapItems.TextBox.ITextBox Server_Address_TextBox { get; }
        UiMapItems.TextBox.ITextBox User_Name_TextBox { get; }
        UiMapItems.TextBox.ITextBox Password_TextBox { get; }
        UiMapItems.TextBox.ITextBox Server_Port_Number_TextBox { get; }
        UiMapItems.CheckBox.ICheckBox Store_Cached_Emails_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox This_Server_Requires_A_Secure_Connection_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Use_OAUTH_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Download_Read_Emails_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Move_Deleted_Messages_Into_Folder_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Remember_Password_CheckBox { get; }
        UiMapItems.Button.IButton Advanced_Button { get; }
        UiMapItems.Button.IButton Save_Button { get; }
        UiMapItems.DropDownMenu.IDropDownMenu Server_Type_DropDownMenu { get; }
        UiMapItems.DropDownMenu.IDropDownMenu Destination_Folder_DropDownMenu { get; }
    }
}