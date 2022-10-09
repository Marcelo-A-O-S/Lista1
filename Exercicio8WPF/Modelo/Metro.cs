using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8WPF.Modelo
{
    public class Metro
    {
        public float metro { get; set; }
        public float? km { get; set; }
        public float? hm { get; set; }
        public float? dam { get; set; }
        public float? dm { get; set; }
        public float? cm { get; set; }
        public float? mm { get;set; }
        
        public Metro distancia(Metro distancia) 
        {
            distancia.dm = distancia.metro * 10;
            distancia.cm = (distancia.metro * 10) * 10;
            distancia.mm = distancia.metro * 10* 10* 10;
            distancia.dam = distancia.metro / 10;
            distancia.hm = (distancia.metro/10) / 10;
            distancia.km = distancia.metro / 10/10/10;
            return distancia;
        }
    }
}
