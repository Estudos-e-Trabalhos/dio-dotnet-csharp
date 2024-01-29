using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_13_12.Models
{
    public class MeuArray<T> // o T significa o tipo - nesse caso generico
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElementoArray(T elemento)
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento;
                Console.WriteLine(array[contador] = elemento);
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}