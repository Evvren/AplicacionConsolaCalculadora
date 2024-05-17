using NUnit.Framework;
using AplicacionConsolaCalculadora;
using System;
using static AplicacionConsolaCalculadora.Program;

namespace AplicacionConsolaCalculadora.Tests
{
    [TestFixture]
    public class CalculadoraTests
    {
        public Calculadora calculadora;

        [SetUp]
        public void SetUp()
        {
            Calculadora calculadora = new Calculadora();
        }

        [Test]
        public void SumarTest()
        {

            int a = 5;
            int b = 3;
            int result = calculadora.Sumar(a, b);


            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void RestarTest()
        {

            int a = 5;
            int b = 3;
            int result = calculadora.Restar(a, b);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void MultiplicarTest()
        {

            int a = 5;
            int b = 3;
            int result = calculadora.Multiplicar(a, b);

            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void DividirTest()
        {
            int a = 6;
            int b = 3;

            double result = calculadora.Dividir(a, b);

            Assert.That(result, Is.EqualTo(2.0));
        }
    }
}
