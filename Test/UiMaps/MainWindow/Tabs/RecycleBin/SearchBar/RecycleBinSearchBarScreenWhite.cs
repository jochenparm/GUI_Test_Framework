using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.RecycleBin.SearchBar
{
    public class RecycleBinSearchBarScreenWhite : AppScreen, IRecycleBinSearchBarScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public RecycleBinSearchBarScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.TextBox TxtBxSearch; //TextBox 'Search 'From' and/or 'Subject''
        private TestStack.White.UIItems.Button BtnClearFrom; // Button 'Clear Search TextBox'
        private TestStack.White.UIItems.ListBoxItems.ComboBox CmbBxPeriodAlt; // Dropdown menu 'Time Window'
        private TestStack.White.UIItems.Label TxtBlkDisplayValue; // TextLabel 'Number of emails displayed'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.TextBox.ITextBox Search_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxSearch, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IRecycleBinSearchBarScreen.Search_TextBox
        {
            get
            {
                return this.Search_TextBox;
            }
        }

        private UiMapItems.Button.IButton Clear_Search_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnClearFrom, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IRecycleBinSearchBarScreen.Clear_Search_Button
        {
            get
            {
                return this.Clear_Search_Button;
            }
        }

        private UiMapItems.DropDownMenu.IDropDownMenu Time_Window_DropDownMenu
        {
            get
            {
                return this._uiMapItemsFactory.GetDropDownMenu(this.CmbBxPeriodAlt, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.DropDownMenu.IDropDownMenu IRecycleBinSearchBarScreen.Time_Window_DropDownMenu
        {
            get
            {
                return this.Time_Window_DropDownMenu;
            }
        }

        private UiMapItems.TextLabel.ITextLabel Number_Of_Emails_Displayed_TextLabel
        {
            get
            {
                return this._uiMapItemsFactory.GetTextLabel(this.TxtBlkDisplayValue, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextLabel.ITextLabel IRecycleBinSearchBarScreen.Number_Of_Emails_Displayed_TextLabel
        {
            get
            {
                return this.Number_Of_Emails_Displayed_TextLabel;
            }
        }
    }
}