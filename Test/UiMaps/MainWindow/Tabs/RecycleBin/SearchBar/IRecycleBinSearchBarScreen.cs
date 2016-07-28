using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.RecycleBin.SearchBar
{
    public interface IRecycleBinSearchBarScreen
    {
        UiMapItems.TextBox.ITextBox Search_TextBox { get; }
        UiMapItems.Button.IButton Clear_Search_Button { get; }
        UiMapItems.DropDownMenu.IDropDownMenu Time_Window_DropDownMenu { get; }
        UiMapItems.TextLabel.ITextLabel Number_Of_Emails_Displayed_TextLabel { get; }
    }
}