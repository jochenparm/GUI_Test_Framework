using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Slider
{
    public class SliderWhite : UiMapItemWhite, ISlider
    {
        private TestStack.White.UIItems.Slider _slider;

        public SliderWhite(TestStack.White.UIItems.Slider slider)
            : base(slider)
        {
            this._slider = slider;
        }

        public void Set_Max()
        {
            this._slider.SetValue(this._slider.Maximum);
        }

        public void Set_Min()
        {
            this._slider.SetValue(this._slider.Minimum);
        }

        public int Value
        {
            get
            {
                return Convert.ToInt32(this._slider.Value);
            }
            set
            {
                this._slider.SetValue(Convert.ToDouble(value));
            }
        }
    }
}