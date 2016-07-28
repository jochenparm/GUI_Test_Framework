using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Tabs.RecycleBin.ToolBar
{
    [TestFixture, Property("UiMap", "RecycleBinTabScreen_ToolBar_UIItems")]
    public class Tests_RecycleBinToolBarScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.RecycleBin.Navigate();
        }

        [Test]
        public void Verify_Restore_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.Restore_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_EmptyBin_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.EmptyBin_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_DisplayOption_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.DisplayOption_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_ShowAllEmailLogged_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.ShowAllEmailLogged_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_HideAutodeletedEmails_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.HideAutodeletedEmails_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}