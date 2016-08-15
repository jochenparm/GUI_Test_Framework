using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.RadioButton
{
    public interface IRadioButton : IUiMapItem
    {
        void Select();

        bool IsSelected { get; }
    }
}