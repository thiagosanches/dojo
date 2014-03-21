using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Palindrome
{
    public class PalindromeLib
    {
        public Boolean verificarPalindrome(String palavra)
        {
            palavra = Normalizar(palavra);

            int j = palavra.Length - 1;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] != palavra[j])
                    return false;
                j--;
            }
            return true;
        }

        private string Normalizar(string palavra)
        {
            string palavraNormalizada = palavra;
            return palavraNormalizada.ToLower()
                .Replace("-", "")
                .Replace(" ", "")
                .Replace("ô", "o")
                .Replace(".", "")
                .Replace("á", "a")
                .Replace("à", "a")
                .Replace("ã", "a")
                .Replace("â", "a")
                .Replace("!", "")
                .Replace("?", "")
                .Replace("é", "e")
                .Replace("ê", "e")
                .Replace("í", "i")
                .Replace("õ", "o")
                .Replace("ó", "o")
                .Replace("ú", "u")
                .Replace(",", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace(";", "");
 

        }
        public void AbrirArquivoPalindromes(String caminho)
        {
            String[] linha = File.ReadAllLines(caminho);

            StringBuilder saida = new StringBuilder();
            foreach (var item in linha)
            {
                saida.AppendFormat(" {0} : {1}", item, verificarPalindrome(item));
                saida.AppendLine();

	        }
            File.WriteAllText("saida.txt", saida.ToString());
        }
    }
}