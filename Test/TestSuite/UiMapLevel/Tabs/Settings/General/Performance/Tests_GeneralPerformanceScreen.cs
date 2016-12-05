using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.General.Performance
{
    [TestFixture, Property("UiMap_General_Settings_Performance", "Save_Button")]
    public class Tests_GeneralPerformanceScreen_Save_Button : Button_Verification
    {
        public Tests_GeneralPerformanceScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Performance", "Reset_Spam_Throttle_Button")]
    public class Tests_GeneralPerformanceScreen_Reset_Spam_Throttle_Button : Button_Verification
    {
        public Tests_GeneralPerformanceScreen_Reset_Spam_Throttle_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Reset_Spam_Throttle_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Performance", "Spam_Throttle_Slider")]
    public class Tests_GeneralPerformanceScreen_Spam_Throttle_Slider : Slider_Verification
    {
        public Tests_GeneralPerformanceScreen_Spam_Throttle_Slider()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Spam_Throttle_Slider, 0, 51)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Performance", "Maximum_Character_Count_Slider")]
    public class Tests_GeneralPerformanceScreen_Maximum_Character_Count_Slider : Slider_Verification
    {
        public Tests_GeneralPerformanceScreen_Maximum_Character_Count_Slider()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Maximum_Character_Count_Slider, 100, 2000)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Performance", "Enable_For_Screenreaders_CheckBox")]
    public class Tests_GeneralPerformanceScreen_Enable_For_Screenreaders_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralPerformanceScreen_Enable_For_Screenreaders_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Enable_For_Screenreaders_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Performance", "Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox")]
    public class Tests_GeneralPerformanceScreen_Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralPerformanceScreen_Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Performance", "Collapse_Group_Header_On_Check_Mail_CheckBox")]
    public class Tests_GeneralPerformanceScreen_Collapse_Group_Header_On_Check_Mail_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralPerformanceScreen_Collapse_Group_Header_On_Check_Mail_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Collapse_Group_Header_On_Check_Mail_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Performance", "Enable_Fast_Scrolling_CheckBox")]
    public class Tests_GeneralPerformanceScreen_Enable_Fast_Scrolling_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralPerformanceScreen_Enable_Fast_Scrolling_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Enable_Fast_Scrolling_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Performance", "Use_Low_Quality_Animation_CheckBox")]
    public class Tests_GeneralPerformanceScreen_Use_Low_Quality_Animation_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralPerformanceScreen_Use_Low_Quality_Animation_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Performance.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Use_Low_Quality_Animation_CheckBox)
        { }
    }
}