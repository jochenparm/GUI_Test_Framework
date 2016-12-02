using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.DropDownMenu
{
    public class DropDownMenuWhite : UiMapItemWhite, IDropDownMenu
    {
        private readonly TestStack.White.UIItems.ListBoxItems.ComboBox _comboBox;

        private readonly string _dropDownMenuName;

        public DropDownMenuWhite(TestStack.White.UIItems.ListBoxItems.ComboBox comboBox, string DropDownMenuName)
            : base(comboBox, DropDownMenuName)
        {
            this._comboBox = comboBox;
            this._dropDownMenuName = DropDownMenuName;
        }

        private void Select(string choice)
        {
            this._comboBox.Select(choice);
        }

        void IDropDownMenu.Select(string choice)
        {
            try
            {
                this.Select(choice);
                Log.Debug("Invoked {MethodName:l} method of {DropDownMenuName:l}", MethodBase.GetCurrentMethod().Name, this._dropDownMenuName);
            }
            catch(Exception)
            {
                Log.Fatal("Failed to invoke {MethodName:l} method of {DropDownMenuName:l}", MethodBase.GetCurrentMethod().Name, this._dropDownMenuName);
                throw;
            }
        }

        private string CurrentSelection
        {
            get
            {
                return this._comboBox.SelectedItemText;
            }
        }

        string IDropDownMenu.CurrentSelection
        {
            get
            {
                try
                {
                    string returnValue = this.CurrentSelection;
                    Log.Debug("Returned {PropertyName:l} property of {DropDownMenuName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._dropDownMenuName);
                    return returnValue;
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to return {PropertyName:l} property of {DropDownMenuName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._dropDownMenuName);
                    throw;
                }
            }
        }
    }
}