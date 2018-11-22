using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ann.Activators.Tests
{
    [TestClass]
    public class ActivatorTests
    {

        private readonly double[] SoftmaxInput;
        private readonly double[] SoftmaxOutput;
        private readonly double[] SoftmaxDeriviative;
        private readonly double[] SoftmaxGradient;

        public ActivatorTests()
        {
            SoftmaxInput = new double[3] { 0.28820888, 0.08186503, 0.12464621 };
            SoftmaxOutput = new double[3] { 0.375563358, 0.305540805, 0.318895836 };
            SoftmaxDeriviative = new double[3] { 0.141945971, 0.178941437, -0.320887407 };
            SoftmaxGradient = new double[3] {0.5167, 0.7244, -0.8675 };
        }

        [TestMethod]
        public void SoftmaxActivatorValueTest()
        {
            var a1 = new SoftmaxActivator();

            var actual = a1.CalculateValue(SoftmaxInput);

            Assert.AreEqual(SoftmaxOutput.Length, actual.Length);
            for (int i = 0; i < SoftmaxOutput.Length; i++)
            {
                Assert.AreEqual(SoftmaxOutput[i], actual[i], 5);
            }
        }

        [TestMethod]
        public void SoftmaxActivatorDeriviativeTest()
        {
            var a1 = new SoftmaxActivator();
            var actual = a1.CalculateDeriviative(SoftmaxOutput, SoftmaxGradient);

            Assert.AreEqual(SoftmaxDeriviative.Length, actual.Length);

            for (int i = 0; i < SoftmaxDeriviative.Length; i++)
            {
                Assert.AreEqual(SoftmaxDeriviative[i], actual[i], 5);
            }
        }

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
