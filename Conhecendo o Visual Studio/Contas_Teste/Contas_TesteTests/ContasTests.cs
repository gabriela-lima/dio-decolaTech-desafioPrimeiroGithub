using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 1;
            var b = 1;
            var esperado = 2;
            var contas = new Contas();

            var resultado = contas.Soma(a, b);
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 1;
            var b = 1;
            var esperado = 0;
            var contas = new Contas();

            var resultado = contas.Subtracao(a, b);
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 4;
            var b = 2;
            var esperado = 2;
            var contas = new Contas();

            var resultado = contas.Divisao(a, b);
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 1;
            var b = 2;
            var esperado = 2;
            var contas = new Contas();

            var resultado = contas.Multiplicacao(a, b);
            Assert.AreEqual(esperado, resultado);
        }
    }
}