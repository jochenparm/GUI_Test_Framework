using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.General.WashingMail
{
    [TestFixture, Property("UiMap_General_Settings_WashingMail", "Save_Button")]
    public class Tests_GeneralWashingMailScreen_Save_Button : Button_Verification
    {
        public Tests_GeneralWashingMailScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Washing_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_WashingMail", "Email_Program_Path_TextBox")]
    public class Tests_GeneralWashingMailScreen_Email_Program_Path_TextBox : TextBox_Verification
    {
        public Tests_GeneralWashingMailScreen_Email_Program_Path_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Washing_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Email_Program_Path_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_WashingMail", "Email_Program_DropDownMenu")]
    public class Tests_GeneralWashingMailScreen_Email_Program_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_GeneralWashingMailScreen_Email_Program_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Washing_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Email_Program_DropDownMenu)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_WashingMail", "Use_Default_Email_Program_Icon_CheckBox")]
    public class Tests_GeneralWashingMailScreen_Use_Default_Email_Program_Icon_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralWashingMailScreen_Use_Default_Email_Program_Icon_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Washing_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Use_Default_Email_Program_Icon_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_WashingMail", "Launch_Email_Program_After_Wash_Mail_CheckBox")]
    public class Tests_GeneralWashingMailScreen_Launch_Email_Program_After_Wash_Mail_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralWashingMailScreen_Launch_Email_Program_After_Wash_Mail_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Washing_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Launch_Email_Program_After_Wash_Mail_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_WashingMail", "Minimize_MailWasher_After_Wash_Mail_CheckBox")]
    public class Tests_GeneralWashingMailScreen_Minimize_MailWasher_After_Wash_Mail_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralWashingMailScreen_Minimize_MailWasher_After_Wash_Mail_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Washing_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Minimize_MailWasher_After_Wash_Mail_CheckBox)
        { }
    }
}