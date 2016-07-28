using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.ScreenFactory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps
{
    public class UiMap : IUiMap
    {
        private readonly ScreenRepository _screenRepository;
        private readonly IScreenFactory _screenFactory;

        public UiMap(ScreenRepository screenRepository)
        {
            this._screenRepository = screenRepository;
            this._screenFactory = new ScreenFactoryWhite(this._screenRepository);
        }

        MainWindow.IMainWindowScreen IUiMap.MainWindow
        {
            get
            {
                return this._screenFactory.PopulateMainWindowScreen();
            }
        }
    }
}