using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.General
{
    [TestFixture, Property("UiMap", "General_Settings_UIItems")]
    public class Test_GeneralSettingsScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.General.Navigate();
        }

        [Test]
        public void Verify_Application_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Checking_Mail_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Notifications_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Washing_Mail_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Performance_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Updates_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}