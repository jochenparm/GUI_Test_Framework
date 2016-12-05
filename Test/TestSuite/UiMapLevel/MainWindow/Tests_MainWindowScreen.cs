using NUnit.Framework;
using Shouldly;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.MainWindow
{
    [TestFixture, Property("UiMap_MainWindow", "MinimizeWindow_Button")]
    public class Tests_MainWindowScreen_MinimizeWindow_Button : Button_Verification
    {
        public Tests_MainWindowScreen_MinimizeWindow_Button()
            : base(() => null,
                  () => MailWasher.UiMap.MainWindow.MinimizeWindow_Button)
        { }
    }

    [TestFixture, Property("UiMap_MainWindow", "MaximizeWindow_Button")]
    public class Tests_MainWindowScreen_MaximizeWindow_Button : Button_Verification
    {
        public Tests_MainWindowScreen_MaximizeWindow_Button()
            : base(() => null,
                  () => MailWasher.UiMap.MainWindow.MaximizeWindow_Button)
        { }
    }

    [TestFixture, Property("UiMap_MainWindow", "CloseWindow_Button")]
    public class Tests_MainWindowScreen_CloseWindow_Button : Button_Verification
    {
        public Tests_MainWindowScreen_CloseWindow_Button()
            : base(() => null,
                  () => MailWasher.UiMap.MainWindow.CloseWindow_Button)
        { }
    }

    [TestFixture, Property("UiMap_MainWindow", "Inbox_Tab")]
    public class Tests_MainWindowScreen_Inbox_Tab : Tab_Verification
    {
        public Tests_MainWindowScreen_Inbox_Tab()
            : base(() => null,
                  () => MailWasher.UiMap.MainWindow.Inbox_Tab)
        { }
    }

    [TestFixture, Property("UiMap_MainWindow", "RecycleBin_Tab")]
    public class Tests_MainWindowScreen_RecycleBin_Tab : Tab_Verification
    {
        public Tests_MainWindowScreen_RecycleBin_Tab()
            : base(() => null,
                  () => MailWasher.UiMap.MainWindow.RecycleBin_Tab)
        { }
    }

    [TestFixture, Property("UiMap_MainWindow", "Settings_Tab")]
    public class Tests_MainWindowScreen_Settings_Tab : Tab_Verification
    {
        public Tests_MainWindowScreen_Settings_Tab()
            : base(() => null,
                  () => MailWasher.UiMap.MainWindow.Settings_Tab)
        { }
    }

    [TestFixture, Property("UiMap_MainWindow", "EventLog_Tab")]
    public class Tests_MainWindowScreen_EventLog_Tab : Tab_Verification
    {
        public Tests_MainWindowScreen_EventLog_Tab()
            : base(() => null,
                  () => MailWasher.UiMap.MainWindow.EventLog_Tab)
        { }
    }
}