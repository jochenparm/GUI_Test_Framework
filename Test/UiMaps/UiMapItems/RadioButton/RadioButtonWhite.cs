using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.RadioButton
{
    public class RadioButtonWhite : UiMapItemWhite, IRadioButton
    {
        private readonly TestStack.White.UIItems.RadioButton _radioButton;

        private readonly string _radioButtonName;

        public RadioButtonWhite(TestStack.White.UIItems.RadioButton radioButton, string RadioButtonName)
            : base(radioButton, RadioButtonName)
        {
            this._radioButton = radioButton;
            this._radioButtonName = RadioButtonName;
        }

        private void Select()
        {
            this._radioButton.Select();
        }

        void IRadioButton.Select()
        {
            try
            {
                this.Select();
                Log.Debug("Invoked {MethodName:l} method of {DropDownMenuName:l}", MethodBase.GetCurrentMethod().Name, this._radioButtonName);
            }
            catch(Exception)
            {
                Log.Fatal("Failed to invoke {MethodName:l} method of {DropDownMenuName:l}", MethodBase.GetCurrentMethod().Name, this._radioButtonName);
                throw;
            }
        }

        private bool IsSelected
        {
            get
            {
                return this._radioButton.IsSelected;
            }
        }

        bool IRadioButton.IsSelected
        {
            get
            {
                try
                {
                    bool returnValue = this.IsSelected;
                    Log.Debug("Returned {PropertyName:l} property of {RadioButtonName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._radioButtonName);
                    return returnValue;
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to return {PropertyName:l} property of {RadioButtonName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._radioButtonName);
                    throw;
                }
            }
        }
    }
}