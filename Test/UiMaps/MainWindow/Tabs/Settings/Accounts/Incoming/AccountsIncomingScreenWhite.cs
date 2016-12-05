using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Incoming
{
    public class AccountsIncomingScreenWhite : AppScreen, IAccountsIncomingScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public AccountsIncomingScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.ListBoxItems.ComboBox CmbBxServerType; // Dropdown menu 'Server Type'
        private TestStack.White.UIItems.ListBoxItems.ComboBox ComBoxFoldering; // Dropdown menu 'Destination Folder'
        private TestStack.White.UIItems.TextBox TxtBxServerAddress; //TextBox 'Server address'
        private TestStack.White.UIItems.TextBox TxtBxUsername; //TextBox 'Username'
        private TestStack.White.UIItems.TextBox TxtBxPassword; //TextBox 'Password'
        private TestStack.White.UIItems.TextBox TxtBxPortNumber; //TextBox 'Server Port Number'
        private TestStack.White.UIItems.CheckBox ChkBxSSL; // CheckBox 'This server requires a secure connection (SSL)'
        private TestStack.White.UIItems.CheckBox ChkBxFoldering; // CheckBox 'Move deleted messages into folder'
        private TestStack.White.UIItems.CheckBox ChkBxUseOAUTH; // CheckBox 'Use OAUTH'
        private TestStack.White.UIItems.CheckBox ChkBxDownloadRead; // CheckBox 'Download read e-mails'
        private TestStack.White.UIItems.CheckBox ChkBxRememberPassword; // CheckBox 'Remember password'
        private TestStack.White.UIItems.CheckBox ChkBxCache; // CheckBox 'Store cached emails'
        private TestStack.White.UIItems.Button HeaderSite; // Button 'Advanced'
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.TextBox.ITextBox Server_Address_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxServerAddress, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsIncomingScreen.Server_Address_TextBox
        {
            get
            {
                return this.Server_Address_TextBox;
            }
        }

        private UiMapItems.TextBox.ITextBox User_Name_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxUsername, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsIncomingScreen.User_Name_TextBox
        {
            get
            {
                return this.User_Name_TextBox;
            }
        }

        private UiMapItems.TextBox.ITextBox Password_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxPassword, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsIncomingScreen.Password_TextBox
        {
            get
            {
                return this.Password_TextBox;
            }
        }

        private UiMapItems.TextBox.ITextBox Server_Port_Number_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxPortNumber, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IAccountsIncomingScreen.Server_Port_Number_TextBox
        {
            get
            {
                return this.Server_Port_Number_TextBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Store_Cached_Emails_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxCache, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IAccountsIncomingScreen.Store_Cached_Emails_CheckBox
        {
            get
            {
                return this.Store_Cached_Emails_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox This_Server_Requires_A_Secure_Connection_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxSSL, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IAccountsIncomingScreen.This_Server_Requires_A_Secure_Connection_CheckBox
        {
            get
            {
                return this.This_Server_Requires_A_Secure_Connection_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Use_OAUTH_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxUseOAUTH, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IAccountsIncomingScreen.Use_OAUTH_CheckBox
        {
            get
            {
                return this.Use_OAUTH_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Download_Read_Emails_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxDownloadRead, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IAccountsIncomingScreen.Download_Read_Emails_CheckBox
        {
            get
            {
                return this.Download_Read_Emails_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Move_Deleted_Messages_Into_Folder_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxFoldering, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IAccountsIncomingScreen.Move_Deleted_Messages_Into_Folder_CheckBox
        {
            get
            {
                return this.Move_Deleted_Messages_Into_Folder_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Remember_Password_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxRememberPassword, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IAccountsIncomingScreen.Remember_Password_CheckBox
        {
            get
            {
                return this.Remember_Password_CheckBox;
            }
        }

        private UiMapItems.Button.IButton Advanced_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.HeaderSite, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IAccountsIncomingScreen.Advanced_Button
        {
            get
            {
                return this.Advanced_Button;
            }
        }

        private UiMapItems.DropDownMenu.IDropDownMenu Server_Type_DropDownMenu
        {
            get
            {
                return this._uiMapItemsFactory.GetDropDownMenu(this.CmbBxServerType, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.DropDownMenu.IDropDownMenu IAccountsIncomingScreen.Server_Type_DropDownMenu
        {
            get
            {
                return this.Server_Type_DropDownMenu;
            }
        }

        private UiMapItems.DropDownMenu.IDropDownMenu Destination_Folder_DropDownMenu
        {
            get
            {
                return this._uiMapItemsFactory.GetDropDownMenu(this.ComBoxFoldering, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.DropDownMenu.IDropDownMenu IAccountsIncomingScreen.Destination_Folder_DropDownMenu
        {
            get
            {
                return this.Destination_Folder_DropDownMenu;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IAccountsIncomingScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }
    }
}