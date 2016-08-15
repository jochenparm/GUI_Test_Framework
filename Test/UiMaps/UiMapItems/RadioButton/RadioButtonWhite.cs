using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.RadioButton
{
    public class RadioButtonWhite : UiMapItemWhite, IRadioButton
    {
        private TestStack.White.UIItems.RadioButton _radioButton;

        public RadioButtonWhite(TestStack.White.UIItems.RadioButton radioButton)
            : base(radioButton)
        {
            this._radioButton = radioButton;
        }

        public void Select()
        {
            this._radioButton.Select();
        }

        public bool IsSelected
        {
            get
            {
                return this._radioButton.IsSelected;
            }
        }
    }
}