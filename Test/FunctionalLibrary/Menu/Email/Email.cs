using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Menu.Email
{
    public class Email : IEmail
    {
        public Email()
        {
            MailWasher.Navigator.Menu.Email.Navigate();
        }

        private void Add_Domain_To_Blacklist()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Add_Domain_To_Blacklist_Button.Click();
        }

        IEmail IEmail.Add_Domain_To_Blacklist()
        {
            this.Add_Domain_To_Blacklist();
            return this;
        }

        private void Add_Domain_To_Friends_List()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Add_Domain_To_Friends_List_Button.Click();
        }

        IEmail IEmail.Add_Domain_To_Friends_List()
        {
            this.Add_Domain_To_Friends_List();
            return this;
        }

        private void Add_Sender_To_Blacklist()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Add_Sender_To_Blacklist_Button.Click();
        }

        IEmail IEmail.Add_Sender_To_Blacklist()
        {
            this.Add_Sender_To_Blacklist();
            return this;
        }

        private void Add_Sender_To_Friends_List()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Add_Sender_To_Friends_List_Button.Click();
        }

        IEmail IEmail.Add_Sender_To_Friends_List()
        {
            this.Add_Sender_To_Friends_List();
            return this;
        }

        private void Clear_Message_List()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Clear_Message_List_Button.Click();
        }

        IEmail IEmail.Clear_Message_List()
        {
            this.Clear_Message_List();
            return this;
        }

        private void Download_Full()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Download_Full_Button.Click();
        }

        IEmail IEmail.Download_Full()
        {
            this.Download_Full();
            return this;
        }

        private void Mark_All_For_Delete()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Mark_All_For_Delete_Button.Click();
        }

        IEmail IEmail.Mark_All_For_Delete()
        {
            this.Mark_All_For_Delete();
            return this;
        }

        private void Mark_As_Good()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Mark_As_Good_Button.Click();
        }

        IEmail IEmail.Mark_As_Good()
        {
            this.Mark_As_Good();
            return this;
        }

        private void Mark_As_Spam()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Mark_As_Spam_Button.Click();
        }

        IEmail IEmail.Mark_As_Spam()
        {
            this.Mark_As_Spam();
            return this;
        }

        private void Mark_For_Bounce()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Mark_For_Bounce_Button.Click();
        }

        IEmail IEmail.Mark_For_Bounce()
        {
            this.Mark_For_Bounce();
            return this;
        }

        private void Mark_For_Delete()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Mark_For_Delete_Button.Click();
        }

        IEmail IEmail.Mark_For_Delete()
        {
            this.Mark_For_Delete();
            return this;
        }

        private void Quick_Forward()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Quick_Forward_Button.Click();
        }

        IEmail IEmail.Quick_Forward()
        {
            this.Quick_Forward();
            return this;
        }

        private void Quick_Reply()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Quick_Reply_Button.Click();
        }

        IEmail IEmail.Quick_Reply()
        {
            this.Quick_Reply();
            return this;
        }

        private void Remove_Sender_From_Blacklist()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Remove_Sender_From_Blacklist_Button.Click();
        }

        IEmail IEmail.Remove_Sender_From_Blacklist()
        {
            this.Remove_Sender_From_Blacklist();
            return this;
        }

        private void Remove_Sender_From_Friends_List()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Remove_Sender_From_Friends_List_Button.Click();
        }

        IEmail IEmail.Remove_Sender_From_Friends_List()
        {
            this.Remove_Sender_From_Friends_List();
            return this;
        }

        private void Unmark_Delete()
        {
            MailWasher.UiMap.MainWindow.Menu.Email.Unmark_Delete_Button.Click();
        }

        IEmail IEmail.Unmark_Delete()
        {
            this.Unmark_Delete();
            return this;
        }
    }
}