using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Datos
{
    enum TiposDePago
    {
        [Description("Efectivo")]
        Efectivo,

        [Description("Tarjeta de Crédito")]
        TarjetaDeCredito,

        [Description("Tarjeta de Débito")]
        TarjetaDeDebito
    }

    enum TiposDeRegistro
    {
        [Description("Socio")]
        Socio,

        [Description("No-Socio")]
        NoSocio
    }
}
