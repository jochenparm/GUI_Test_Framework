namespace Test.UiMaps.UiMapItems.CheckBox
{
    public class CheckBoxWhite : ICheckBox
    {
        private TestStack.White.UIItems.CheckBox _checkBox;

        public CheckBoxWhite(TestStack.White.UIItems.CheckBox checkBox)
        {
            this._checkBox = checkBox;
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
                return this.IsEnabled;
            }
        }

        private void Enable()
        {
            if (!this.IsEnabled)
            {
                this._checkBox.Checked = true;
            }
        }

        void ICheckBox.Enable()
        {
            this.Enable();
        }

        private void Disable()
        {
            if (this.IsEnabled)
            {
                this._checkBox.Checked = false;
            }
        }

        void ICheckBox.Disable()
        {
            this.Disable();
        }

        private bool IsOnScreen
        {
            get
            {
                return !(this._checkBox.IsOffScreen);
            }
        }

        bool ICheckBox.IsOnScreen
        {
            get
            {
                return this.IsOnScreen;
            }
        }
    }
}