using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test.FunctionalLibrary;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps;
using TestStack.White;
using TestStack.White.ScreenObjects;

namespace Test
{
    public static class MailWasher
    {
        private static Application _application;
        private static ScreenRepository _screenRepository;

        public static void Init()
        {
            Log.Logger = new LoggerConfiguration()
                                    .WriteTo.Console()
                                    .CreateLogger();
            Log.Information("Launched MailWasher Free");
            _application = Application.Launch(Constants.applicationPath);
            _screenRepository = new ScreenRepository(_application);
            Thread.Sleep(3250);
        }

        public static void DeInit()
        {
            _application.Close();
            Log.Information("Closed MailWasher Free");
            Thread.Sleep(750);
        }

        public static IUiMap UiMap
        {
            get
            {
                return new UiMap(_screenRepository);
            }
        }

        public static INavigator Navigator
        {
            get
            {
                return new Navigator();
            }
        }

        public static IMain Main
        {
            get
            {
                return new Main();
            }
        }
    }
}