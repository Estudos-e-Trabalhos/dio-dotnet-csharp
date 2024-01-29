using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_13_12.Models
{

    // metodo adicional de extensão onde qualquer numero int tem acesso ao metodo Ehpar
    public static class IntExtensions
    {
        public static bool EhPar(this int numero) // principal this int 
        {
            return numero % 2 == 0;
        } 
    }
}