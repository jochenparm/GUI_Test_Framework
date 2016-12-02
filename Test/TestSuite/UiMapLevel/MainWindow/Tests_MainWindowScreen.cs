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
        public void MainWindow_Verify_Inbox_Tab_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Inbox_Tab.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void MainWindow_Verify_RecycleBin_Tab_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.RecycleBin_Tab.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void MainWindow_Verify_EventLog_Tab_Isnt_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.EventLog_Tab.IsOnScreen.ShouldBeFalse();
        }

        [Test]
        public void MainWindow_Verify_Settings_Tab_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Settings_Tab.IsOnScreen.ShouldBeTrue();
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