using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.General.CheckingMail
{
    [TestFixture, Property("UiMap", "General_Settings_Checking_Mail_UIITems")]
    public class Tests_GeneralCheckingMailScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Tabs.Settings.General.Checking_Mail.Navigate();
        }

        [Test]
        public void Verify_Spam_Throttle_Slider_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Spam_Throttle_Slider.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Check_Throttle_Slider_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Check_Throttle_Slider.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Spam_Throttle_Reset_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Spam_Throttle_Reset_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Check_Throttle_Reset_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Check_Throttle_Reset_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Check_Default_Accounts_When_MailWasher_Starts_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Check_Default_Accounts_When_MailWasher_Starts_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Periodically_Check_Mail_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Periodically_Check_Mail_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Dont_Check_Mail_Between_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Dont_Check_Mail_Between_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Mail_Check_Interval_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail.Mail_Check_Interval_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}