using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using unitTest;

namespace UnitTestDefault
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(18)]
        [DataRow(98)]
        [DataRow(15)]
        public void TestIdade(int idade)
        {
            //int idade = 19;
            bool resultado = tester.VerificaIdade(idade);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [DataRow("teste@gmail.com")]
        [DataRow("JonSC@gmail.com")]
        [DataRow("JonSC@gmail.com")]
        public void TestEmail(string email)
        {
            bool resultado = tester.VerificaEmail(email);
            Assert.IsTrue(resultado);
        }
    }
}
