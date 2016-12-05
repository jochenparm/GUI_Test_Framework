using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Application;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.CheckingMail;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Notifications;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Performance;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Updates;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.WashingMail;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.General
{
    public interface IGeneralNavigator : INavigatorBase
    {
        IApplicationNavigator Application { get; }
        ICheckingMailNavigator Checking_Mail { get; }
        INotificationsNavigator Notifications { get; }
        IPerformanceNavigator Performance { get; }
        IUpdatesNavigator Updates { get; }
        IWashingMailNavigator Washing_Mail { get; }
    }
}