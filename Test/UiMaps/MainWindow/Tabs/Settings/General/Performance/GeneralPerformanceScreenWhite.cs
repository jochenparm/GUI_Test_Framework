﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Performance
{
    public class GeneralPerformanceScreenWhite : AppScreen, IGeneralPerformanceScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public GeneralPerformanceScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.CheckBox ChkBxLowQAnimation; // CheckBox 'Use low quality animation'
        private TestStack.White.UIItems.CheckBox ChkBxDeferredLoading; // CheckBox 'Enable fast scrolling'
        private TestStack.White.UIItems.CheckBox ChkBxCollapseGroupHeaders; // CheckBox 'Collapse group header on Check Mail'
        private TestStack.White.UIItems.CheckBox ChkBxNoFetchRefresh; // CheckBox 'Only display emails upon Check Mail completion'
        private TestStack.White.UIItems.CheckBox ChkBxEnableScreenreaders; // CheckBox 'Enable for screenreaders'
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
        private TestStack.White.UIItems.Button BtnResetSpamThrottle; // Button 'Reset Spam Throttle'
        private TestStack.White.UIItems.Slider SldrThrottle; // Slider 'Spam Throttle'
        private TestStack.White.UIItems.Slider SldrMailToCharCount; // Slider 'Maximum Character Count'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.CheckBox.ICheckBox Use_Low_Quality_Animation_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxLowQAnimation, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralPerformanceScreen.Use_Low_Quality_Animation_CheckBox
        {
            get
            {
                return this.Use_Low_Quality_Animation_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Enable_Fast_Scrolling_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxDeferredLoading, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralPerformanceScreen.Enable_Fast_Scrolling_CheckBox
        {
            get
            {
                return this.Enable_Fast_Scrolling_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Collapse_Group_Header_On_Check_Mail_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxCollapseGroupHeaders, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralPerformanceScreen.Collapse_Group_Header_On_Check_Mail_CheckBox
        {
            get
            {
                return this.Collapse_Group_Header_On_Check_Mail_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxNoFetchRefresh, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralPerformanceScreen.Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox
        {
            get
            {
                return this.Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Enable_For_Screenreaders_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxEnableScreenreaders, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralPerformanceScreen.Enable_For_Screenreaders_CheckBox
        {
            get
            {
                return this.Enable_For_Screenreaders_CheckBox;
            }
        }

        private UiMapItems.Button.IButton Reset_Spam_Throttle_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnResetSpamThrottle, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralPerformanceScreen.Reset_Spam_Throttle_Button
        {
            get
            {
                return this.Reset_Spam_Throttle_Button;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralPerformanceScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }

        private UiMapItems.Slider.ISlider Spam_Throttle_Slider
        {
            get
            {
                return this._uiMapItemsFactory.GetSlider(this.SldrThrottle, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Slider.ISlider IGeneralPerformanceScreen.Spam_Throttle_Slider
        {
            get
            {
                return this.Spam_Throttle_Slider;
            }
        }

        private UiMapItems.Slider.ISlider Maximum_Character_Count_Slider
        {
            get
            {
                return this._uiMapItemsFactory.GetSlider(this.SldrMailToCharCount, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Slider.ISlider IGeneralPerformanceScreen.Maximum_Character_Count_Slider
        {
            get
            {
                return this.Maximum_Character_Count_Slider;
            }
        }
    }
}