using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Slider
{
    public class SliderWhite : ISlider
    {
        private TestStack.White.UIItems.Slider _slider;

        public SliderWhite(TestStack.White.UIItems.Slider slider)
        {
            this._slider = slider;
        }

        private void Set_Max()
        {
            this._slider.SetValue(this._slider.Maximum);
        }

        void ISlider.Set_Max()
        {
            this.Set_Max();
        }

        private void Set_Min()
        {
            this._slider.SetValue(this._slider.Minimum);
        }

        void ISlider.Set_Min()
        {
            this.Set_Min();
        }

        private int Value
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

        int ISlider.Value
        {
            get
            {
                return this.Value;
            }
            set
            {
                this.Value = value;
            }
        }
    }
}