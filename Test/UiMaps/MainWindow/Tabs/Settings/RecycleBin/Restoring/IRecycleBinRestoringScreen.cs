using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.Restoring
{
    public interface IRecycleBinRestoringScreen
    {
        UiMapItems.DropDownMenu.IDropDownMenu Fall_Back_Account_To_Restore_Emails_DropDownMenu { get; }
        UiMapItems.Button.IButton Save_Button { get; }
        UiMapItems.CheckBox.ICheckBox Automatically_Add_Sender_To_Friends_List_CheckBox { get; }
    }
}