using System;
using Xunit;

namespace UnitTestProject
{
    public class UnitTest1
    {
        private CMass massTesting;

        [Fact]
        public void LenghTest1()
        {
            double[] massTest1 = { -8, -1.6, 4, 0, 1.1, -7 };
            massTesting = new CMass(massTest1);
            int res = massTesting.getLenghMass;
            Assert.Equal(6, res);
        }

        [Fact]
        public void LenghTest2()
        {
            double[] massTest1 = { -3 };
            massTesting = new CMass(massTest1);
            int res = massTesting.getLenghMass;
            Assert.Equal(1, res);
        }

        [Fact]
        public void CountNegativeElementsTest1()
        {
            double[] massTest1 = { -8, -1.6, 4, 0, 1.1, -7 };
            massTesting = new CMass(massTest1);
            int res = massTesting.CountNegativeElements();
            Assert.Equal(3, res);
        }

        [Fact]
        public void CountNegativeElementsTest2()
        {
            double[] massTest1 = { 8, 1.6, 4, 0, 1.1, 7 };
            massTesting = new CMass(massTest1);
            int res = massTesting.CountNegativeElements();
            Assert.Equal(0, res);
        }

        [Fact]
        public void CountElementsAfterIndexTest1()
        {
            double[] massTest1 = { -8, -1.6, 4, 0, 1.1, -7 };
            massTesting = new CMass(massTest1);
            int res = massTesting.CountElementsAfterIndex(4);
            Assert.Equal(2, res);
        }

        [Fact]
        public void CountElementsAfterIndexTest2()
        {
            double[] massTest1 = { -8, -1.6, 4, 0, 1.1, -7 };
            massTesting = new CMass(massTest1);
            int res = massTesting.CountElementsAfterIndex(2);
            Assert.Equal(4, res);
        }

        [Fact]
        public void CountNegativeElementsGreaterThanTest1()
        {
            double[] massTest1 = { -8, -1.6, 4, 0, 1.1, -7 };
            massTesting = new CMass(massTest1);
            int res = massTesting.CountNegativeElementsGreaterThan(-9);
            Assert.Equal(3, res);
        }

        [Fact]
        public void CountNegativeElementsGreaterThanTest2()
        {
            double[] massTest1 = { -8, -1.6, 4, 0, 1.1, -7 };
            massTesting = new CMass(massTest1);
            int res = massTesting.CountNegativeElementsGreaterThan(-1.2);
            Assert.Equal(0, res);
        }
    }
}
