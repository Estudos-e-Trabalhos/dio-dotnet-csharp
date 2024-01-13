using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_13_12.Models
{
    public class LeituraArquivo
    {

        // EXEMPLO DE UTILIZAÇÃO DE TUPLA EM UM MÉTODO SEM NECESSIDADE DE UMA CRIAÇÃO DE NOVAS CLASSES
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {

            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }


        }
    }
}