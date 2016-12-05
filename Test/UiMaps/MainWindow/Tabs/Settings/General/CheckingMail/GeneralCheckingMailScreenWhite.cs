using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.CheckingMail
{
    public class GeneralCheckingMailScreenWhite : AppScreen, IGeneralCheckingMailScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public GeneralCheckingMailScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.CheckBox ChkBxCheckDefaultOnLaunch; // CheckBox 'Check default accounts when MailWasher starts'
        private TestStack.White.UIItems.CheckBox ChkBxPeriodicCheck; // CheckBox 'Periodically check mail every ... minutes'
        private TestStack.White.UIItems.CheckBox ChkBxDisallowedTime; // CheckBox 'Don't check mail between:'
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
        private TestStack.White.UIItems.Button BtnSpamThrottle; // Button 'Reset Spam Throttle'
        private TestStack.White.UIItems.Button BtnCheckThrottle; // Button 'Reset Check Throttle'
        private TestStack.White.UIItems.TextBox TxtBxPeriodicCheck; //TextBox 'Mail Check Interval'
        private TestStack.White.UIItems.Slider SldrThrottle; // Slider 'Spam Throttle'
        private TestStack.White.UIItems.Slider SldrCheckThrottle; // Slider 'Check Throttle'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.Slider.ISlider Spam_Throttle_Slider
        {
            get
            {
                return this._uiMapItemsFactory.GetSlider(this.SldrThrottle, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Slider.ISlider IGeneralCheckingMailScreen.Spam_Throttle_Slider
        {
            get
            {
                return this.Spam_Throttle_Slider;
            }
        }

        private UiMapItems.Slider.ISlider Check_Throttle_Slider
        {
            get
            {
                return this._uiMapItemsFactory.GetSlider(this.SldrCheckThrottle, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Slider.ISlider IGeneralCheckingMailScreen.Check_Throttle_Slider
        {
            get
            {
                return this.Check_Throttle_Slider;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralCheckingMailScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }

        private UiMapItems.Button.IButton Spam_Throttle_Reset_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSpamThrottle, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralCheckingMailScreen.Spam_Throttle_Reset_Button
        {
            get
            {
                return this.Spam_Throttle_Reset_Button;
            }
        }

        private UiMapItems.Button.IButton Check_Throttle_Reset_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnCheckThrottle, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralCheckingMailScreen.Check_Throttle_Reset_Button
        {
            get
            {
                return this.Check_Throttle_Reset_Button;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Check_Default_Accounts_When_MailWasher_Starts_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxCheckDefaultOnLaunch, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralCheckingMailScreen.Check_Default_Accounts_When_MailWasher_Starts_CheckBox
        {
            get
            {
                return this.Check_Default_Accounts_When_MailWasher_Starts_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Periodically_Check_Mail_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxPeriodicCheck, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralCheckingMailScreen.Periodically_Check_Mail_CheckBox
        {
            get
            {
                return this.Periodically_Check_Mail_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Dont_Check_Mail_Between_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxDisallowedTime, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralCheckingMailScreen.Dont_Check_Mail_Between_CheckBox
        {
            get
            {
                return this.Dont_Check_Mail_Between_CheckBox;
            }
        }

        private UiMapItems.TextBox.ITextBox Mail_Check_Interval_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxPeriodicCheck, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IGeneralCheckingMailScreen.Mail_Check_Interval_TextBox
        {
            get
            {
                return this.Mail_Check_Interval_TextBox;
            }
        }
    }
}