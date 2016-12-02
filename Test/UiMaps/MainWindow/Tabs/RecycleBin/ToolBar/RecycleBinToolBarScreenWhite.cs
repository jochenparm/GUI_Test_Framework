using System.Reflection;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.RecycleBin.ToolBar
{
    public class RecycleBinToolBarScreenWhite : AppScreen, IRecycleBinToolBarScreen
    {
        public RecycleBinToolBarScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649
        private TestStack.White.UIItems.Button BtnRestoreMail;
        private TestStack.White.UIItems.Button BtnEmptyBin;
        private TestStack.White.UIItems.Button TglBtnQuickDisplay;
        private TestStack.White.UIItems.CheckBox ChkBxShowAllMail;
        private TestStack.White.UIItems.CheckBox ChkBxHideAutodeletedEmails;
#pragma warning restore 0649

        private UiMapItems.Button.IButton Restore_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnRestoreMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Empty_Bin
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnEmptyBin, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton DisplayOption_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.TglBtnQuickDisplay, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.CheckBox.ICheckBox ShowAllEmailLogged_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxShowAllMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.CheckBox.ICheckBox HideAutodeletedEmails_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxHideAutodeletedEmails, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IRecycleBinToolBarScreen.Restore_Button
        {
            get
            {
                return this.Restore_Button;
            }
        }

        UiMapItems.Button.IButton IRecycleBinToolBarScreen.EmptyBin_Button
        {
            get
            {
                return this.Empty_Bin;
            }
        }

        UiMapItems.Button.IButton IRecycleBinToolBarScreen.DisplayOption_Button
        {
            get
            {
                return this.DisplayOption_Button;
            }
        }

        UiMapItems.CheckBox.ICheckBox IRecycleBinToolBarScreen.ShowAllEmailLogged_CheckBox
        {
            get
            {
                return this.ShowAllEmailLogged_CheckBox;
            }
        }

        UiMapItems.CheckBox.ICheckBox IRecycleBinToolBarScreen.HideAutodeletedEmails_CheckBox
        {
            get
            {
                return this.HideAutodeletedEmails_CheckBox;
            }
        }
    }
}