using Castle.Core.Logging;
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
using TestStack.White.Configuration;
using TestStack.White.ScreenObjects;

//server type: IMAP
//server address: imap.gmail.com
//account username : guitestframework@gmail.com

//SMTP server address: smtp.gmail.com

namespace Test
{
    public static class MailWasher
    {
        private static Application _application;
        private static ScreenRepository _screenRepository;

        public static void Init()
        {
            Configure_White();
            Init_Logger();
            Launch_MailWasher();
        }

        public static void DeInit()
        {
            Close_MailWasher();
        }

        private static void Launch_MailWasher()
        {
            _application = Application.Launch(Constants.applicationPath);
            _screenRepository = new ScreenRepository(_application);
            Thread.Sleep(3250);
        }

        private static void Close_MailWasher()
        {
            _application.Close();
            Thread.Sleep(750);
        }

        private static void Init_Logger()
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Verbose().WriteTo.Console().CreateLogger();
        }

        private static void Configure_White()
        {
            CoreAppXmlConfiguration.Instance.LoggerFactory = new WhiteDefaultLoggerFactory(LoggerLevel.Off);
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
