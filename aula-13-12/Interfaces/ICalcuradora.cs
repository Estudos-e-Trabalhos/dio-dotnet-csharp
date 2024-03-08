using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_13_12.Interfaces
{
    public interface ICalcuradora
    {
        // por convesão nos devemos usar o I para represetar uma interface
        // a interface não pode ser implementada mas ela pode receber uma implementação

        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int dividir(int num1, int num2)
        {
            return num1 / num2;
        }


        // Fazendo um paralelo com Heranças, Interfaces irão definir apenas o "esqueleto" dos métodos e atributos, restringindo seus nomes e tipos, enquanto as Heranças possuem métodos e atributos próprios com valores e funcionamentos previamente definidos.
    }
}