using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Inbox.ToolBar
{
    public class InboxToolBarScreenWhite : AppScreen, IInboxToolBarScreen
    {
        public InboxToolBarScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649
        private TestStack.White.UIItems.Button BtnCheckMail;
        private TestStack.White.UIItems.Button BtnWashMail;
        private TestStack.White.UIItems.Button BtnLaunchMailProgram;
        private TestStack.White.UIItems.Button TglBtnQuickDisplay;
        private TestStack.White.UIItems.Button TglBtnSearch;
#pragma warning restore 0649

        private UiMapItems.Button.IButton WashMail_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnWashMail);
            }
        }

        private UiMapItems.Button.IButton CheckMail_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnCheckMail);
            }
        }

        private UiMapItems.Button.IButton MailProgram_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnLaunchMailProgram);
            }
        }

        private UiMapItems.Button.IButton SearchInbox_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.TglBtnSearch);
            }
        }

        private UiMapItems.Button.IButton DisplayOptions_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.TglBtnQuickDisplay);
            }
        }

        UiMapItems.Button.IButton IInboxToolBarScreen.CheckMail_Button
        {
            get { return this.CheckMail_Button; }
        }

        UiMapItems.Button.IButton IInboxToolBarScreen.WashMail_Button
        {
            get { return this.WashMail_Button; }
        }

        UiMapItems.Button.IButton IInboxToolBarScreen.MailProgram_Button
        {
            get { return this.MailProgram_Button; }
        }

        UiMapItems.Button.IButton IInboxToolBarScreen.SearchInbox_Button
        {
            get { return this.SearchInbox_Button; }
        }

        UiMapItems.Button.IButton IInboxToolBarScreen.DisplayOptions_Button
        {
            get { return this.DisplayOptions_Button; }
        }
    }
}