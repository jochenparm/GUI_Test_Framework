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

        private void Always_Show_Event_Log(bool enable)
        {
            MailWasher.UiMap.MainWindow.Menu.View.Always_Show_Event_Log_CheckBox.Set(enable);
        }

        IView IView.Always_Show_Event_Log(bool enable)
        {
            this.Always_Show_Event_Log(enable);
            return this;
        }

        private void Preview_Pane(bool enable)
        {
            MailWasher.UiMap.MainWindow.Menu.View.Preview_Pane_CheckBox.Set(enable);
        }

        IView IView.Preview_Pane(bool enable)
        {
            this.Preview_Pane(enable);
            return this;
        }

        private void Preview_Pane_Graphic(bool enable)
        {
            MailWasher.UiMap.MainWindow.Menu.View.Preview_Pane_Graphic_CheckBox.Set(enable);
        }

        IView IView.Preview_Pane_Graphic(bool enable)
        {
            this.Preview_Pane_Graphic(enable);
            return this;
        }

        private void Side_Bar(bool enable)
        {
            MailWasher.UiMap.MainWindow.Menu.View.Side_Bar_CheckBox.Set(enable);
        }

        IView IView.Side_Bar(bool enable)
        {
            this.Side_Bar(enable);
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

        private void Show_Hidden_Mails(bool enable)
        {
            MailWasher.UiMap.MainWindow.Menu.View.Show_Hidden_Emails_CheckBox.Set(enable);
        }

        IView IView.Show_Hidden_Mails(bool enable)
        {
            this.Show_Hidden_Mails(enable);
            return this;
        }
    }
}