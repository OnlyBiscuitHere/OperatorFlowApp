using NUnit.Framework;
using static OperatorsApp.Methods;
using OperatorsApp;

namespace OperatorsControlFlowTest
{
    public class StoneTests
    {
        [SetUp]
        public void Setup()
        {

        }
        [TestCase(156)]
        public void GivenNoOfPounds(int totalPounds)
        {
            int expectedStones = 11;
            int expectedPounds = 2;
            int actualStones = GetStones(totalPounds);
            int actualPounds = GetPounds(totalPounds);
            Assert.AreEqual(expectedPounds, actualPounds);
            Assert.AreEqual(expectedStones, actualStones);
        }
        [TestCase(0)]
        [TestCase(40)]
        [TestCase(64)]
        public void GivenAMarkLessThan65_Grade_ReturnsFailed(int mark)
        {
            Assert.That(Grade(mark), Is.EqualTo("Failed"));
        }
        [TestCase(65)]
        [TestCase(84)]
        public void GivenAMarkBetween65And83_Grade_ReturnsPass(int mark)
        {
            Assert.That(Grade(mark), Is.EqualTo("Pass"));
        }
        [TestCase(85)]
        [TestCase(100)]
        public void GivenAMarkbetween85And100_Grade_ReturnsDistinction(int mark)
        {
            Assert.That(Grade(mark), Is.EqualTo("Distinction"));
        }
    }
}