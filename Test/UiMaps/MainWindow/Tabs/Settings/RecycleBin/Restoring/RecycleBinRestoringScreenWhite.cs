using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.Button.ButtonFactory;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.Restoring
{
    public class RecycleBinRestoringScreenWhite : AppScreen, IRecycleBinRestoringScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public RecycleBinRestoringScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.ListBoxItems.ComboBox CmbBxFallbackRestore; // Dropdown menu 'Fall back account to restore emails'
        private TestStack.White.UIItems.CheckBox ChkBxAddToFriends; // CheckBox 'Automatically add sender to Friends list'
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.DropDownMenu.IDropDownMenu Fall_Back_Account_To_Restore_Emails_DropDownMenu
        {
            get
            {
                return this._uiMapItemsFactory.GetDropDownMenu(this.CmbBxFallbackRestore, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.DropDownMenu.IDropDownMenu IRecycleBinRestoringScreen.Fall_Back_Account_To_Restore_Emails_DropDownMenu
        {
            get
            {
                return this.Fall_Back_Account_To_Restore_Emails_DropDownMenu;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IRecycleBinRestoringScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Automatically_Add_Sender_To_Friends_List_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxAddToFriends, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IRecycleBinRestoringScreen.Automatically_Add_Sender_To_Friends_List_CheckBox
        {
            get
            {
                return this.Automatically_Add_Sender_To_Friends_List_CheckBox;
            }
        }
    }
}