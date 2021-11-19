using NUnit.Framework;
using TestCalculator;

namespace Unit_Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
       public void TestAdd()
        {
            Assert.AreEqual(Calculator.Addition(2, 3), 5);
        }

        public void Testsub()
        {
            Assert.AreEqual(Calculator.Sub(2, 3), -1);
        }

        public void Testmul()
        {
            Assert.AreEqual(Calculator.Multipication(2, 3), 6);
        }

        public void Testdiv()
        {
            Assert.AreEqual(Calculator.Div(12, 3), 4);
        }

    }
}