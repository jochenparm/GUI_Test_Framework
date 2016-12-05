using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.RecycleBin.Restoring
{
    [TestFixture, Property("UiMap_RecycleBin_Settings_Restoring", "Save_Button")]
    public class Tests_RecycleBinRestoringScreen_Save_Button : Button_Verification
    {
        public Tests_RecycleBinRestoringScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.RecycleBin.Restoring.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_Settings_Restoring", "Automatically_Add_Sender_To_Friends_List_CheckBox")]
    public class Tests_RecycleBinRestoringScreen_Automatically_Add_Sender_To_Friends_List_CheckBox : CheckBox_Verification
    {
        public Tests_RecycleBinRestoringScreen_Automatically_Add_Sender_To_Friends_List_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.RecycleBin.Restoring.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring.Automatically_Add_Sender_To_Friends_List_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_Settings_Restoring", "Fall_Back_Account_To_Restore_Emails_DropDownMenu")]
    public class Tests_RecycleBinRestoringScreen_Fall_Back_Account_To_Restore_Emails_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_RecycleBinRestoringScreen_Fall_Back_Account_To_Restore_Emails_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.Settings.RecycleBin.Restoring.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring.Fall_Back_Account_To_Restore_Emails_DropDownMenu)
        { }
    }
}