using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Dominio
{
    public class CuotaMensual
    {
        public int IdCuotaMensual { get; set; }
        public int IdSocio { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string FormaPago { get; set; }
    }
}
