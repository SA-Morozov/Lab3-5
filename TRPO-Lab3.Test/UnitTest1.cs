using NUnit.Framework;
using TRPO_Lab3.Lib;
using TRPO_Lab3.Lib.TRPO_Lab3.Lib;


namespace TRPO_Lab3.Tests
{
    [TestFixture]
    public class CalcTests
    {
        [Test]
        public void Test_RegularValues()
        {
            const double P1 = 40;
            const double h = 10;
            const double P2 = 35;
            const double expected = 375;

            var result = SurfaceArea.TruncatedPyramidLateralSurfaceArea(P1, P2, h);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_HeightBigger()
        {
            const double P1 = 20;
            const double h = 20;
            const double P2 = 50;
            const double expected = 700;

            var result = SurfaceArea.TruncatedPyramidLateralSurfaceArea(P1, P2, h);

          Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_ZeroValue()
        {
            const double P1 = 50;
            const double h = 0;
            const double P2 = 20;
            const double expected = 0;

            var result = SurfaceArea.TruncatedPyramidLateralSurfaceArea(P1, P2, h);

          Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_HeightEqualToDiameter()
        {
            const double P1 = -40;
            const double h = -5;
            const double P2 = -30;
            const double expected = -1;

            var result = SurfaceArea.TruncatedPyramidLateralSurfaceArea(P1, P2, h);

           Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_NegativeValue()
        {
            const double P1 = 0;
            const double h = 0;
            const double P2 = 0;
            const double expected = 0;

            var result = SurfaceArea.TruncatedPyramidLateralSurfaceArea(P1, P2, h);
           Assert.AreEqual(expected, result);
        }
    }
}