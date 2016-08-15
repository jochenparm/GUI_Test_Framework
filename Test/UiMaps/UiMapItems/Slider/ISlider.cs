using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Slider
{
    public interface ISlider : IUiMapItem
    {
        void Set_Max();

        void Set_Min();

        int Value { get; set; }
    }
}