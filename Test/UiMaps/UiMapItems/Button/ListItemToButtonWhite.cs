using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class ListItemToButtonWhite : UiMapItemWhite, IButton
    {
        private readonly TestStack.White.UIItems.ListBoxItems.ListItem _listItem;

        private readonly string _buttonName;

        public ListItemToButtonWhite(TestStack.White.UIItems.ListBoxItems.ListItem listItem, string ButtonName)
            : base(listItem, ButtonName)
        {
            this._listItem = listItem;
            this._buttonName = ButtonName;
        }
    }
}