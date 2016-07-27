using NUnit.Framework;
using Shouldly;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel
{
    [TestFixture, Property("UiMap", "File_Menu_UIItems")]
    public class Tests_FileMenuScreen
    {
        [SetUp]
        public void SetUp()
        {
            UiMap.Init();
            UiMap.MainWindow.Menu.File_Button.Click();
        }

        [Test]
        public void Verify_CheckMail_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Menu.File.CheckMail_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_WashMail_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Menu.File.WashMail_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_MailProgram_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Menu.File.MailProgram_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Import_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Menu.File.Import_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Export_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Menu.File.Export_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Exit_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Menu.File.Exit_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            UiMap.DeInit();
        }
    }
}