using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Menu.File
{
    public interface IFile
    {
        IFile Check_Mail();

        IFile Wash_Mail();

        IFile Mail_Program();

        IFile Import();

        IFile Export();

        IFile Exit();
    }
}