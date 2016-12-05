using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.List.ListFactory
{
    public interface IListFactory
    {
        IList GetList(object list, string listName);
    }
}