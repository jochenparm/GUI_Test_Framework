using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Menu.View
{
    [TestFixture, Property("UiMap_View_Menu", "Preview_Pane_CheckBox")]
    public class Tests_ViewMenuScreen_PreviewPane_CheckBox : CheckBox_Verification
    {
        public Tests_ViewMenuScreen_PreviewPane_CheckBox()
            : base(() => MailWasher.Navigator.Menu.View.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.View.Preview_Pane_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_View_Menu", "Side_Bar_CheckBox")]
    public class Tests_ViewMenuScreen_SideBar_CheckBox : CheckBox_Verification
    {
        public Tests_ViewMenuScreen_SideBar_CheckBox()
            : base(() => MailWasher.Navigator.Menu.View.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.View.Side_Bar_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_View_Menu", "Always_Show_Event_Log_CheckBox")]
    public class Tests_ViewMenuScreen_AlwaysShowEventLog_CheckBox : CheckBox_Verification
    {
        public Tests_ViewMenuScreen_AlwaysShowEventLog_CheckBox()
            : base(() => MailWasher.Navigator.Menu.View.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.View.Always_Show_Event_Log_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_View_Menu", "Show_Hidden_Emails_CheckBox")]
    public class Tests_ViewMenuScreen_ShowHiddenEmails_CheckBox : CheckBox_Verification
    {
        public Tests_ViewMenuScreen_ShowHiddenEmails_CheckBox()
            : base(() => MailWasher.Navigator.Menu.View.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.View.Show_Hidden_Emails_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_View_Menu", "Preview_Pane_Graphic_CheckBox")]
    public class Tests_ViewMenuScreen_PreviewPaneGraphic_CheckBox : CheckBox_Verification
    {
        public Tests_ViewMenuScreen_PreviewPaneGraphic_CheckBox()
            : base(() => MailWasher.Navigator.Menu.View.Navigate(),
                  () => MailWasher.Main.Menu.View.Preview_Pane(true),
                  () => MailWasher.UiMap.MainWindow.Menu.View.Preview_Pane_Graphic_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_View_Menu", "Tutorial_Video_Button")]
    public class Tests_ViewMenuScreen_TutorialVideo_Button : Button_Verification
    {
        public Tests_ViewMenuScreen_TutorialVideo_Button()
            : base(() => MailWasher.Navigator.Menu.View.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.View.Tutorial_Video_Button)
        { }
    }
}