using NUnit.Framework;
using unitTest;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(18)]
        [TestCase(60)]
        [TestCase(15)]
        public void TestIdade(int idade)
        {
            //int idade = 19;
            bool resultado = tester.VerificaIdade(idade);
            Assert.IsTrue(resultado);
        }

        [Test]
        [TestCase("teste@gmail.com")]
        [TestCase("JonSC@gmail.com")]
        public void TestEmail(string email)
        {
            bool resultado = tester.VerificaEmail(email);
            Assert.IsTrue(resultado);
        }
    }
}