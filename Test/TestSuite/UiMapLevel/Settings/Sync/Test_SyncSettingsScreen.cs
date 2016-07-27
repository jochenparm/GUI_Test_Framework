using NUnit.Framework;
using Shouldly;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Sync
{
    [TestFixture, Property("UiMap", "Sync_Settings_UIItems")]
    public class Test_SyncSettingsScreen
    {
        [SetUp]
        public void SetUp()
        {
            UiMap.Init();
            UiMap.MainWindow.SettingsTab_Button.Click();
            UiMap.MainWindow.Tabs.Settings.Sync_Button.Click();
        }

        [Test]
        public void Verify_Account_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Sync.Account_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Mobile_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Sync.Mobile_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            UiMap.DeInit();
        }
    }
}