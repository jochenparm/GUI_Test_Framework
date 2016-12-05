using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.RadioButton.RadioButtonFactory
{
    public interface IRadioButtonFactory
    {
        IRadioButton GetRadioButton(object radioButton, string radioButtonName);
    }
}