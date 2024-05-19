using SFmodule16FinalProject;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionMustBeCorrect()
        {
            Calculator add = new Calculator();
            Assert.That(add.Additional(5, 5) == 10);
        }
        [Test]
        public void SubstractionMustBeCorrect()
        {
            Calculator sub = new Calculator();
            Assert.That(sub.Subtraction(10, 4) == 6);
        }
        [Test]
        public void MultiplicationMustBeCorrect()
        {
            Calculator mult = new Calculator();
            Assert.That(mult.Miltiplication(8, 0) == 0);
        }
        [Test]
        public void DivisionMustBeCorrect()
        {
            Calculator div = new Calculator();
            Assert.That(div.Division(6, 6) == 1);
        }
    }
}