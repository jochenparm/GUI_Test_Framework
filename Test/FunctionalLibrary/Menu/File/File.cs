using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Menu.File
{
    public class File : IFile
    {
        public File()
        {
            MailWasher.Navigator.Menu.File.Navigate();
        }

        private void Check_Mail()
        {
            MailWasher.UiMap.MainWindow.Menu.File.CheckMail_Button.Click();
        }

        IFile IFile.Check_Mail()
        {
            this.Check_Mail();
            return this;
        }

        private void Wash_Mail()
        {
            MailWasher.UiMap.MainWindow.Menu.File.WashMail_Button.Click();
        }

        IFile IFile.Wash_Mail()
        {
            this.Wash_Mail();
            return this;
        }

        private void Mail_Program()
        {
            MailWasher.UiMap.MainWindow.Menu.File.MailProgram_Button.Click();
        }

        IFile IFile.Mail_Program()
        {
            this.Mail_Program();
            return this;
        }

        private void Import()
        {
            MailWasher.UiMap.MainWindow.Menu.File.Import_Button.Click();
        }

        IFile IFile.Import()
        {
            this.Import();
            return this;
        }

        private void Export()
        {
            MailWasher.UiMap.MainWindow.Menu.File.Export_Button.Click();
        }

        IFile IFile.Export()
        {
            this.Export();
            return this;
        }

        private void Exit()
        {
            MailWasher.UiMap.MainWindow.Menu.File.Exit_Button.Click();
        }

        IFile IFile.Exit()
        {
            this.Exit();
            return this;
        }
    }
}