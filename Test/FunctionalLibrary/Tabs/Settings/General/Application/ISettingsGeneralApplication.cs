using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Application
{
    public enum FontOptions
    {
        Segoe,
        Arial,
        Verdana,
        Helvetica
    }

    public enum MinimizeDestinations
    {
        System_Tray,
        Task_Bar
    }

    public interface ISettingsGeneralApplication
    {
        ISettingsGeneralApplication Select_Font(FontOptions font);

        ISettingsGeneralApplication Startup_With_Windows(bool enable);

        ISettingsGeneralApplication Minimize_MailWasher_When_X_Clicked(bool enable);

        ISettingsGeneralApplication Minimize_MailWasher_When_Mail_Program_Launched(bool enable);

        ISettingsGeneralApplication Start_MailWasher_Minimized(bool enable);

        ISettingsGeneralApplication Minimize_MailWasher_To(MinimizeDestinations destination);

        ISettingsGeneralApplication Reset_MailWasher_HotKey();

        ISettingsGeneralApplication Save();
    }
}