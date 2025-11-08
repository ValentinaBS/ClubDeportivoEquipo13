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
        Efectivo,

        [Description("Tarjeta de Crédito")]
        Tarjeta,

        [Description("Tarjeta 3 Cuotas S/I")]
        Tarjeta3Cuotas,

        [Description("Tarjeta 6 Cuotas S/I")]
        Tarjeta6Cuotas

    }

    enum TiposDeActividades
    {
        [Description("Musculación")]
        Musculacion,

        [Description("Aparatos")]
        Aparatos
    }

    enum HorarioActividades
    {
        [Description("8:00 AM")]
        Hora8 = 8,

        [Description("9:00 AM")]
        Hora9 = 9,

        [Description("10:00 AM")]
        Hora10 = 10,

        [Description("11:00 AM")]
        Hora11 = 11,

        [Description("12:00 PM")]
        Hora12 = 12,

        [Description("1:00 PM")]
        Hora13 = 13,

        [Description("2:00 PM")]
        Hora14 = 14
    }

}