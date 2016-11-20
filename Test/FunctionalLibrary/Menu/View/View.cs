using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Menu.View
{
    public class View : IView
    {
        public View()
        {
            MailWasher.UiMap.MainWindow.Menu.View_Button.Click();
        }

        private void Disable_Always_Show_Event_Log()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Always_Show_Event_Log_CheckBox.Disable();
        }

        IView IView.Disable_Always_Show_Event_Log()
        {
            this.Disable_Always_Show_Event_Log();
            return this;
        }

        private void Disable_Preview_Pane()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Preview_Pane_CheckBox.Disable();
        }

        IView IView.Disable_Preview_Pane()
        {
            this.Disable_Preview_Pane();
            return this;
        }

        private void Disable_Preview_Pane_Graphic()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Preview_Pane_Graphic_CheckBox.Disable();
        }

        IView IView.Disable_Preview_Pane_Graphic()
        {
            this.Disable_Preview_Pane_Graphic();
            return this;
        }

        private void Disable_Side_Bar()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Side_Bar_CheckBox.Disable();
        }

        IView IView.Disable_Side_Bar()
        {
            this.Disable_Side_Bar();
            return this;
        }

        private void Enable_Always_Show_Event_Log()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Always_Show_Event_Log_CheckBox.Enable();
        }

        IView IView.Enable_Always_Show_Event_Log()
        {
            this.Enable_Always_Show_Event_Log();
            return this;
        }

        private void Enable_Preview_Pane()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Preview_Pane_CheckBox.Enable();
        }

        IView IView.Enable_Preview_Pane()
        {
            this.Enable_Preview_Pane();
            return this;
        }

        private void Enable_Preview_Pane_Graphic()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Preview_Pane_Graphic_CheckBox.Enable();
        }

        IView IView.Enable_Preview_Pane_Graphic()
        {
            this.Enable_Preview_Pane_Graphic();
            return this;
        }

        private void Enable_Side_Bar()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Side_Bar_CheckBox.Enable();
        }

        IView IView.Enable_Side_Bar()
        {
            this.Enable_Side_Bar();
            return this;
        }

        private void Hide_Hidden_Mails()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Show_Hidden_Emails_CheckBox.Disable();
        }

        IView IView.Hide_Hidden_Mails()
        {
            this.Hide_Hidden_Mails();
            return this;
        }

        private void Open_Tutorial_Video()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Tutorial_Video_Button.Click();
        }

        IView IView.Open_Tutorial_Video()
        {
            this.Open_Tutorial_Video();
            return this;
        }

        private void Show_Hidden_Mails()
        {
            MailWasher.UiMap.MainWindow.Menu.View.Show_Hidden_Emails_CheckBox.Enable();
        }

        IView IView.Show_Hidden_Mails()
        {
            this.Show_Hidden_Mails();
            return this;
        }
    }
}