using Serilog;
using System;
using System.Reflection;

namespace Test.UiMaps.UiMapItems.CheckBox
{
    public class CheckBoxWhite : UiMapItemWhite, ICheckBox
    {
        private readonly TestStack.White.UIItems.CheckBox _checkBox;

        private readonly string _checkBoxName;

        public CheckBoxWhite(TestStack.White.UIItems.CheckBox checkBox, string CheckBoxName)
            : base(checkBox, CheckBoxName)
        {
            this._checkBox = checkBox;
            this._checkBoxName = CheckBoxName;
        }

        private bool IsEnabled
        {
            get
            {
                return this._checkBox.Checked;
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

        private void Enable()
        {
            if(!this.IsEnabled)
            {
                this._checkBox.Checked = true;
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

        private void Disable()
        {
            if(this.IsEnabled)
            {
                this._checkBox.Checked = false;
            }
        }

        void ICheckBox.Disable()
        {
            try
            {
                this.Disable();
                Log.Debug("Invoked {PropertyName:l} method of {CheckBoxName:l}", MethodBase.GetCurrentMethod().Name, this._checkBoxName);
            }
            catch(Exception)
            {
                Log.Fatal("Failed to invoke {PropertyName:l} method of {CheckBoxName:l}", MethodBase.GetCurrentMethod().Name, this._checkBoxName);
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