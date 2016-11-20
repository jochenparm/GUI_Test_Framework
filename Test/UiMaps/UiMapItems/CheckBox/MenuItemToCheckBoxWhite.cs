using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using Test.UiMaps.UiMapItems.Button;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Test.UiMaps.UiMapItems.CheckBox
{
    public class MenuItemToCheckBoxWhite : UiMapItemWhite, ICheckBox
    {
        private readonly TestStack.White.UIItems.MenuItems.Menu _menuItem;

        public MenuItemToCheckBoxWhite(TestStack.White.UIItems.MenuItems.Menu menuItem)
            : base(menuItem)
        {
            this._menuItem = menuItem;
        }

        private TogglePattern CurrentTogglePattern
        {
            get
            {
                return (TogglePattern)this._menuItem.AutomationElement.GetCurrentPattern(TogglePattern.Pattern);
            }
        }

        private bool IsEnabled
        {
            get
            {
                return this.CurrentTogglePattern.Current.ToggleState.Equals(ToggleState.On);
            }
        }

        bool ICheckBox.IsEnabled
        {
            get
            {
                return this.IsEnabled;
            }
        }

        private void Disable()
        {
            if(this.IsEnabled)
            {
                base.Click();
            }
        }

        void ICheckBox.Disable()
        {
            this.Disable();
        }

        private void Enable()
        {
            if(!this.IsEnabled)
            {
                base.Click();
            }
        }

        void ICheckBox.Enable()
        {
            this.Enable();
        }
    }
}