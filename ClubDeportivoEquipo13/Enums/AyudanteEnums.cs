using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Enums
{
    public static class AyudanteEnums
    {
        public static string GetEnumDescripcion(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attr = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attr?.Description ?? value.ToString();
        }
    

    public static void BindEnumToComboBox<TEnum>(ComboBox comboBox) where TEnum : Enum
        {
            
            comboBox.DataSource = Enum.GetValues(typeof(TEnum))
            .Cast<TEnum>()
            .Select(v => new
        {
            Valor = (int)(object)v,              // guarda INT, no enums
            Descripcion = GetEnumDescripcion(v)  // texto descriptivo
        })
            .ToList();

            comboBox.DisplayMember = "Descripcion";
            comboBox.ValueMember = "Valor";
        }

        public static void BindFilteredTiposDePago(ComboBox comboBox, bool hideCuotas)
        {
            var allValues = Enum.GetValues(typeof(TiposDePago)).Cast<TiposDePago>();

            var filteredValues = hideCuotas
                ? allValues.Where(x => x != TiposDePago.Tarjeta3Cuotas && x != TiposDePago.Tarjeta6Cuotas) // Esconde cuotas
                : allValues; // Muestra todos los valores

            // Guarda la selecci{on
            var seleccion = comboBox.SelectedValue;

            comboBox.DataSource = filteredValues
                .Select(v => new
                {
                    Valor = v,
                    Descripcion = AyudanteEnums.GetEnumDescripcion(v)
                })
                .ToList();

            comboBox.DisplayMember = "Descripcion";
            comboBox.ValueMember = "Valor";

            if (seleccion != null && filteredValues.Contains((TiposDePago)seleccion))
            {
                comboBox.SelectedValue = seleccion;
            }
        }
    }


}