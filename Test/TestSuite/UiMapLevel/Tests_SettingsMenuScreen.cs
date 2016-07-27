using NUnit.Framework;
using Shouldly;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel
{
    [TestFixture, Property("UiMap", "Settings_Menu_UIItems")]
    public class Tests_SettingsMenuScreen
    {
        [SetUp]
        public void SetUp()
        {
            UiMap.Init();
            UiMap.MainWindow.SettingsTab_Button.Click();
        }

        [Test]
        public void Verify_General_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.General_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Accounts_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Display_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Display_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_RecycleBin_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.RecycleBin_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_SpamTools_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.SpamTools_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Sync_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Sync_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            UiMap.DeInit();
        }
    }
}