using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.General.Performance
{
    [TestFixture, Property("UiMap", "General_Settings_Performance_UIITems")]
    public class Tests_GeneralPerformanceScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate();
        }

        [Test]
        public void Verify_Use_Low_Quality_Animation_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Use_Low_Quality_Animation_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Enable_Fast_Scrolling_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Enable_Fast_Scrolling_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Collapse_Group_Header_On_Check_Mail_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Collapse_Group_Header_On_Check_Mail_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Enable_For_Screenreaders_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Enable_For_Screenreaders_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Reset_Spam_Throttle_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Reset_Spam_Throttle_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Spam_Throttle_Slider_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Spam_Throttle_Slider.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Maximum_Character_Count_Slider_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Maximum_Character_Count_Slider.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}