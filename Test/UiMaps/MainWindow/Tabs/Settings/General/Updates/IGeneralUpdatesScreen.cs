using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Updates
{
    public interface IGeneralUpdatesScreen
    {
        UiMapItems.CheckBox.ICheckBox Automatically_Check_For_Update_CheckBox { get; }
        UiMapItems.Button.IButton Save_Button { get; }
        UiMapItems.TextBox.ITextBox Download_Path_TextBox { get; }
        UiMapItems.TextBox.ITextBox Update_Frequency_TextBox { get; }
    }
}