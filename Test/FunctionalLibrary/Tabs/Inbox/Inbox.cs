using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Inbox
{
    public class Inbox : IInbox
    {
        public Inbox()
        {
            MailWasher.Navigator.Tabs.Inbox.Navigate();
        }

        private void Check_All_Email()
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.CheckMail_DropDownMenu.Select("Check All");
        }

        IInbox IInbox.Check_All_Email()
        {
            this.Check_All_Email();
            return this;
        }

        private void Check_Email(string accountName)
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.CheckMail_DropDownMenu.Select(accountName);
        }

        IInbox IInbox.Check_Email(string accountName)
        {
            this.Check_Email(accountName);
            return this;
        }

        private bool Is_Checking_Email
        {
            get
            {
                bool returnValue = false;
                if(MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.CheckMail_TextLabel.Content.Equals("Stop Checking"))
                {
                    returnValue = true;
                }
                return returnValue;
            }
        }

        bool IInbox.Is_Checking_Email
        {
            get
            {
                return this.Is_Checking_Email;
            }
        }

        private void Stop_Checking_Email()
        {
            if(this.Is_Checking_Email)
            {
                MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.CheckMail_Button.Click();
            }
        }

        IInbox IInbox.Stop_Checking_Email()
        {
            this.Stop_Checking_Email();
            return this;
        }

        private bool Wait_For_Is_Checking_Email(int seconds)
        {
            Stopwatch sw = Stopwatch.StartNew();
            while(!Is_Checking_Email && (sw.ElapsedMilliseconds <= (seconds * 1000)))
            {
                Thread.Sleep(1);
            }
            sw.Stop();
            if((sw.ElapsedMilliseconds - (seconds * 1000)) >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Wait_For_Isnt_Checking_Email(int seconds)
        {
            Stopwatch sw = Stopwatch.StartNew();
            while(Is_Checking_Email && (sw.ElapsedMilliseconds <= (seconds * 1000)))
            {
                Thread.Sleep(1);
            }
            sw.Stop();
            if((sw.ElapsedMilliseconds - (seconds * 1000)) >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool IInbox.Wait_For_Is_Checking_Email(int seconds)
        {
            return this.Wait_For_Is_Checking_Email(seconds);
        }

        bool IInbox.Wait_For_Isnt_Checking_Email(int seconds)
        {
            return this.Wait_For_Isnt_Checking_Email(seconds);
        }

        private void Wash_Mail()
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.WashMail_Button.Click();
        }

        IInbox IInbox.Wash_Mail()
        {
            this.Wash_Mail();
            return this;
        }

        private void Open_Mail_Program()
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.MailProgram_Button.Click();
        }

        IInbox IInbox.Open_Mail_Program()
        {
            this.Open_Mail_Program();
            return this;
        }

        private void Open_Registration_Form()
        {
            MailWasher.UiMap.MainWindow.Tabs.Inbox.ToolBar.Register_Button.Click();
        }

        IInbox IInbox.Open_Registration_Form()
        {
            this.Open_Registration_Form();
            return this;
        }
    }
}