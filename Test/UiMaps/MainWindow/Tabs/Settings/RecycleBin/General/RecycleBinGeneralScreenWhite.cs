using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.General
{
    public class RecycleBinGeneralScreenWhite : AppScreen, IRecycleBinGeneralScreen
    {
        public RecycleBinGeneralScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.Button BtnSave; // Button 'Save'
        private TestStack.White.UIItems.Slider SldrClearCahce; // Slider 'Store deleted emails for ... days'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnSave);
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
                return new UiMapItems.Slider.SliderWhite(this.SldrClearCahce);
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