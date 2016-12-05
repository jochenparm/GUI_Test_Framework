using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.RadioButton.RadioButtonFactory
{
    public class RadioButtonFactoryWhite : IRadioButtonFactory
    {
        IRadioButton IRadioButtonFactory.GetRadioButton(object radioButton, string radioButtonName)
        {
            if(radioButton is TestStack.White.UIItems.RadioButton)
            {
                return this.ReturnRadioButtonFromRadioButtonWhite((TestStack.White.UIItems.RadioButton)radioButton, radioButtonName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private IRadioButton ReturnRadioButtonFromRadioButtonWhite(TestStack.White.UIItems.RadioButton radioButton, string radioButtonName)
        {
            return new RadioButtonWhite(radioButton, radioButtonName);
        }
    }
}