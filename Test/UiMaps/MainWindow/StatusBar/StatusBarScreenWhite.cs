using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.StatusBar
{
    public class StatusBarScreenWhite : AppScreen, IStatusBarScreen
    {
        public StatusBarScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

        protected TestStack.White.UIItems.Button BtnDeleteStatus;
        protected TestStack.White.UIItems.ProgressBar progressBar;
        protected TestStack.White.UIItems.Label mailStatus;

        private UiMapItems.TextLabel.ITextLabel MailStatus_TextLabel
        {
            get
            {
                return new UiMapItems.TextLabel.TextLabelWhite(this.mailStatus);
            }
        }

        UiMapItems.TextLabel.ITextLabel IStatusBarScreen.MailStatus_TextLabel
        {
            get
            {
                return this.MailStatus_TextLabel;
            }
        }

        private UiMapItems.Button.IButton DeleteStatus_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnDeleteStatus);
            }
        }

        UiMapItems.Button.IButton IStatusBarScreen.DeleteStatus_Button
        {
            get
            {
                return this.DeleteStatus_Button;
            }
        }
    }
}