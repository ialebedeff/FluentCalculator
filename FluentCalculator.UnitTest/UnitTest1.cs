using FluentCalc.Calculator;

namespace FluentCalc.UnitTest
{
    [TestClass]
    public class FluentCalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FluentCalculator calculator = new FluentCalculator();

            int? result = calculator.One().Plus().One().Plus().Three().Result();

            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            FluentCalculator calculator = new FluentCalculator();

            int? result = calculator.One().Multiply().Five().Result();

            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            FluentCalculator calculator = new FluentCalculator();

            int? result = calculator.One().Plus().Ten().Result();

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            FluentCalculator calculator = new FluentCalculator();

            int? result = calculator.One().Minus().Three().Result();

            Assert.AreEqual(-2, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            FluentCalculator calculator = new FluentCalculator();

            int? result = calculator.One().Plus().Ten().Result();

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            FluentCalculator calculator = new FluentCalculator();

            int? result = calculator.One().Plus().Two().Plus().Three().Minus().One().Minus().Two().Minus().Four().Result();

            Assert.AreEqual(-1, result);
        }
    }
}