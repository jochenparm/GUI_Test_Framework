using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.StatusBar
{
    [TestFixture, Property("UiMap", "StatusBar_UIItems")]
    public class Tests_StatusBarScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
        }

        [Test]
        public void Verify_DeleteStatus_Button_Is_OffScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.StatusBar.DeleteStatus_Button.IsOnScreen.ShouldBeFalse();
        }

        [Test]
        public void Verify_MailStatus_TextLabel_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.StatusBar.MailStatus_TextLabel.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}