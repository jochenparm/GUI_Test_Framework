using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.RadioButton
{
    public class RadioButtonWhite : IRadioButton
    {
        private TestStack.White.UIItems.RadioButton _radioButton;

        public RadioButtonWhite(TestStack.White.UIItems.RadioButton radioButton)
        {
            this._radioButton = radioButton;
        }

        private void Select()
        {
            this._radioButton.Select();
        }

        void IRadioButton.Select()
        {
            this.Select();
        }

        private bool IsSelected
        {
            get
            {
                return this._radioButton.IsSelected;
            }
        }

        bool IRadioButton.IsSelected
        {
            get
            {
                return this.IsSelected;
            }
        }

        private bool IsOnScreen
        {
            get
            {
                return !(this._radioButton.IsOffScreen);
            }
        }

        bool IRadioButton.IsOnScreen
        {
            get
            {
                return this.IsOnScreen;
            }
        }

        private bool IsEnabled
        {
            get
            {
                return this._radioButton.Enabled;
            }
        }

        bool IRadioButton.IsEnabled
        {
            get
            {
                return this.IsEnabled;
            }
        }
    }
}