using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Application;
using Test.UiMaps.MainWindow.Tabs.Settings.General.CheckingMail;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Factory
{
    public interface IGeneralSettingsFactory
    {
        IGeneralApplicationScreen PopulateGeneralApplicationScreen();

        IGeneralCheckingMailScreen PopulateGeneralCheckingMailScreen();
    }
}