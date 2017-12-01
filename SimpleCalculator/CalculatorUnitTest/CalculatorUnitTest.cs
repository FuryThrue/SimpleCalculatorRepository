using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void N5plusN3_15Returned()
        {
            var userString = "5+3";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(5 + 3, result);
        }

        [TestMethod]
        public void N5minusN3_2Returned()
        {
            var userString = "5-3";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(5 - 3, result);
        }

        [TestMethod]
        public void N5multiplyN3_15Returned()
        {
            var userString = "5*3";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(5 * 3, result);
        }

        [TestMethod]
        public void N6divideN3_2Returned()
        {
            var userString = "6/3";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(6d / 3, result);
        }

        [TestMethod]
        public void N3divideN2_1dot5Returned()
        {
            var userString = "3/2";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(3d/2, result);
        }

        [TestMethod]
        public void WordPlusWord_NaNReturned()
        {
            var userString = "abs+bas";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void WordWordWord_NaNReturned()
        {
            var userString = "absIkobas";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void N5dot5plusN5dot5_11Returned()
        {
            var userString = "5.5+5.5";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(5.5 + 5.5, result);
        }

        [TestMethod]
        public void N5comma5plusN5comma5_11Returned()
        {
            var userString = "5,5+5,5";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void NumberPlusWord_NaNReturned()
        {
            var userString = "9+abs";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void N9SpaceplusSpaceN9_18Returned()
        {
            var userString = "9 + 9";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(9 + 9, result);
        }

        [TestMethod]
        public void N9divideN0_NanReturned()
        {
            var userString = "9/0";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void Nminus9plusNminus3_NanReturned()
        {
            var userString = "-9+-3";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(-9+-3, result);
        }

        [TestMethod]
        public void Nminus9plusNminus3WithBrackets_NanReturned()
        {
            var userString = "-9+(-3)";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(-9 + -3, result);
        }

        [TestMethod]
        public void EmptyData_NaNReturned()
        {
            var userString = "";

            var calc = new Calculator();
            var result = calc.Calculate(userString);

            Assert.AreEqual(double.NaN, result);
        }
    }
}
