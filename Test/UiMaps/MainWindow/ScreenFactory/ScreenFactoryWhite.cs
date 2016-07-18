using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.ScreenFactory
{
    internal class ScreenFactoryWhite : IScreenFactory
    {
        private readonly ScreenRepository screenRepository;
        public ScreenFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }
    }
}
