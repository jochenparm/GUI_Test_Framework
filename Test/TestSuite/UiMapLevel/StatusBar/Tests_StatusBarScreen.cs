﻿using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.StatusBar
{
    [TestFixture, Property("UiMap_StatusBar", "MailStatus_TextLabel")]
    public class Tests_StatusBarScreen_MailStatus_TextLabel : TextLabel_Verification
    {
        public Tests_StatusBarScreen_MailStatus_TextLabel()
            : base(null,
                  () => MailWasher.UiMap.MainWindow.StatusBar.MailStatus_TextLabel)
        { }
    }

    [TestFixture, Property("UiMap_StatusBar", "DeleteStatus_Button")]
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

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}