using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Settings.RecycleBin.General;
using Test.FunctionalLibrary.Navigator.Settings.RecycleBin.Restoring;

namespace Test.FunctionalLibrary.Navigator.Settings.RecycleBin
{
    public interface IRecycleBin : INavigatorBase
    {
        IGeneral General { get; }
        IRestoring Restoring { get; }
    }
}