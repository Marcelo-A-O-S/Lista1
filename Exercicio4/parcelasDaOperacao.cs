using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class parcelasDaOperacao
    {
        public float primeironumero { get; set; }
        public float segundonumero { get; set; }
        public float resultado(parcelasDaOperacao parcelas)
        {
            return parcelas.primeironumero + parcelas.segundonumero;

        }
    }
   
}
