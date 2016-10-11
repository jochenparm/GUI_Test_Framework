using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class MenuItemToButtonWhite : UiMapItemWhite, IButton
    {
        private readonly TestStack.White.UIItems.MenuItems.Menu _menuItem;

        public MenuItemToButtonWhite(TestStack.White.UIItems.MenuItems.Menu menuItem)
            : base(menuItem)
        {
            this._menuItem = menuItem;
        }
    }
}