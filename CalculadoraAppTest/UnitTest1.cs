using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraApp;

namespace CalculadoraAppTest
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void TestConstrutor()
        {
            var calc = new Calculadora();
            Assert.AreEqual("", calc.Display);
        }

        [TestMethod]
        public void TestPressionarBotao()
        {
            var calc = new Calculadora();
            calc.PressionarBotao("1");
            Assert.AreEqual("1", calc.Display);

            calc.PressionarBotao("5");
            Assert.AreEqual("15", calc.Display);

            calc.PressionarBotao("3");
            Assert.AreEqual("153", calc.Display);
        }

        [TestMethod]
        public void TestSoma()
        {
            var calc = new Calculadora();
            calc.PressionarBotao("1");
            calc.PressionarBotao("2");
            Assert.AreEqual("12", calc.Display);
            calc.Mais();

            calc.PressionarBotao("3");
            calc.PressionarBotao("5");
            calc.PressionarBotao("0");
            Assert.AreEqual("350", calc.Display);

            calc.Igual();
            Assert.AreEqual("362", calc.Display);
        }
    }
}
