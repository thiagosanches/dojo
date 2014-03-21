using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Treinamento.Palindrome;

namespace Treinamento.TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarAna()
        {   

            PalindromeLib palavra = new PalindromeLib();
            Assert.IsTrue(palavra.verificarPalindrome("ana"));
        }

        [TestMethod]
        public void TestarArara()
        {
            PalindromeLib palavra = new PalindromeLib();
            Assert.IsTrue(palavra.verificarPalindrome("arara"));
        }

        [TestMethod]
        public void TestarBanana()
        {
            PalindromeLib palavra = new PalindromeLib();
            Assert.IsFalse(palavra.verificarPalindrome("banana"));
        }

        [TestMethod]
        public void TestarFrase()
        {
            PalindromeLib palavra = new PalindromeLib();
            Assert.IsTrue(palavra.verificarPalindrome("Socorram-me subi no ônibus em marrocos"));
        }

        [TestMethod]
        public void TestarFrase2()
        {
            PalindromeLib palavra = new PalindromeLib();
            Assert.IsTrue(palavra.verificarPalindrome("Aroma. Me supus em amora."));
        }

        [TestMethod]
        public void TestarArquivo()
           

         
        {
            PalindromeLib ArquivoTest = new PalindromeLib();
            ArquivoTest.AbrirArquivoPalindromes(@"C:\Users\thiagom\Downloads\lista_frases.txt");
    
        }
    
    }

}
