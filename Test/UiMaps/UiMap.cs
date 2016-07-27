using System.Threading;
using Test.UiMaps.MainWindow;
using Test.UiMaps.ScreenFactory;
using TestStack.White;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps
{
    public static class UiMap
    {
        private static Application _application;
        private static ScreenRepository _screenRepository;
        private static IScreenFactory _screenFactory;

        public static void Init()
        {
            _application = Application.Launch(Constants.applicationPath);
            _screenRepository = new ScreenRepository(_application);
            _screenFactory = new ScreenFactoryWhite(_screenRepository);
            Thread.Sleep(7000);
        }

        public static void DeInit()
        {
            _application.Close();
            Thread.Sleep(2000);
        }

        public static IMainWindowScreen MainWindow
        {
            get
            {
                return _screenFactory.PopulateMainWindowScreen();
            }
        }
    }
}