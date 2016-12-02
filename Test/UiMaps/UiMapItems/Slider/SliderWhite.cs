using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Slider
{
    public class SliderWhite : UiMapItemWhite, ISlider
    {
        private readonly TestStack.White.UIItems.Slider _slider;

        private readonly string _sliderName;

        public SliderWhite(TestStack.White.UIItems.Slider slider, string SliderName)
            : base(slider, SliderName)
        {
            this._slider = slider;
            this._sliderName = SliderName;
        }

        private void Set_Max()
        {
            this._slider.SetValue(this._slider.Maximum);
        }

        void ISlider.Set_Max()
        {
            try
            {
                this.Set_Max();
                Log.Debug("Invoked {MethodName:l} method of {SliderName:l}", MethodBase.GetCurrentMethod().Name, this._sliderName);
            }
            catch(Exception)
            {
                Log.Fatal("Failed to invoke {MethodName:l} method of {SliderName:l}", MethodBase.GetCurrentMethod().Name, this._sliderName);
                throw;
            }
        }

        private void Set_Min()
        {
            this._slider.SetValue(this._slider.Minimum);
        }

        void ISlider.Set_Min()
        {
            try
            {
                this.Set_Min();
                Log.Debug("Invoked {MethodName:l} method of {SliderName:l}", MethodBase.GetCurrentMethod().Name, this._sliderName);
            }
            catch(Exception)
            {
                Log.Fatal("Failed to invoke {MethodName:l} method of {SliderName:l}", MethodBase.GetCurrentMethod().Name, this._sliderName);
                throw;
            }
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
                try
                {
                    int returnValue = this.Value;
                    Log.Debug("Returned {PropertyName:l} property of {SliderName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._sliderName);
                    return returnValue;
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to return {PropertyName:l} property of {SliderName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._sliderName);
                    throw;
                }
            }
            set
            {
                try
                {
                    this.Value = value;
                    Log.Debug("Set {PropertyName:l} property of {SliderName:l}", MethodBase.GetCurrentMethod().Name.Replace("set_", ""), this._sliderName);
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to set {PropertyName:l} property of {SliderName:l}", MethodBase.GetCurrentMethod().Name.Replace("set_", ""), this._sliderName);
                    throw;
                }
            }
        }
    }
}