using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.RecycleBin
{
    [TestFixture, Property("UiMap_RecycleBin_Settings", "General_Button")]
    public class Tests_RecycleBinSettingsScreen_General_Button : Button_Verification
    {
        public Tests_RecycleBinSettingsScreen_General_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.General_Button)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_Settings", "Restoring_Button")]
    public class Tests_RecycleBinSettingsScreen_Restoring_Button : Button_Verification
    {
        public Tests_RecycleBinSettingsScreen_Restoring_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring_Button)
        { }
    }
}