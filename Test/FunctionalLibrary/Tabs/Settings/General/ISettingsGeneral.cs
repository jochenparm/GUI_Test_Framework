using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Settings.General.Application;
using Test.FunctionalLibrary.Tabs.Settings.General.Checking_Mail;
using Test.FunctionalLibrary.Tabs.Settings.General.Notifications;
using Test.FunctionalLibrary.Tabs.Settings.General.Performance;
using Test.FunctionalLibrary.Tabs.Settings.General.Updates;
using Test.FunctionalLibrary.Tabs.Settings.General.Washing_Mail;

namespace Test.FunctionalLibrary.Tabs.Settings.General
{
    public interface ISettingsGeneral
    {
        ISettingsGeneralApplication Application { get; }
        ISettingsGeneralCheckingMail Checking_Mail { get; }
        ISettingsGeneralNotifications Notifications { get; }
        ISettingsGeneralPerformance Performance { get; }
        ISettingsGeneralUpdates Updates { get; }
        ISettingsGeneralWashingMail Washing_Mail { get; }
    }
}