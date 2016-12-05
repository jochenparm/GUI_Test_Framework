using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.List
{
    public interface IList
    {
        void Select(string itemName);

        bool IsSelected(string itemName);

        bool Exists(string itemName);

        string Selected_Item { get; }

        int Number_Of_Items { get; }
    }
}