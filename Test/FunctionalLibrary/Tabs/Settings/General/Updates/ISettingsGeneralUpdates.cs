using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Updates
{
    public interface ISettingsGeneralUpdates
    {
        ISettingsGeneralUpdates Automatically_Check_For_Updates(bool enable);

        ISettingsGeneralUpdates Set_Update_Frequency(int days);

        ISettingsGeneralUpdates Save();
    }
}