using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Tabs.RecycleBin.ToolBar
{
    [TestFixture, Property("UiMap_RecycleBin_ToolBar", "Restore_Button")]
    public class Tests_RecycleBinToolBarScreen_Restore_Button : Button_Verification
    {
        public Tests_RecycleBinToolBarScreen_Restore_Button()
            : base(() => MailWasher.Navigator.Tabs.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.Restore_Button)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_ToolBar", "EmptyBin_Button")]
    public class Tests_RecycleBinToolBarScreen_EmptyBin_Button : Button_Verification
    {
        public Tests_RecycleBinToolBarScreen_EmptyBin_Button()
            : base(() => MailWasher.Navigator.Tabs.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.EmptyBin_Button)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_ToolBar", "DisplayOption_Button")]
    public class Tests_RecycleBinToolBarScreen_DisplayOption_Button : Button_Verification
    {
        public Tests_RecycleBinToolBarScreen_DisplayOption_Button()
            : base(() => MailWasher.Navigator.Tabs.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.DisplayOption_Button)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_ToolBar", "ShowAllEmailLogged_CheckBox")]
    public class Tests_RecycleBinToolBarScreen_ShowAllEmailLogged_CheckBox : CheckBox_Verification
    {
        public Tests_RecycleBinToolBarScreen_ShowAllEmailLogged_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.ShowAllEmailLogged_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_RecycleBin_ToolBar", "HideAutodeletedEmails_CheckBox")]
    public class Tests_RecycleBinToolBarScreen_HideAutodeletedEmails_CheckBox : CheckBox_Verification
    {
        public Tests_RecycleBinToolBarScreen_HideAutodeletedEmails_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.RecycleBin.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.RecycleBin.ToolBar.HideAutodeletedEmails_CheckBox)
        { }
    }
}