using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.FunctionalLevel.MainWindow
{
    [TestFixture, Property("Functional", "MainWindow")]
    public class Functional_Test_MainWindow
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
        }

        [Test]
        public void MainWindow_Maximize_Window()
        {
            MailWasher.Main.Maximize_Window();
        }

        [Test]
        public void MainWindow_Minimize_Window()
        {
            MailWasher.Main.Minimize_Window();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}