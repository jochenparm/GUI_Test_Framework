using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.DropDownMenu
{
    public class DropDownMenuWhite : UiMapItemWhite, IDropDownMenu
    {
        private readonly TestStack.White.UIItems.ListBoxItems.ComboBox _comboBox;

        public DropDownMenuWhite(TestStack.White.UIItems.ListBoxItems.ComboBox comboBox)
            : base(comboBox)
        {
            this._comboBox = comboBox;
        }

        public void Select(string choice)
        {
            this._comboBox.Select(choice);
        }

        public string CurrentSelection
        {
            get
            {
                return this._comboBox.SelectedItemText;
            }
        }
    }
}