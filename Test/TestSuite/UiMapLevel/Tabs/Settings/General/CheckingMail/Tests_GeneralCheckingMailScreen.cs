using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.General.CheckingMail
{
    [TestFixture, Property("UiMap_General_Settings_Checking_Mail", "Save_Button")]
    public class Tests_GeneralCheckingMailScreen_Save_Button : Button_Verification
    {
        public Tests_GeneralCheckingMailScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Checking_Mail", "Spam_Throttle_Reset_Button")]
    public class Tests_GeneralCheckingMailScreen_Spam_Throttle_Reset_Button : Button_Verification
    {
        public Tests_GeneralCheckingMailScreen_Spam_Throttle_Reset_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Spam_Throttle_Reset_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Checking_Mail", "Check_Throttle_Reset_Button")]
    public class Tests_GeneralCheckingMailScreen_Check_Throttle_Reset_Button : Button_Verification
    {
        public Tests_GeneralCheckingMailScreen_Check_Throttle_Reset_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Check_Throttle_Reset_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Checking_Mail", "Check_Throttle_Slider")]
    public class Tests_GeneralCheckingMailScreen_Check_Throttle_Slider : Slider_Verification
    {
        public Tests_GeneralCheckingMailScreen_Check_Throttle_Slider()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Check_Throttle_Slider, 1, 10)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Checking_Mail", "Spam_Throttle_Slider")]
    public class Tests_GeneralCheckingMailScreen_Spam_Throttle_Slider : Slider_Verification
    {
        public Tests_GeneralCheckingMailScreen_Spam_Throttle_Slider()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Spam_Throttle_Slider, 0, 51)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Checking_Mail", "Check_Default_Accounts_When_MailWasher_Starts_CheckBox")]
    public class Tests_GeneralCheckingMailScreen_Check_Default_Accounts_When_MailWasher_Starts_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralCheckingMailScreen_Check_Default_Accounts_When_MailWasher_Starts_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Check_Default_Accounts_When_MailWasher_Starts_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Checking_Mail", "Periodically_Check_Mail_CheckBox")]
    public class Tests_GeneralCheckingMailScreen_Periodically_Check_Mail_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralCheckingMailScreen_Periodically_Check_Mail_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Periodically_Check_Mail_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Checking_Mail", "Dont_Check_Mail_Between_CheckBox")]
    public class Tests_GeneralCheckingMailScreen_Dont_Check_Mail_Between_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralCheckingMailScreen_Dont_Check_Mail_Between_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Dont_Check_Mail_Between_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Checking_Mail", "Mail_Check_Interval_TextBox")]
    public class Tests_GeneralCheckingMailScreen_Mail_Check_Interval_TextBox : TextBox_Verification
    {
        public Tests_GeneralCheckingMailScreen_Mail_Check_Interval_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Mail_Check_Interval_TextBox)
        { }
    }
}