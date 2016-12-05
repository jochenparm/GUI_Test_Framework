using System.Reflection;
using Test.UiMaps.UiMapItems.Button.ButtonFactory;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.StatusBar
{
    public class StatusBarScreenWhite : AppScreen, IStatusBarScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public StatusBarScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

        protected TestStack.White.UIItems.Button BtnDeleteStatus;
        protected TestStack.White.UIItems.ProgressBar progressBar;
        protected TestStack.White.UIItems.Label mailStatus;

        private UiMapItems.TextLabel.ITextLabel MailStatus_TextLabel
        {
            get
            {
                return this._uiMapItemsFactory.GetTextLabel(this.mailStatus, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
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
                return this._uiMapItemsFactory.GetButton(this.BtnDeleteStatus, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
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