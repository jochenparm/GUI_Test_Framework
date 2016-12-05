using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.DropDownMenu.DropDownMenuFactory
{
    public class DropDownMenuFactoryWhite : IDropDownMenuFactory
    {
        IDropDownMenu IDropDownMenuFactory.GetDropDownMenu(object dropDownMenu, string dropDownMenuName)
        {
            if(dropDownMenu is TestStack.White.UIItems.ListBoxItems.ComboBox)
            {
                return this.ReturnDropDownMenuFromComboBoxWhite((TestStack.White.UIItems.ListBoxItems.ComboBox)dropDownMenu, dropDownMenuName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private IDropDownMenu ReturnDropDownMenuFromComboBoxWhite(TestStack.White.UIItems.ListBoxItems.ComboBox comboBox, string dropDownMenuName)
        {
            return new DropDownMenuWhite(comboBox, dropDownMenuName);
        }
    }
}