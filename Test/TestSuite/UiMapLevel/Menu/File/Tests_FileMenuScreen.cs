using NUnit.Framework;
using Shouldly;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Menu.File
{
    [TestFixture, Property("UiMap_File_Menu", "CheckMail_Button")]
    public class Tests_FileMenuScreen_CheckMail_Button : Button_Verification
    {
        public Tests_FileMenuScreen_CheckMail_Button()
            : base(() => MailWasher.Navigator.Menu.File.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.File.CheckMail_Button)
        { }
    }

    [TestFixture, Property("UiMap_File_Menu", "WashMail_Button")]
    public class Tests_FileMenuScreen_WashMail_Button : Button_Verification
    {
        public Tests_FileMenuScreen_WashMail_Button()
            : base(() => MailWasher.Navigator.Menu.File.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.File.WashMail_Button)
        { }
    }

    [TestFixture, Property("UiMap_File_Menu", "MailProgram_Button")]
    public class Tests_FileMenuScreen_MailProgram_Button : Button_Verification
    {
        public Tests_FileMenuScreen_MailProgram_Button()
            : base(() => MailWasher.Navigator.Menu.File.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.File.MailProgram_Button)
        { }
    }

    [TestFixture, Property("UiMap_File_Menu", "Import_Button")]
    public class Tests_FileMenuScreen_Import_Button : Button_Verification
    {
        public Tests_FileMenuScreen_Import_Button()
            : base(() => MailWasher.Navigator.Menu.File.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.File.Import_Button)
        { }
    }

    [TestFixture, Property("UiMap_File_Menu", "Export_Button")]
    public class Tests_FileMenuScreen_Export_Button : Button_Verification
    {
        public Tests_FileMenuScreen_Export_Button()
            : base(() => MailWasher.Navigator.Menu.File.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.File.Export_Button)
        { }
    }

    [TestFixture, Property("UiMap_File_Menu", "Exit_Button")]
    public class Tests_FileMenuScreen_Exit_Button : Button_Verification
    {
        public Tests_FileMenuScreen_Exit_Button()
            : base(() => MailWasher.Navigator.Menu.File.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.File.Exit_Button)
        { }
    }
}