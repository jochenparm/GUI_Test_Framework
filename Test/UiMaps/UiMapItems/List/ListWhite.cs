using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.List
{
    public class ListWhite : UiMapItemWhite, IList
    {
        private readonly TestStack.White.UIItems.ListView _list;

        private readonly string _listName;

        public ListWhite(TestStack.White.UIItems.ListView list, string ListName)
            : base(list, ListName)
        {
            this._list = list;
            this._listName = ListName;
        }

        private int Number_Of_Items
        {
            get
            {
                return this._list.Items.Count;
            }
        }

        int IList.Number_Of_Items
        {
            get
            {
                return this.Number_Of_Items;
            }
        }

        private string Selected_Item
        {
            get
            {
                return this._list.SelectedRows[0].Name;
            }
        }

        string IList.Selected_Item
        {
            get
            {
                return this.Selected_Item;
            }
        }

        private bool Exists(string itemName)
        {
            return this._list.Rows.Exists(x => x.Name.Equals("itemName"));
        }

        bool IList.Exists(string itemName)
        {
            return this.Exists(itemName);
        }

        private bool IsSelected(string itemName)
        {
            return Selected_Item.Equals(itemName);
        }

        bool IList.IsSelected(string itemName)
        {
            return this.IsSelected(itemName);
        }

        private void Select(string itemName)
        {
            this._list.Select(itemName);
        }

        void IList.Select(string itemName)
        {
            this.Select(itemName);
        }
    }
}