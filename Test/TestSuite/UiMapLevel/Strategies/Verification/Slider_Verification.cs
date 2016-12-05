using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps.UiMapItems.Slider;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class Slider_Verification : VerificationBase
    {
        private readonly Func<ISlider> _SUT;

        private readonly int _min, _max;

        public Slider_Verification(Func<INavigator> path, Func<ISlider> SUT, int min, int max)
            : this(path, () => { }, SUT, min, max)
        { }

        public Slider_Verification(Func<INavigator> path, Action precondition, Func<ISlider> SUT, int min, int max)
            : base(path, SUT)
        {
            this._SUT = SUT;
            this._min = min;
            this._max = max;
        }

        [Test]
        public void Can_Be_Changed_To_Maximum_Value()
        {
            this._SUT().Set_Max();
            this._SUT().Value.ShouldBe(this._max);
        }

        [Test]
        public void Can_Be_Changed_To_Minimum_Value()
        {
            this._SUT().Set_Min();
            this._SUT().Value.ShouldBe(this._min);
        }
    }
}