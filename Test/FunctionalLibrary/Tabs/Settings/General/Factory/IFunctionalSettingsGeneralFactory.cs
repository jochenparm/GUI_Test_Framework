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

namespace Test.FunctionalLibrary.Tabs.Settings.General.Factory
{
    internal interface IFunctionalSettingsGeneralFactory
    {
        ISettingsGeneralApplication Get_Application();

        ISettingsGeneralCheckingMail Get_Checking_Mail();

        ISettingsGeneralNotifications Get_Notifications();

        ISettingsGeneralPerformance Get_Performance();

        ISettingsGeneralUpdates Get_Updates();

        ISettingsGeneralWashingMail Get_Washing_Mail();
    }
}