using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.Button;
using Test.UiMaps.UiMapItems.Button.ButtonFactory;
using Test.UiMaps.UiMapItems.CheckBox;
using Test.UiMaps.UiMapItems.CheckBox.CheckBoxFactory;
using Test.UiMaps.UiMapItems.DropDownMenu;
using Test.UiMaps.UiMapItems.DropDownMenu.DropDownMenuFactory;
using Test.UiMaps.UiMapItems.List;
using Test.UiMaps.UiMapItems.List.ListFactory;
using Test.UiMaps.UiMapItems.RadioButton;
using Test.UiMaps.UiMapItems.RadioButton.RadioButtonFactory;
using Test.UiMaps.UiMapItems.Slider;
using Test.UiMaps.UiMapItems.Slider.SliderFactory;
using Test.UiMaps.UiMapItems.Tab;
using Test.UiMaps.UiMapItems.Tab.TabFactory;
using Test.UiMaps.UiMapItems.TextBox;
using Test.UiMaps.UiMapItems.TextBox.TextBoxFactory;
using Test.UiMaps.UiMapItems.TextLabel;
using Test.UiMaps.UiMapItems.TextLabel.TextLabelFactory;

namespace Test.UiMaps.UiMapItems.UiMapItemsFactory
{
    public class UiMapItemsFactoryWhite : IUiMapItemsFactory
    {
        private readonly IButtonFactory _buttonFactory;
        private readonly ICheckBoxFactory _checkBoxFactory;
        private readonly IDropDownMenuFactory _dropDownMenuFactory;
        private readonly IListFactory _listFactory;
        private readonly IRadioButtonFactory _radioButtonFactory;
        private readonly ISliderFactory _sliderFactory;
        private readonly ITabFactory _tabFactory;
        private readonly ITextBoxFactory _textBoxFactory;
        private readonly ITextLabelFactory _textLabelFactory;

        public UiMapItemsFactoryWhite()
        {
            this._buttonFactory = new ButtonFactoryWhite();
            this._checkBoxFactory = new CheckBoxFactoryWhite();
            this._dropDownMenuFactory = new DropDownMenuFactoryWhite();
            this._listFactory = new ListFactoryWhite();
            this._radioButtonFactory = new RadioButtonFactoryWhite();
            this._sliderFactory = new SliderFactoryWhite();
            this._tabFactory = new TabFactoryWhite();
            this._textBoxFactory = new TextBoxFactoryWhite();
            this._textLabelFactory = new TextLabelFactoryWhite();
        }

        private IButton GetButton(object button, string buttonName)
        {
            return this._buttonFactory.GetButton(button, buttonName);
        }

        IButton IButtonFactory.GetButton(object button, string buttonName)
        {
            return this.GetButton(button, buttonName);
        }

        private ICheckBox GetCheckBox(object checkBox, string checkBoxName)
        {
            return this._checkBoxFactory.GetCheckBox(checkBox, checkBoxName);
        }

        ICheckBox ICheckBoxFactory.GetCheckBox(object checkBox, string checkBoxName)
        {
            return this.GetCheckBox(checkBox, checkBoxName);
        }

        private IDropDownMenu GetDropDownMenu(object dropDownMenu, string dropDownMenuName)
        {
            return this._dropDownMenuFactory.GetDropDownMenu(dropDownMenu, dropDownMenuName);
        }

        IDropDownMenu IDropDownMenuFactory.GetDropDownMenu(object dropDownMenu, string dropDownMenuName)
        {
            return this.GetDropDownMenu(dropDownMenu, dropDownMenuName);
        }

        private IList GetList(object list, string listName)
        {
            return this._listFactory.GetList(list, listName);
        }

        IList IListFactory.GetList(object list, string listName)
        {
            return this.GetList(list, listName);
        }

        private IRadioButton GetRadioButton(object radioButton, string radioButtonName)
        {
            return this._radioButtonFactory.GetRadioButton(radioButton, radioButtonName);
        }

        IRadioButton IRadioButtonFactory.GetRadioButton(object radioButton, string radioButtonName)
        {
            return this.GetRadioButton(radioButton, radioButtonName);
        }

        private ISlider GetSlider(object slider, string sliderName)
        {
            return this._sliderFactory.GetSlider(slider, sliderName);
        }

        ISlider ISliderFactory.GetSlider(object slider, string sliderName)
        {
            return this.GetSlider(slider, sliderName);
        }

        private ITab GetTab(object tab, string tabName)
        {
            return this._tabFactory.GetTab(tab, tabName);
        }

        ITab ITabFactory.GetTab(object tab, string tabName)
        {
            return this.GetTab(tab, tabName);
        }

        private ITextBox GetTextBox(object textBox, string textBoxName)
        {
            return this._textBoxFactory.GetTextBox(textBox, textBoxName);
        }

        ITextBox ITextBoxFactory.GetTextBox(object textBox, string textBoxName)
        {
            return this.GetTextBox(textBox, textBoxName);
        }

        private ITextLabel GetTextLabel(object textLabel, string textLabelName)
        {
            return this._textLabelFactory.GetTextLabel(textLabel, textLabelName);
        }

        ITextLabel ITextLabelFactory.GetTextLabel(object textLabel, string textLabelName)
        {
            return this.GetTextLabel(textLabel, textLabelName);
        }
    }
}