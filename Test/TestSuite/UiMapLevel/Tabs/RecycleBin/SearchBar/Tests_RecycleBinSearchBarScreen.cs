using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Tabs.RecycleBin.SearchBar
{
    [TestFixture, Property("UiMap", "RecycleBinTabScreen_SearchBar_UIItems")]
    public class Tests_RecycleBinSearchBarScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Tabs.RecycleBin.Navigate();
        }

        [Test]
        public void Verify_Search_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Search_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Clear_Search_Button_Is_OffScreen_Before_Filling_In_Search_TextBox()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Clear_Search_Button.IsOnScreen.ShouldBeFalse();
        }

        [Test]
        public void Verify_Clear_Search_Button_Is_OnScreen_After_Filling_In_Search_TextBox()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Search_TextBox.Content = "test";
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Clear_Search_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Time_Window_DropDownMenu_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Time_Window_DropDownMenu.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Number_Of_Emails_Displayed_TextLabel_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.SearchBar.Number_Of_Emails_Displayed_TextLabel.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}