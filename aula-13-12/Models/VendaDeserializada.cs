using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace aula_13_12.Models
{
    public class VendaDeserializada
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")] // podemos utilizar essa nomeclatura para consertar a convenção de atributos que estão 
                                        // errados o fogem da convenção do c# sendo uma instrução a mais 
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}