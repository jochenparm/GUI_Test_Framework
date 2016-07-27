using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.RadioButton
{
    public interface IRadioButton
    {
        void Select();

        bool IsSelected { get; }
        bool IsOnScreen { get; }
        bool IsEnabled { get; }
    }
}