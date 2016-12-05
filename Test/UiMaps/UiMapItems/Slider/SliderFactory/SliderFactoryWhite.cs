using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Slider.SliderFactory
{
    public class SliderFactoryWhite : ISliderFactory
    {
        ISlider ISliderFactory.GetSlider(object slider, string sliderName)
        {
            if(slider is TestStack.White.UIItems.Slider)
            {
                return this.ReturnSliderFromSliderWhite((TestStack.White.UIItems.Slider)slider, sliderName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private ISlider ReturnSliderFromSliderWhite(TestStack.White.UIItems.Slider slider, string sliderName)
        {
            return new SliderWhite(slider, sliderName);
        }
    }
}