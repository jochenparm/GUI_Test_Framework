using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.RecycleBin.Restoring
{
    [TestFixture, Property("UiMap", "RecycleBin_Settings_Restoring_UIItems")]
    public class Tests_RecycleBinRestoringScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.RecycleBin.Restoring.Navigate();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Fall_Back_Account_To_Restore_Emails_DropDownMenu_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring.Fall_Back_Account_To_Restore_Emails_DropDownMenu.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Automatically_Add_Sender_To_Friends_List_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring.Automatically_Add_Sender_To_Friends_List_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}