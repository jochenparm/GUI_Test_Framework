using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Incoming
{
    public class AccountsIncomingScreenWhite : AppScreen, IAccountsIncomingScreen
    {
        public AccountsIncomingScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

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
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxServerAddress);
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
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxUsername);
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
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxPassword);
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
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxPortNumber);
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
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxCache);
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
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxSSL);
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
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxUseOAUTH);
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
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxDownloadRead);
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
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxFoldering);
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
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxRememberPassword);
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
                return new UiMapItems.Button.ButtonWhite(this.HeaderSite);
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
                return new UiMapItems.DropDownMenu.DropDownMenuWhite(this.CmbBxServerType);
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
                return new UiMapItems.DropDownMenu.DropDownMenuWhite(this.ComBoxFoldering);
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
                return new UiMapItems.Button.ButtonWhite(this.BtnSave);
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