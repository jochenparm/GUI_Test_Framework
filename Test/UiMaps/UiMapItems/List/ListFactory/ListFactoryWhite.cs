using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.List.ListFactory
{
    public class ListFactoryWhite : IListFactory
    {
        IList IListFactory.GetList(object list, string listName)
        {
            if(list is TestStack.White.UIItems.ListView)
            {
                return this.ReturnListFromListViewWhite((TestStack.White.UIItems.ListView)list, listName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private IList ReturnListFromListViewWhite(TestStack.White.UIItems.ListView list, string listName)
        {
            return new ListWhite(list, listName);
        }
    }
}