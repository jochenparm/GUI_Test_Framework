using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class MenuItemToButtonWhite : UiMapItemWhite, IButton
    {
        private readonly TestStack.White.UIItems.MenuItems.Menu _menuItem;

        private readonly string _buttonName;

        public MenuItemToButtonWhite(TestStack.White.UIItems.MenuItems.Menu MenuItem, string ButtonName)
            : base(MenuItem, ButtonName)
        {
            this._menuItem = MenuItem;
            this._buttonName = ButtonName;
        }
    }
}