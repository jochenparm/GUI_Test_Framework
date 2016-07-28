using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator
{
    public abstract class NavigatorBase : INavigatorBase
    {
        public INavigator Navigate()
        {
            return new Navigator();
        }
    }
}