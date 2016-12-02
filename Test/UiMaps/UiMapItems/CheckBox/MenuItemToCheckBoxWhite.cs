using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        private readonly string _checkBoxName;

        public MenuItemToCheckBoxWhite(TestStack.White.UIItems.MenuItems.Menu menuItem, string CheckBoxName)
            : base(menuItem, CheckBoxName)
        {
            this._menuItem = menuItem;

            this._checkBoxName = CheckBoxName;
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
                try
                {
                    bool returnValue = this.IsEnabled;
                    Log.Debug("Returned {PropertyName:l} property of {CheckBoxName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._checkBoxName);
                    return returnValue;
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to return {PropertyName:l} property of {CheckBoxName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._checkBoxName);
                    throw;
                }
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
            try
            {
                this.Disable();
                Log.Debug("Invoked {MethodName:l} method of {CheckBoxName:l}", MethodBase.GetCurrentMethod().Name, this._checkBoxName);
            }
            catch(Exception)
            {
                Log.Fatal("Failed to invoke {MethodName:l} method of {CheckBoxName:l}", MethodBase.GetCurrentMethod().Name, this._checkBoxName);
                throw;
            }
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
            try
            {
                this.Enable();
                Log.Debug("Invoked {MethodName:l} method of {CheckBoxName:l}", MethodBase.GetCurrentMethod().Name, this._checkBoxName);
            }
            catch(Exception)
            {
                Log.Fatal("Failed to invoke {MethodName:l} method of {CheckBoxName:l}", MethodBase.GetCurrentMethod().Name, this._checkBoxName);
                throw;
            }
        }

        private void Set(bool enable)
        {
            if(enable)
            {
                this.Enable();
            }
            else
            {
                this.Disable();
            }
        }

        void ICheckBox.Set(bool enable)
        {
            this.Set(enable);
        }
    }
}