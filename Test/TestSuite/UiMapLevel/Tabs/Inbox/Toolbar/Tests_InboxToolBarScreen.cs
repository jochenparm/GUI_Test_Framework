using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Tabs.Inbox.Toolbar
{
    [TestFixture, Property("UiMap_Inbox_ToolBar", "CheckMail_Button")]
    public class Tests_InboxToolBarScreen_CheckMail_Button : Button_Verification
    {
        public Tests_InboxToolBarScreen_CheckMail_Button()
            : base(() => MailWasher.Navigator.Tabs.Inbox.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.CheckMail_Button)
        { }
    }

    [TestFixture, Property("UiMap_Inbox_ToolBar", "WashMail_Button")]
    public class Tests_InboxToolBarScreen_WashMail_Button : Button_Verification
    {
        public Tests_InboxToolBarScreen_WashMail_Button()
            : base(() => MailWasher.Navigator.Tabs.Inbox.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.WashMail_Button)
        { }
    }

    [TestFixture, Property("UiMap_Inbox_ToolBar", "MailProgram_Button")]
    public class Tests_InboxToolBarScreen_MailProgram_Button : Button_Verification
    {
        public Tests_InboxToolBarScreen_MailProgram_Button()
            : base(() => MailWasher.Navigator.Tabs.Inbox.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.MailProgram_Button)
        { }
    }

    [TestFixture, Property("UiMap_Inbox_ToolBar", "Register_Button")]
    public class Tests_InboxToolBarScreen_Register_Button : Button_Verification
    {
        public Tests_InboxToolBarScreen_Register_Button()
            : base(() => MailWasher.Navigator.Tabs.Inbox.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.Register_Button)
        { }
    }

    [TestFixture, Property("UiMap_Inbox_ToolBar", "SearchInbox_Button")]
    public class Tests_InboxToolBarScreen_SearchInbox_Button : Button_Verification
    {
        public Tests_InboxToolBarScreen_SearchInbox_Button()
            : base(() => MailWasher.Navigator.Tabs.Inbox.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.SearchInbox_Button)
        { }
    }

    [TestFixture, Property("UiMap_Inbox_ToolBar", "DisplayOptions_Button")]
    public class Tests_InboxToolBarScreen_DisplayOptions_Button : Button_Verification
    {
        public Tests_InboxToolBarScreen_DisplayOptions_Button()
            : base(() => MailWasher.Navigator.Tabs.Inbox.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.DisplayOptions_Button)
        { }
    }

    [TestFixture, Property("UiMap_Inbox_ToolBar", "CheckMail_TextLabel")]
    public class Tests_InboxToolBarScreen_CheckMail_TextLabel : TextLabel_Verification
    {
        public Tests_InboxToolBarScreen_CheckMail_TextLabel()
            : base(() => MailWasher.Navigator.Tabs.Inbox.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.CheckMail_TextLabel)
        { }
    }

    [TestFixture, Property("UiMap_Inbox_ToolBar", "CheckMail_DropDownMenu")]
    public class Tests_InboxToolBarScreen_CheckMail_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_InboxToolBarScreen_CheckMail_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.Inbox.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.CheckMail_DropDownMenu)
        { }
    }
}