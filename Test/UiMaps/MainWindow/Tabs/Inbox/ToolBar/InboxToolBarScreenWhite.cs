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
        private TestStack.White.UIItems.Button BtnRegister;
#pragma warning restore 0649

        public UiMapItems.Button.IButton WashMail_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnWashMail);
            }
        }

        public UiMapItems.Button.IButton CheckMail_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnCheckMail);
            }
        }

        public UiMapItems.Button.IButton MailProgram_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnLaunchMailProgram);
            }
        }

        public UiMapItems.Button.IButton SearchInbox_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.TglBtnSearch);
            }
        }

        public UiMapItems.Button.IButton DisplayOptions_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.TglBtnQuickDisplay);
            }
        }

        public UiMapItems.Button.IButton Register_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnRegister);
            }
        }
    }
}