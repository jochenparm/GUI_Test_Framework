using System;
using System.Reflection;
using Test.UiMaps.UiMapItems.Button;
using Test.UiMaps.UiMapItems.CheckBox;
using Test.UiMaps.UiMapItems.DropDownMenu;
using Test.UiMaps.UiMapItems.TextLabel;
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
        private TestStack.White.UIItems.ListBoxItems.ComboBox CmbBxCheckMail;
        private TestStack.White.UIItems.Label LblCheckMail;
#pragma warning restore 0649

        private UiMapItems.Button.IButton WashMail_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnWashMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton CheckMail_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnCheckMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton MailProgram_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnLaunchMailProgram, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton SearchInbox_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.TglBtnSearch, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton DisplayOptions_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.TglBtnQuickDisplay, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Register_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnRegister, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.DropDownMenu.IDropDownMenu CheckMail_DropDownMenu
        {
            get
            {
                return new UiMapItems.DropDownMenu.DropDownMenuWhite(this.CmbBxCheckMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.TextLabel.ITextLabel CheckMail_TextLabel
        {
            get
            {
                return new UiMapItems.TextLabel.TextLabelWhite(this.LblCheckMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        IButton IInboxToolBarScreen.CheckMail_Button
        {
            get
            {
                return this.CheckMail_Button;
            }
        }

        IDropDownMenu IInboxToolBarScreen.CheckMail_DropDownMenu
        {
            get
            {
                return this.CheckMail_DropDownMenu;
            }
        }

        IButton IInboxToolBarScreen.WashMail_Button
        {
            get
            {
                return this.WashMail_Button;
            }
        }

        IButton IInboxToolBarScreen.MailProgram_Button
        {
            get
            {
                return this.MailProgram_Button;
            }
        }

        IButton IInboxToolBarScreen.Register_Button
        {
            get
            {
                return this.Register_Button;
            }
        }

        IButton IInboxToolBarScreen.SearchInbox_Button
        {
            get
            {
                return this.SearchInbox_Button;
            }
        }

        IButton IInboxToolBarScreen.DisplayOptions_Button
        {
            get
            {
                return this.DisplayOptions_Button;
            }
        }

        ITextLabel IInboxToolBarScreen.CheckMail_TextLabel
        {
            get
            {
                return this.CheckMail_TextLabel;
            }
        }
    }
}