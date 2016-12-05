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

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.General
{
    public class RecycleBinGeneralScreenWhite : AppScreen, IRecycleBinGeneralScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public RecycleBinGeneralScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
        private TestStack.White.UIItems.Slider SldrClearCahce; // Slider 'Store deleted emails for ... days'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IRecycleBinGeneralScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }

        private UiMapItems.Slider.ISlider Deleted_Email_Storage_Duration_Slider
        {
            get
            {
                return this._uiMapItemsFactory.GetSlider(this.SldrClearCahce, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Slider.ISlider IRecycleBinGeneralScreen.Deleted_Email_Storage_Duration_Slider
        {
            get
            {
                return this.Deleted_Email_Storage_Duration_Slider;
            }
        }
    }
}