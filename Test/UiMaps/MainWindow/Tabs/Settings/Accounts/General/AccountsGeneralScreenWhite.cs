﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.General
{
    public class AccountsGeneralScreenWhite : AppScreen, IAccountsGeneralScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public AccountsGeneralScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.TextBox TxtBxAccountName; // TextBox 'Account Description'
        private TestStack.White.UIItems.TextBox TxtBxEmailAddress; // TextBox 'Email Address'
        private TestStack.White.UIItems.CheckBox ChkBxDefaultCheck; // CheckBox 'Include in default mail check'
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.TextBox.ITextBox Account_Description_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxAccountName, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsGeneralScreen.Account_Description_TextBox
        {
            get
            {
                return this.Account_Description_TextBox;
            }
        }

        private UiMapItems.TextBox.ITextBox Email_Address_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxEmailAddress, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsGeneralScreen.Email_Address_TextBox
        {
            get
            {
                return this.Email_Address_TextBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Include_In_Default_Mail_Check_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxDefaultCheck, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IAccountsGeneralScreen.Include_In_Default_Mail_Check_CheckBox
        {
            get
            {
                return this.Include_In_Default_Mail_Check_CheckBox;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IAccountsGeneralScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }
    }
}