using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.CheckBox.CheckBoxFactory
{
    public interface ICheckBoxFactory
    {
        ICheckBox GetCheckBox(object checkBox, string checkBoxName);
    }
}