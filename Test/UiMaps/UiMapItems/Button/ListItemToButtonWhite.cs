using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class ListItemToButtonWhite : UiMapItemWhite, IButton
    {
        private readonly TestStack.White.UIItems.ListBoxItems.ListItem _listItem;

        public ListItemToButtonWhite(TestStack.White.UIItems.ListBoxItems.ListItem listItem)
            : base(listItem)
        {
            this._listItem = listItem;
        }
    }
}