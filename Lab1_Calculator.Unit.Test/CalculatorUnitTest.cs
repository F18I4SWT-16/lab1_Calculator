using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_Calculator.Library;
using NUnit.Framework;

namespace Lab1_Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new Calculator();
        }

        [Test]
        public void Add_AddTwoNumbers_NumbersIsAdded()
        {
            Assert.That(_uut.Add(2,2), Is.EqualTo(4));
        }

        [Test]
        public void Subtract_SubtractTwoNumbers_NumbersIsSubtracted()
        {
            Assert.That(_uut.Subtract(2,2), Is.EqualTo(0));
        }

        [Test]
        public void Multiply_MultiplyTwoNumbers_NumbersIsMultiplied()
        {
            Assert.That(_uut.Multiply(2,2), Is.EqualTo(4));
        }

        [TestCase(2,2,4)]
        [TestCase(2,1,2)]
        [TestCase(2,0,1)]
        public void Power_FindPowerOfNumber_PowerIsCorrect(double x, double exp, double expected)
        {
            Assert.That(_uut.Power(x,exp), Is.EqualTo(expected));
        }

    }
}
