using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Button.ButtonFactory
{
    public class ButtonFactoryWhite : IButtonFactory
    {
        IButton IButtonFactory.GetButton(object button, string buttonName)
        {
            if(button is TestStack.White.UIItems.Button)
            {
                return this.ReturnButtonFromButtonWhite((TestStack.White.UIItems.Button)button, buttonName);
            }
            else if(button is TestStack.White.UIItems.Label)
            {
                return this.ReturnButtonFromLabelWhite((TestStack.White.UIItems.Label)button, buttonName);
            }
            else if(button is TestStack.White.UIItems.ListBoxItems.ListItem)
            {
                return this.ReturnButtonFromListItemWhite((TestStack.White.UIItems.ListBoxItems.ListItem)button, buttonName);
            }
            else if(button is TestStack.White.UIItems.MenuItems.Menu)
            {
                return this.ReturnButtonFromMenuItemWhite((TestStack.White.UIItems.MenuItems.Menu)button, buttonName);
            }
            else if(button is TestStack.White.UIItems.TabItems.TabPage)
            {
                return this.ReturnButtonFromTabPageWhite((TestStack.White.UIItems.TabItems.TabPage)button, buttonName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private IButton ReturnButtonFromButtonWhite(TestStack.White.UIItems.Button Button, string ButtonName)
        {
            return new ButtonWhite(Button, ButtonName);
        }

        private IButton ReturnButtonFromLabelWhite(TestStack.White.UIItems.Label label, string ButtonName)
        {
            return new LabelToButtonWhite(label, ButtonName);
        }

        private IButton ReturnButtonFromListItemWhite(TestStack.White.UIItems.ListBoxItems.ListItem listItem, string ButtonName)
        {
            return new ListItemToButtonWhite(listItem, ButtonName);
        }

        private IButton ReturnButtonFromMenuItemWhite(TestStack.White.UIItems.MenuItems.Menu MenuItem, string ButtonName)
        {
            return new MenuItemToButtonWhite(MenuItem, ButtonName);
        }

        private IButton ReturnButtonFromTabPageWhite(TestStack.White.UIItems.TabItems.TabPage tabPage, string ButtonName)
        {
            return new TabPageToButtonWhite(tabPage, ButtonName);
        }
    }
}