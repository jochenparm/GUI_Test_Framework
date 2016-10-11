namespace Test.UiMaps.UiMapItems.CheckBox
{
    public class CheckBoxWhite : UiMapItemWhite, ICheckBox
    {
        private readonly TestStack.White.UIItems.CheckBox _checkBox;

        public CheckBoxWhite(TestStack.White.UIItems.CheckBox checkBox)
            : base(checkBox)
        {
            this._checkBox = checkBox;
        }

        public bool IsEnabled
        {
            get
            {
                return this._checkBox.Checked;
            }
        }

        public void Enable()
        {
            if(!this.IsEnabled)
            {
                this._checkBox.Checked = true;
            }
        }

        public void Disable()
        {
            if(this.IsEnabled)
            {
                this._checkBox.Checked = false;
            }
        }
    }
}