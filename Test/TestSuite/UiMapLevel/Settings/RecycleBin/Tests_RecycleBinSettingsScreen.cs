using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.RecycleBin
{
    [TestFixture, Property("UiMap", "RecycleBin_Settings_UIItems")]
    public class Tests_RecycleBinSettingsScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Tabs.Settings.RecycleBin.Navigate();
        }

        [Test]
        public void Verify_General_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.General_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Restoring_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}