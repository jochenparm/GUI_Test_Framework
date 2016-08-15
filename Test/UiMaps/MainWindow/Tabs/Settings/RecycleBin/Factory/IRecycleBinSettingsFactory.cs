using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.General;
using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.Restoring;

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.Factory
{
    internal interface IRecycleBinSettingsFactory
    {
        IRecycleBinGeneralScreen PopulateRecycleBinGeneralScreen();

        IRecycleBinRestoringScreen PopulateRecycleBinRestoringScreen();
    }
}