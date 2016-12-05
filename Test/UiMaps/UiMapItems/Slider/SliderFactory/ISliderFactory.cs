using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Slider.SliderFactory
{
    public interface ISliderFactory
    {
        ISlider GetSlider(object slider, string sliderName);
    }
}