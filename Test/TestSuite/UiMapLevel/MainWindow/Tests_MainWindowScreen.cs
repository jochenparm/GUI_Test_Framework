using NUnit.Framework;
using Shouldly;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.MainWindow
{
    [TestFixture, Property("UiMap", "MainWindow_UIItems")]
    public class Tests_MainWindowScreen_Buttons
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
        }

        [Test]
        public void MainWindow_Verify_InboxTab_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.InboxTab_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void MainWindow_Verify_RecycleBinTab_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.RecycleBinTab_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void MainWindow_Verify_EventLogTab_Button_Isnt_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.EventLogTab_Button.IsOnScreen.ShouldBeFalse();
        }

        [Test]
        public void MainWindow_Verify_SettingsTab_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.SettingsTab_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void MainWindow_Verify_MinimizeWindow_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.MinimizeWindow_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void MainWindow_Verify_MaximizeWindow_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.MaximizeWindow_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void MainWindow_Verify_CloseWindow_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.CloseWindow_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}