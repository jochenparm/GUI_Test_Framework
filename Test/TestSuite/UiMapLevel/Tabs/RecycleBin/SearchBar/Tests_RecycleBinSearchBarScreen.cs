using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Tabs.RecycleBin.SearchBar
{
    [TestFixture, Property("UiMap_RecycleBin_SearchBar", "Clear_Search_Button")]
    public class Tests_RecycleBinSearchBarScreen_Clear_Search_Button : Button_Verification
    {
        public Tests_RecycleBinSearchBarScreen_Clear_Search_Button()
            : base(() => MailWasher.Navigator.Tabs.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Clear_Search_Button)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_SearchBar", "Search_TextBox")]
    public class Tests_RecycleBinSearchBarScreen_Search_TextBox : TextBox_Verification
    {
        public Tests_RecycleBinSearchBarScreen_Search_TextBox()
            : base(() => MailWasher.Navigator.Tabs.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Search_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_SearchBar", "Time_Window_DropDownMenu")]
    public class Tests_RecycleBinSearchBarScreen_Time_Window_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_RecycleBinSearchBarScreen_Time_Window_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Time_Window_DropDownMenu)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_SearchBar", "Number_Of_Emails_Displayed_TextLabel")]
    public class Tests_RecycleBinSearchBarScreen_Number_Of_Emails_Displayed_TextLabel : TextLabel_Verification
    {
        public Tests_RecycleBinSearchBarScreen_Number_Of_Emails_Displayed_TextLabel()
            : base(() => MailWasher.Navigator.Tabs.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Number_Of_Emails_Displayed_TextLabel)
        { }
    }
}