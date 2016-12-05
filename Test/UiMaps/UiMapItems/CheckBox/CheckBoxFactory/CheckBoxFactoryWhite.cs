using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.CheckBox.CheckBoxFactory
{
    public class CheckBoxFactoryWhite : ICheckBoxFactory
    {
        ICheckBox ICheckBoxFactory.GetCheckBox(object checkBox, string checkBoxName)
        {
            if(checkBox is TestStack.White.UIItems.CheckBox)
            {
                return this.ReturnCheckBoxFromCheckBoxWhite((TestStack.White.UIItems.CheckBox)checkBox, checkBoxName);
            }
            else if(checkBox is TestStack.White.UIItems.MenuItems.Menu)
            {
                return this.ReturnCheckBoxFromMenuItemWhite((TestStack.White.UIItems.MenuItems.Menu)checkBox, checkBoxName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private ICheckBox ReturnCheckBoxFromCheckBoxWhite(TestStack.White.UIItems.CheckBox checkBox, string checkBoxName)
        {
            return new CheckBoxWhite(checkBox, checkBoxName);
        }

        private ICheckBox ReturnCheckBoxFromMenuItemWhite(TestStack.White.UIItems.MenuItems.Menu menuItem, string checkBoxName)
        {
            return new MenuItemToCheckBoxWhite(menuItem, checkBoxName);
        }
    }
}