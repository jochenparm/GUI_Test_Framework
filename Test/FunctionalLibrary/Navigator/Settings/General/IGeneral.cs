using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Settings.General.Application;
using Test.FunctionalLibrary.Navigator.Settings.General.CheckingMail;
using Test.FunctionalLibrary.Navigator.Settings.General.Notifications;
using Test.FunctionalLibrary.Navigator.Settings.General.Performance;
using Test.FunctionalLibrary.Navigator.Settings.General.Updates;
using Test.FunctionalLibrary.Navigator.Settings.General.WashingMail;

namespace Test.FunctionalLibrary.Navigator.Settings.General
{
    public interface IGeneral : INavigatorBase
    {
        IApplication Application { get; }
        ICheckingMail Checking_Mail { get; }
        INotifications Notifications { get; }
        IPerformance Performance { get; }
        IUpdates Updates { get; }
        IWashingMail Washing_Mail { get; }
    }
}