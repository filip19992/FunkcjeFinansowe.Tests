using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace FunkcjeFinansowe.Tests

{

    [TestFixture]

    public class InwestycjaTests

    {
        Inwestycja inw;

        [SetUp]
        public void setUp()
        {
            inw = new Inwestycja();
        }

        [TestCase(1000.00, 0.04, 1040.00)]

        public void wartoscPrzyszla_ObaParametryDouble_Calculated(double a, double b, double result)

        {
            double kwota = inw.wartoscPrzyszla(a, b);

            Assert.AreEqual(kwota, result);
        }

        [TestCase(1000, 4, 5000)]

        public void wartoscPrzyszla_ObaParametryInt_Calculated(int a, int b, int result)

        {
            double kwota = inw.wartoscPrzyszla(a, b);

            Assert.AreEqual(kwota, result);
        }

      
        [TestCase(1000, 0.4, 1400)]
        [TestCase(1000, 0.2, 1200)]

        public void wartoscPrzyszla_JedenDoubleJedenInt_Calculated(int a, double b, double result)

        {
            double kwota = inw.wartoscPrzyszla(a, b);

            Assert.AreEqual(kwota, result);
        }

        [Test]
        public void wartoscPrzyszla_ObaParametryDouble_Exception()

        {
            Assert.Throws<ArithmeticException>(MethodThatThrowsArithmeticException);
        }

        private void MethodThatThrowsArithmeticException()
        {
            inw.wartoscPrzyszla(111, -100000);
        }
    }
}