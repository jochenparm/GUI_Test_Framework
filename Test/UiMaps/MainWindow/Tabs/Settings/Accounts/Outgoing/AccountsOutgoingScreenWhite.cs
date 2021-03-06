﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Outgoing
{
    public class AccountsOutgoingScreenWhite : AppScreen, IAccountsOutgoingScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public AccountsOutgoingScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.ListBoxItems.ComboBox CmbBxAuthentication; // Dropdown menu 'Secure Connection'
        private TestStack.White.UIItems.TextBox TxtBxAddress; //TextBox 'SMTP Server address'
        private TestStack.White.UIItems.TextBox TxtBxUsername; //TextBox 'Username'
        private TestStack.White.UIItems.TextBox PswdBxPassword; //TextBox 'Password'
        private TestStack.White.UIItems.TextBox TxtBxPortNumber; //TextBox 'Server Port Number'
        private TestStack.White.UIItems.CheckBox ChkBxAuthentication; // CheckBox 'SMTP server requires authentication'
        private TestStack.White.UIItems.Button HeaderSite; // Button 'Advanced'
        private TestStack.White.UIItems.Button BtnRestoreDefault; // Button 'Restore Default'
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
        private TestStack.White.UIItems.RadioButton RdoBtnUseIncomingAuth; // RadioButton 'Use same settings as my incoming mail server'
        private TestStack.White.UIItems.RadioButton RdoBtnUseCustomAuth; // RadioButton 'Use the following login'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.TextBox.ITextBox SMTP_Server_Address_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxAddress, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsOutgoingScreen.SMTP_Server_Address_TextBox
        {
            get
            {
                return this.SMTP_Server_Address_TextBox;
            }
        }

        private UiMapItems.TextBox.ITextBox Server_Port_Number_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxPortNumber, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsOutgoingScreen.Server_Port_Number_TextBox
        {
            get
            {
                return this.Server_Port_Number_TextBox;
            }
        }

        private UiMapItems.TextBox.ITextBox Username_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxUsername, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsOutgoingScreen.Username_TextBox
        {
            get
            {
                return this.Username_TextBox;
            }
        }

        private UiMapItems.TextBox.ITextBox Password_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.PswdBxPassword, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsOutgoingScreen.Password_TextBox
        {
            get
            {
                return this.Password_TextBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox SMTP_Server_Requires_Authentication_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxAuthentication, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IAccountsOutgoingScreen.SMTP_Server_Requires_Authentication_CheckBox
        {
            get
            {
                return this.SMTP_Server_Requires_Authentication_CheckBox;
            }
        }

        private UiMapItems.Button.IButton Advanced_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.HeaderSite, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IAccountsOutgoingScreen.Advanced_Button
        {
            get
            {
                return this.Advanced_Button;
            }
        }

        private UiMapItems.Button.IButton Restore_Default_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnRestoreDefault, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IAccountsOutgoingScreen.Restore_Default_Button
        {
            get
            {
                return this.Restore_Default_Button;
            }
        }

        private UiMapItems.DropDownMenu.IDropDownMenu Secure_Connection_DropDownMenu
        {
            get
            {
                return this._uiMapItemsFactory.GetDropDownMenu(this.CmbBxAuthentication, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.DropDownMenu.IDropDownMenu IAccountsOutgoingScreen.Secure_Connection_DropDownMenu
        {
            get
            {
                return this.Secure_Connection_DropDownMenu;
            }
        }

        private UiMapItems.RadioButton.IRadioButton Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton
        {
            get
            {
                return this._uiMapItemsFactory.GetRadioButton(this.RdoBtnUseIncomingAuth, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.RadioButton.IRadioButton IAccountsOutgoingScreen.Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton
        {
            get
            {
                return this.Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton;
            }
        }

        private UiMapItems.RadioButton.IRadioButton Use_The_Following_Login_RadioButton
        {
            get
            {
                return this._uiMapItemsFactory.GetRadioButton(this.RdoBtnUseCustomAuth, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.RadioButton.IRadioButton IAccountsOutgoingScreen.Use_The_Following_Login_RadioButton
        {
            get
            {
                return this.Use_The_Following_Login_RadioButton;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IAccountsOutgoingScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }
    }
}