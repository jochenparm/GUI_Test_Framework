using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.DropDownMenu
{
    public class DropDownMenuWhite : IDropDownMenu
    {
        private TestStack.White.UIItems.ListBoxItems.ComboBox _comboBox;

        public DropDownMenuWhite(TestStack.White.UIItems.ListBoxItems.ComboBox comboBox)
        {
            this._comboBox = comboBox;
        }

        private void Select(string choice)
        {
            this._comboBox.Select(choice);
        }

        void IDropDownMenu.Select(string choice)
        {
            this.Select(choice);
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
                return this.CurrentSelection;
            }
        }

        private bool IsOnScreen
        {
            get
            {
                return !(this._comboBox.IsOffScreen);
            }
        }

        bool IDropDownMenu.IsOnScreen
        {
            get
            {
                return this.IsOnScreen;
            }
        }

        private bool IsEnabled
        {
            get
            {
                return this._comboBox.Enabled;
            }
        }

        bool IDropDownMenu.IsEnabled
        {
            get
            {
                return this.IsEnabled;
            }
        }
    }
}