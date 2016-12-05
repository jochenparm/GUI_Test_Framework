using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.Button.ButtonFactory;
using Test.UiMaps.UiMapItems.CheckBox.CheckBoxFactory;
using Test.UiMaps.UiMapItems.DropDownMenu.DropDownMenuFactory;
using Test.UiMaps.UiMapItems.List.ListFactory;
using Test.UiMaps.UiMapItems.RadioButton.RadioButtonFactory;
using Test.UiMaps.UiMapItems.Slider.SliderFactory;
using Test.UiMaps.UiMapItems.Tab.TabFactory;
using Test.UiMaps.UiMapItems.TextBox.TextBoxFactory;
using Test.UiMaps.UiMapItems.TextLabel.TextLabelFactory;

namespace Test.UiMaps.UiMapItems.UiMapItemsFactory
{
    public interface IUiMapItemsFactory : IButtonFactory, ICheckBoxFactory, IDropDownMenuFactory,
        IListFactory, IRadioButtonFactory, ISliderFactory, ITabFactory, ITextBoxFactory, ITextLabelFactory
    {
    }
}