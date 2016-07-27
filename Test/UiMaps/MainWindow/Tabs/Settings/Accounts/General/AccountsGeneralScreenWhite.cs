using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.General
{
    public class AccountsGeneralScreenWhite : AppScreen, IAccountsGeneralScreen
    {
        public AccountsGeneralScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

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
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxAccountName);
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
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxEmailAddress);
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
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxDefaultCheck);
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
                return new UiMapItems.Button.ButtonWhite(this.BtnSave);
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