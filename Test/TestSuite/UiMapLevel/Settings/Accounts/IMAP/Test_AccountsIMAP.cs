using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts.IMAP
{
    [TestFixture, Property("UiMap", "Accounts_Settings_IMAP_UIITems")]
    public class Test_AccountsIMAP
    {
        [SetUp]
        public void SetUp()
        {
            UiMap.Init();
            UiMap.MainWindow.SettingsTab_Button.Click();
            UiMap.MainWindow.Tabs.Settings.Accounts_Button.Click();
            UiMap.MainWindow.Tabs.Settings.Accounts.IMAP_Button.Click();
        }

        [Test]
        public void Verify_Refresh_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.IMAP.Refresh_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.IMAP.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            UiMap.DeInit();
        }
    }
}