using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.General.Updates
{
    [TestFixture, Property("UiMap_General_Settings_Updates", "Save_Button")]
    public class Tests_GeneralUpdatesScreen_Save_Button : Button_Verification
    {
        public Tests_GeneralUpdatesScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Updates.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Updates", "Automatically_Check_For_Update_CheckBox")]
    public class Tests_GeneralUpdatesScreen_Automatically_Check_For_Update_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralUpdatesScreen_Automatically_Check_For_Update_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Updates.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Automatically_Check_For_Update_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Updates", "Download_Path_TextBox")]
    public class Tests_GeneralUpdatesScreen_Download_Path_TextBox : TextBox_Verification
    {
        public Tests_GeneralUpdatesScreen_Download_Path_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Updates.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Download_Path_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Updates", "Update_Frequency_TextBox")]
    public class Tests_GeneralUpdatesScreen_Update_Frequency_TextBox : TextBox_Verification
    {
        public Tests_GeneralUpdatesScreen_Update_Frequency_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Updates.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Update_Frequency_TextBox)
        { }
    }
}