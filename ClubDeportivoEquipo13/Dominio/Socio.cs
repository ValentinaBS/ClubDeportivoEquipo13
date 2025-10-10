using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Dominio
{
    public class Socio : Persona
    {
        public int IdSocio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public CuotaMensual Cuota { get; set; }
    }
}
