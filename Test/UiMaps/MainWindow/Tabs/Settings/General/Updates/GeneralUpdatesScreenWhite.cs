using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Updates
{
    public class GeneralUpdatesScreenWhite : AppScreen, IGeneralUpdatesScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public GeneralUpdatesScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.CheckBox ChkBxAutoCheck; // CheckBox 'Automatically check for update'
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
        private TestStack.White.UIItems.TextBox TxtBxDownloadPath; //TextBox 'Download to: Path'
        private TestStack.White.UIItems.TextBox TxtBxFrequencyValue; //TextBox 'Check for updates every ... days'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.CheckBox.ICheckBox Automatically_Check_For_Update_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.ChkBxAutoCheck, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralUpdatesScreen.Automatically_Check_For_Update_CheckBox
        {
            get
            {
                return this.Automatically_Check_For_Update_CheckBox;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralUpdatesScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }

        private UiMapItems.TextBox.ITextBox Download_Path_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxDownloadPath, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IGeneralUpdatesScreen.Download_Path_TextBox
        {
            get
            {
                return this.Download_Path_TextBox;
            }
        }

        private UiMapItems.TextBox.ITextBox Update_Frequency_TextBox
        {
            get
            {
                return this._uiMapItemsFactory.GetTextBox(this.TxtBxFrequencyValue, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.TextBox.ITextBox IGeneralUpdatesScreen.Update_Frequency_TextBox
        {
            get
            {
                return this.Update_Frequency_TextBox;
            }
        }
    }
}