using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.RecycleBin.General
{
    [TestFixture, Property("UiMap_RecycleBin_Settings_General", "Save_Button")]
    public class Tests_RecycleBinGeneralScreen_Save_Button : Button_Verification
    {
        public Tests_RecycleBinGeneralScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.RecycleBin.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.General.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_Settings_General", "Deleted_Email_Storage_Duration_Slider")]
    public class Tests_RecycleBinGeneralScreen_Deleted_Email_Storage_Duration_Slider : Slider_Verification
    {
        public Tests_RecycleBinGeneralScreen_Deleted_Email_Storage_Duration_Slider()
            : base(() => MailWasher.Navigator.Tabs.Settings.RecycleBin.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.General.Deleted_Email_Storage_Duration_Slider, 0, 60)
        { }
    }
}