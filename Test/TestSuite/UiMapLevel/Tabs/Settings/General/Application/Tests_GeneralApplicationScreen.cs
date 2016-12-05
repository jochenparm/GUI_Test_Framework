using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.General.Application
{
    [TestFixture, Property("UiMap_General_Settings_Application", "Save_Button")]
    public class Tests_GeneralApplicationScreen_Save_Button : Button_Verification
    {
        public Tests_GeneralApplicationScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Reset_Button")]
    public class Tests_GeneralApplicationScreen_Reset_Button : Button_Verification
    {
        public Tests_GeneralApplicationScreen_Reset_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Reset_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Restore_MailWasher_Hotkey_TextBox")]
    public class Tests_GeneralApplicationScreen_Restore_MailWasher_Hotkey_TextBox : TextBox_Verification
    {
        public Tests_GeneralApplicationScreen_Restore_MailWasher_Hotkey_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Restore_MailWasher_Hotkey_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Minimize_To_Task_Bar_RadioButton")]
    public class Tests_GeneralApplicationScreen_Minimize_To_Task_Bar_RadioButton : RadioButton_Verification
    {
        public Tests_GeneralApplicationScreen_Minimize_To_Task_Bar_RadioButton()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_To_Task_Bar_RadioButton)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Minimize_To_System_Tray_RadioButton")]
    public class Tests_GeneralApplicationScreen_Minimize_To_System_Tray_RadioButton : RadioButton_Verification
    {
        public Tests_GeneralApplicationScreen_Minimize_To_System_Tray_RadioButton()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_To_System_Tray_RadioButton)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Start_MailWasher_Minimized_CheckBox")]
    public class Tests_GeneralApplicationScreen_Start_MailWasher_Minimized_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralApplicationScreen_Start_MailWasher_Minimized_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Start_MailWasher_Minimized_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Minimize_MailWasher_When_Mail_Program_Launched_CheckBox")]
    public class Tests_GeneralApplicationScreen_Minimize_MailWasher_When_Mail_Program_Launched_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralApplicationScreen_Minimize_MailWasher_When_Mail_Program_Launched_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_MailWasher_When_Mail_Program_Launched_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Minimize_MailWasher_When_X_Clicked_CheckBox")]
    public class Tests_GeneralApplicationScreen_Minimize_MailWasher_When_X_Clicked_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralApplicationScreen_Minimize_MailWasher_When_X_Clicked_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_MailWasher_When_X_Clicked_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Startup_DropDownMenu")]
    public class Tests_GeneralApplicationScreen_Startup_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_GeneralApplicationScreen_Startup_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Startup_DropDownMenu)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Font_DropDownMenu")]
    public class Tests_GeneralApplicationScreen_Font_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_GeneralApplicationScreen_Font_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Font_DropDownMenu)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Application", "Language_DropDownMenu")]
    public class Tests_GeneralApplicationScreen_Language_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_GeneralApplicationScreen_Language_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Application.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Language_DropDownMenu)
        { }
    }
}