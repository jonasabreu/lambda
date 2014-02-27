using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lambda;


namespace LambdaTest
{
    [TestClass]
    public class OptionTest
    {
        [TestMethod]
        public void ShouldBeCovariant()
        {
            Option<String> optionString = null;
            Option<Object> other = optionString;
        }

        [TestMethod]
        public void ShouldLiftTypes()
        {
            Assert.IsTrue("".AsOption().IsDefined());
            Assert.IsFalse(Option.Of<String>(null).IsDefined()); 
        }

        [TestMethod]
        public void MapShouldNotMapOverNone()
        {
            var i = 0;
            new None<String>().Map((e) => ++i);
            Assert.AreEqual(0, i);
        }

        [TestMethod]
        public void MapShouldMapOverSome()
        {
            var i = 0;
            var some = Option.Of("").Map((e) => ++i);
            Assert.AreEqual(1, i);
            Assert.AreEqual(1, some.Get());
        }

        [TestMethod]
        public void FilterShouldAlwaysReturnNoneForNone()
        {
            var i = 0;
            Assert.IsFalse(new None<String>().Filter((e) => ++i).isDefined());
            Assert.AreEqual(0, i);
        }
    }
}
