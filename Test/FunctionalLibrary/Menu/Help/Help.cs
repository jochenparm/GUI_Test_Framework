using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Menu.Help
{
    public class Help : IHelp
    {
        public Help()
        {
            MailWasher.UiMap.MainWindow.Menu.Help_Button.Click();
        }

        private void Open_About_Window()
        {
            MailWasher.UiMap.MainWindow.Menu.Help.About_Button.Click();
        }

        IHelp IHelp.Open_About_Window()
        {
            this.Open_About_Window();
            return this;
        }

        private void Check_For_Updates()
        {
            MailWasher.UiMap.MainWindow.Menu.Help.Check_For_Updates_Button.Click();
        }

        IHelp IHelp.Check_For_Updates()
        {
            this.Check_For_Updates();
            return this;
        }

        private void Open_Common_Files()
        {
            MailWasher.UiMap.MainWindow.Menu.Help.Common_Files_Button.Click();
        }

        IHelp IHelp.Open_Common_Files()
        {
            this.Open_Common_Files();
            return this;
        }

        private void Log_Protocol(bool enable)
        {
            MailWasher.UiMap.MainWindow.Menu.Help.Log_Protocol_CheckBox.Set(enable);
        }

        IHelp IHelp.Log_Protocol(bool enable)
        {
            this.Log_Protocol(enable);
            return this;
        }

        private void Open_Forums()
        {
            MailWasher.UiMap.MainWindow.Menu.Help.Forums_Button.Click();
        }

        IHelp IHelp.Open_Forums()
        {
            this.Open_Forums();
            return this;
        }

        private void Open_Help_Topics()
        {
            MailWasher.UiMap.MainWindow.Menu.Help.Help_Topics_Button.Click();
        }

        IHelp IHelp.Open_Help_Topics()
        {
            this.Open_Help_Topics();
            return this;
        }

        private void Open_Registration_Form()
        {
            MailWasher.UiMap.MainWindow.Menu.Help.Registration_Button.Click();
        }

        IHelp IHelp.Open_Registration_Form()
        {
            this.Open_Registration_Form();
            return this;
        }

        private void Open_Send_Support_Logs_Form()
        {
            MailWasher.UiMap.MainWindow.Menu.Help.Send_Support_Logs_Button.Click();
        }

        IHelp IHelp.Open_Send_Support_Logs_Form()
        {
            this.Open_Send_Support_Logs_Form();
            return this;
        }

        private void Open_Tell_A_Friend_Form()
        {
            MailWasher.UiMap.MainWindow.Menu.Help.Tell_A_Friend_Button.Click();
        }

        IHelp IHelp.Open_Tell_A_Friend_Form()
        {
            this.Open_Tell_A_Friend_Form();
            return this;
        }

        private void Open_User_Files()
        {
            MailWasher.UiMap.MainWindow.Menu.Help.Tell_A_Friend_Button.Click();
        }

        IHelp IHelp.Open_User_Files()
        {
            this.Open_User_Files();
            return this;
        }
    }
}