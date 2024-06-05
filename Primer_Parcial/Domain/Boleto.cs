using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial.Domain
{
    public abstract class Boleto
    {
        public double CostoEmbarque {  get; set; }

        public DateTime FechaSalida { get; set; }

        int Numero { get;}

        int TiempoEnDias { get; set; }
    }
}
