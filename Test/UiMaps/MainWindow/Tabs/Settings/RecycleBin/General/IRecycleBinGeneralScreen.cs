using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.General
{
    public interface IRecycleBinGeneralScreen
    {
        UiMapItems.Button.IButton Save_Button { get; }
        UiMapItems.Slider.ISlider Deleted_Email_Storage_Duration_Slider { get; }
    }
}