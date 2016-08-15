using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Updates
{
    public class GeneralUpdatesScreenWhite : AppScreen, IGeneralUpdatesScreen
    {
        public GeneralUpdatesScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

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
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxAutoCheck);
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
                return new UiMapItems.Button.ButtonWhite(this.BtnSave);
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
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxDownloadPath);
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
                return new UiMapItems.TextBox.TextBoxWhite(this.TxtBxFrequencyValue);
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