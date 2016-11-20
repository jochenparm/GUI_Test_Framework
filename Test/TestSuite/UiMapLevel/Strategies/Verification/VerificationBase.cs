using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class VerificationBase
    {
        private readonly Func<INavigator> _path;
        private readonly Action _precondition;

        public VerificationBase(Func<INavigator> path)
            : this(path, () => { })
        { }

        public VerificationBase(Func<INavigator> path, Action precondition)
        {
            this._path = path;
            this._precondition = precondition;
        }

        [SetUp]
        protected void SetUp()
        {
            MailWasher.Init();
            this._path();
            this._precondition();
        }

        [TearDown]
        protected void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}