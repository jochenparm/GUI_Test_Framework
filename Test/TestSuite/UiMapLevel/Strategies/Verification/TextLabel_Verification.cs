using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps.UiMapItems.TextLabel;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class TextLabel_Verification : VerificationBase
    {
        private readonly Func<ITextLabel> _SUT;

        public TextLabel_Verification(Func<INavigator> path, Func<ITextLabel> SUT)
            : this(path, () => { }, SUT)
        { }

        public TextLabel_Verification(Func<INavigator> path, Action precondition, Func<ITextLabel> SUT)
            : base(path, SUT)
        {
            this._SUT = SUT;
        }
    }
}