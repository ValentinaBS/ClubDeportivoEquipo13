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

    enum TiposDeActividades
    {
        [Description("Musculación")]
        Musculacion,

        [Description("Aparatos")]
        Aparatos
    }

    enum HorarioMusculacion
    {
        [Description("8:00 AM")]
        Hora8 = 8,

        [Description("10:00 AM")]
        Hora10 = 10,

        [Description("12:00 PM")]
        Hora12 = 12,

        [Description("2:00 PM")]
        Hora14 = 14,

        [Description("4:00 PM")]
        Hora16 = 16,

        [Description("6:00 PM")]
        Hora18 = 18,

    }

    enum HorarioAparatos
    {

        [Description("9:00 AM")]
        Hora9 = 9,

        [Description("11:00 AM")]
        Hora11 = 11,

        [Description("1:00 PM")]
        Hora13 = 13,

        [Description("3:00 PM")]
        Hora15 = 15,

        [Description("5:00 PM")]
        Hora17 = 17,

        [Description("7:00 PM")]
        Hora19 = 19,

    }


}