using NUnit.Framework;
using Shouldly;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel
{
    [TestFixture, Property("UiMap", "InboxTabScreen_Toolbar_UIItems")]
    public class Tests_InboxTabScreen_Toolbar
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Tabs.Inbox.Navigate();
        }

        [Test]
        public void Verify_CheckMail_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.CheckMail_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_DisplayOptions_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.DisplayOptions_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_MailProgram_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.MailProgram_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_SearchInbox_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.SearchInbox_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_WashMail_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.WashMail_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}