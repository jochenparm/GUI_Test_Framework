using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.General
{
    public interface IAccountsGeneralScreen
    {
        UiMapItems.TextBox.ITextBox Account_Description_TextBox { get; }
        UiMapItems.TextBox.ITextBox Email_Address_TextBox { get; }
        UiMapItems.CheckBox.ICheckBox Include_In_Default_Mail_Check_CheckBox { get; }
        UiMapItems.Button.IButton Save_Button { get; }
    }
}