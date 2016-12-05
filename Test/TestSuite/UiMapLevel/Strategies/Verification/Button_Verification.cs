using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps.UiMapItems.Button;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class Button_Verification : VerificationBase
    {
        private readonly Func<IButton> _SUT;

        public Button_Verification(Func<INavigator> path, Func<IButton> SUT)
            : this(path, () => { }, SUT)
        { }

        public Button_Verification(Func<INavigator> path, Action precondition, Func<IButton> SUT)
            : base(path, SUT)
        {
            this._SUT = SUT;
        }
    }
}