using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.WashingMail
{
    public class GeneralWashingMailScreenWhite : AppScreen, IGeneralWashingMailScreen
    {
        public GeneralWashingMailScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.CheckBox ChkBxMinimiseAfterWash; // CheckBox 'Minimize MailWasher after Wash Mail'
        private TestStack.White.UIItems.CheckBox ChkBxUseDefaultIcon; // CheckBox 'Use default email program icon'
        private TestStack.White.UIItems.CheckBox ChkBxLaunchProgram; // CheckBox 'Launch after Wash Mail'
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
        private TestStack.White.UIItems.TextBox TxtBxCustomPath; //TextBox 'Email Program Path'
        private TestStack.White.UIItems.ListBoxItems.ComboBox CmbBxProgramList; //DropDownMenu 'Email Program'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.CheckBox.ICheckBox Minimize_MailWasher_After_Wash_Mail_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxMinimiseAfterWash, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralWashingMailScreen.Minimize_MailWasher_After_Wash_Mail_CheckBox
        {
            get
            {
                return this.Minimize_MailWasher_After_Wash_Mail_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Launch_Email_Program_After_Wash_Mail_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxLaunchProgram, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralWashingMailScreen.Launch_Email_Program_After_Wash_Mail_CheckBox
        {
            get
            {
                return this.Launch_Email_Program_After_Wash_Mail_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Use_Default_Email_Program_Icon_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxUseDefaultIcon, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralWashingMailScreen.Use_Default_Email_Program_Icon_CheckBox
        {
            get
            {
                return this.Use_Default_Email_Program_Icon_CheckBox;
            }
        }

        private UiMapItems.DropDownMenu.IDropDownMenu Email_Program_DropDownMenu
        {
            get
            {
                return new UiMapItems.DropDownMenu.DropDownMenuWhite(this.CmbBxProgramList, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.DropDownMenu.IDropDownMenu IGeneralWashingMailScreen.Email_Program_DropDownMenu
        {
            get
            {
                return this.Email_Program_DropDownMenu;
            }
        }

        private UiMapItems.TextBox.ITextBox Email_Program_Path_TextBox
        {
            get
            {
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxCustomPath, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IGeneralWashingMailScreen.Email_Program_Path_TextBox
        {
            get
            {
                return this.Email_Program_Path_TextBox;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralWashingMailScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }
    }
}