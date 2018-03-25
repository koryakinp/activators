using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ann.Activators.Tests
{
    [TestClass]
    public class ActivatorTests
    {
        [TestMethod]
        public void LogisticActivatorValueTest()
        {
            LogisticActivator a1 = new LogisticActivator();
            Assert.AreEqual(0.119, a1.CalculateValue(-2), 0.001);
            Assert.AreEqual(0.269, a1.CalculateValue(-1), 0.001);
            Assert.AreEqual(0.500, a1.CalculateValue(0), 0.001);
            Assert.AreEqual(0.731, a1.CalculateValue(1), 0.001);
            Assert.AreEqual(0.881, a1.CalculateValue(2), 0.001);
        }

        [TestMethod]
        public void LogisticActivatorDeriviativeTest()
        {
            LogisticActivator a1 = new LogisticActivator();
            Assert.AreEqual(-6, a1.CalculateDeriviative(-2));
            Assert.AreEqual(-2, a1.CalculateDeriviative(-1));
            Assert.AreEqual(0, a1.CalculateDeriviative(0));
            Assert.AreEqual(0, a1.CalculateDeriviative(1));
            Assert.AreEqual(-2, a1.CalculateDeriviative(2));
        }

        [TestMethod]
        public void TanhActivatorValueTest()
        {
            TanhActivator a1 = new TanhActivator();
            Assert.AreEqual(-0.964, a1.CalculateValue(-2), 3);
            Assert.AreEqual(-0.762, a1.CalculateValue(-1), 3);
            Assert.AreEqual(0, a1.CalculateValue(0), 3);
            Assert.AreEqual(0.762, a1.CalculateValue(1), 3);
            Assert.AreEqual(0.964, a1.CalculateValue(2), 3);
        }

        [TestMethod]
        public void TanhActivatorDeriviativeTest()
        {
            TanhActivator a1 = new TanhActivator();
            Assert.AreEqual(0.071, a1.CalculateDeriviative(-2), 3);
            Assert.AreEqual(0.420, a1.CalculateDeriviative(-1), 3);
            Assert.AreEqual(1, a1.CalculateDeriviative(0), 3);
            Assert.AreEqual(0.420, a1.CalculateDeriviative(1), 3);
            Assert.AreEqual(0.071, a1.CalculateDeriviative(2), 3);
        }

        [TestMethod]
        public void ReluActivatorValueTest()
        {
            ReluActivator a1 = new ReluActivator();
            Assert.AreEqual(0, a1.CalculateValue(-2));
            Assert.AreEqual(0, a1.CalculateValue(-1));
            Assert.AreEqual(0, a1.CalculateValue(0));
            Assert.AreEqual(1, a1.CalculateValue(1));
            Assert.AreEqual(2, a1.CalculateValue(2));
        }

        [TestMethod]
        public void ReluActivatorDeriviativeTest()
        {
            ReluActivator a1 = new ReluActivator();
            Assert.AreEqual(0, a1.CalculateDeriviative(-2));
            Assert.AreEqual(0, a1.CalculateDeriviative(-1));
            Assert.AreEqual(1, a1.CalculateDeriviative(0));
            Assert.AreEqual(1, a1.CalculateDeriviative(1));
            Assert.AreEqual(1, a1.CalculateDeriviative(2));
        }
    }
}
