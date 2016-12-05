using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Menu.Help
{
    [TestFixture, Property("UiMap_Help_Menu", "Help_Topics_Button")]
    public class Tests_HelpMenuScreen_Help_Topics_Button : Button_Verification
    {
        public Tests_HelpMenuScreen_Help_Topics_Button()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.Help_Topics_Button)
        { }
    }

    [TestFixture, Property("UiMap_Help_Menu", "Forums_Button")]
    public class Tests_HelpMenuScreen_Forums_Button : Button_Verification
    {
        public Tests_HelpMenuScreen_Forums_Button()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.Forums_Button)
        { }
    }

    [TestFixture, Property("UiMap_Help_Menu", "Tell_A_Friend_Button")]
    public class Tests_HelpMenuScreen_Tell_A_Friend_Button : Button_Verification
    {
        public Tests_HelpMenuScreen_Tell_A_Friend_Button()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.Tell_A_Friend_Button)
        { }
    }

    [TestFixture, Property("UiMap_Help_Menu", "Registration_Button")]
    public class Tests_HelpMenuScreen_Registration_Button : Button_Verification
    {
        public Tests_HelpMenuScreen_Registration_Button()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.Registration_Button)
        { }
    }

    [TestFixture, Property("UiMap_Help_Menu", "User_Files_Button")]
    public class Tests_HelpMenuScreen_User_Files_Button : Button_Verification
    {
        public Tests_HelpMenuScreen_User_Files_Button()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.User_Files_Button)
        { }
    }

    [TestFixture, Property("UiMap_Help_Menu", "Common_Files_Button")]
    public class Tests_HelpMenuScreen_Common_Files_Button : Button_Verification
    {
        public Tests_HelpMenuScreen_Common_Files_Button()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.Common_Files_Button)
        { }
    }

    [TestFixture, Property("UiMap_Help_Menu", "Send_Support_Logs_Button")]
    public class Tests_HelpMenuScreen_Send_Support_Logs_Button : Button_Verification
    {
        public Tests_HelpMenuScreen_Send_Support_Logs_Button()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.Send_Support_Logs_Button)
        { }
    }

    [TestFixture, Property("UiMap_Help_Menu", "Check_For_Updates_Button")]
    public class Tests_HelpMenuScreen_Check_For_Updates_Button : Button_Verification
    {
        public Tests_HelpMenuScreen_Check_For_Updates_Button()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.Check_For_Updates_Button)
        { }
    }

    [TestFixture, Property("UiMap_Help_Menu", "About_Button")]
    public class Tests_HelpMenuScreen_About_Button : Button_Verification
    {
        public Tests_HelpMenuScreen_About_Button()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.About_Button)
        { }
    }

    [TestFixture, Property("UiMap_Help_Menu", "Log_Protocol_CheckBox")]
    public class Tests_HelpMenuScreen_Log_Protocol_CheckBox : CheckBox_Verification
    {
        public Tests_HelpMenuScreen_Log_Protocol_CheckBox()
            : base(() => MailWasher.Navigator.Menu.Help.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Help.Log_Protocol_CheckBox)
        { }
    }
}