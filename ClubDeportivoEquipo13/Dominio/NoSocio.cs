using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Dominio
{
    public class NoSocio : Persona
    {
        public int IdNoSocio { get; set; }
        public CuotaDiaria Cuota { get; set; }
    }
}
