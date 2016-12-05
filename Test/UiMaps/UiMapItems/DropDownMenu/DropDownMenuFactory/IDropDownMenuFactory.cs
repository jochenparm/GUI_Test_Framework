using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.DropDownMenu.DropDownMenuFactory
{
    public interface IDropDownMenuFactory
    {
        IDropDownMenu GetDropDownMenu(object dropDownMenu, string dropDownMenuName);
    }
}