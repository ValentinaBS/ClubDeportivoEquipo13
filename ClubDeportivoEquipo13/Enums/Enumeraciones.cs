using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Enums
{

    enum TiposDePago
    {
        [Description("Efectivo")]
        Efectivo = 1,

        [Description("Tarjeta de Crédito")]
        Tarjeta = 2,

        [Description("Tarjeta 3 Cuotas S/I")]
        Tarjeta3Cuotas = 3,

        [Description("Tarjeta 6 Cuotas S/I")]
        Tarjeta6Cuotas = 6

    }
    


}