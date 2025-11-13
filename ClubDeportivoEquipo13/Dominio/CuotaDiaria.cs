using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Dominio
{
    public class CuotaDiaria
    {
        public int IdCuotaDiaria { get; set; }
        public int IdNoSocio { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string FormaPago { get; set; }
        public int IdActividad { get; set; }
    }
}
