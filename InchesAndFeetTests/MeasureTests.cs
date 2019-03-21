using Microsoft.VisualStudio.TestTools.UnitTesting;
using InchesAndFeet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesAndFeet.Tests
{
    [TestClass()]
    public class MeasureTests
    {
        [TestMethod()]
        public void InchesToFeetTest12()
        {
            Assert.AreEqual(1, Measure.InchesToFeet(12));
        }
        [TestMethod()]
        public void InchesToFeetTest48()
        {
            Assert.AreEqual(4, Measure.InchesToFeet(48));
        }
        [TestMethod()]
        public void InchesToFeetTest6()
        {
            Assert.AreEqual(0.5, Measure.InchesToFeet(6));
        }

        [TestMethod()]
        public void FeetToInchesTestNeg2()
        {
            Assert.AreEqual(-24, Measure.FeetToInches(-2));
        }
        [TestMethod()]
        public void FeetToInchesTest8()
        {
            Assert.AreEqual(96, Measure.FeetToInches(8));
        }
    }
}