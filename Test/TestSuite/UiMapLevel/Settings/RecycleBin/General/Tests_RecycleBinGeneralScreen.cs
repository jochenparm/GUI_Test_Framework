using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.RecycleBin.General
{
    [TestFixture, Property("UiMap", "RecycleBin_Settings_General_UIItems")]
    public class Tests_RecycleBinGeneralScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Tabs.Settings.RecycleBin.General.Navigate();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.General.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Deleted_Email_Storage_Duration_Slider_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.General.Deleted_Email_Storage_Duration_Slider.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}