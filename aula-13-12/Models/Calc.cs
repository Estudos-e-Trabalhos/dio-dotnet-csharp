using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_13_12.Interfaces;

namespace aula_13_12.Models
{
    public class Calc : ICalcuradora
    {
        // para usar a interface icalculadora eu preciso implementar tudo o que ela pede
        // A classe calc não é filha da interface Icalcuradora, mas sim implementar
        public int dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}