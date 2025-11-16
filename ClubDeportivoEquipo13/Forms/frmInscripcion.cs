using ClubDeportivoEquipo13.Datos;
using ClubDeportivoEquipo13.Entidades;
using ClubDeportivoEquipo13.Validaciones;
using System;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Forms
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
            this.AcceptButton = btnGuardar;
            this.CancelButton = btnVolver;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtDocumento.Text) ||
                chkFicha.Checked == false)
            {
                MessageBox.Show("Debe completar los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreValidado = AyudanteValidador.ValidarNombre(txtNombre.Text);
            string apellidoValidado = AyudanteValidador.ValidarNombre(txtApellido.Text);
            bool documentoValidado = AyudanteValidador.ValidarDocumento(txtDocumento.Text);

            if (nombreValidado == "")
            {
                MessageBox.Show("El nombre debe tener mas de dos caracteres válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (apellidoValidado == "")
            {
                MessageBox.Show("El Apellido debe tener mas de dos caracteres válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!documentoValidado)
            {
                MessageBox.Show("El Documento debe tener 8 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string emailValidado = "";
            if (txtEmail.Text != "")
            {
                emailValidado = AyudanteValidador.ValidarEmail(txtEmail.Text);
                if (emailValidado == "")
                {
                    MessageBox.Show("El Email no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string telefonoValidado = "";
            if (txtTelefono.Text != "")
            {
                telefonoValidado = AyudanteValidador.ValidarTelefono(txtTelefono.Text);
                if (telefonoValidado == "")
                {
                    MessageBox.Show("El Teléfono debe tener entre 8 y 10 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string direccionValidada = "";
            if (txtDireccion.Text != "")
            {
                direccionValidada = AyudanteValidador.ValidarDireccion(txtDireccion.Text);
                direccionValidada = AyudanteValidador.CapitalizarYBorrarEspacios(txtDireccion.Text);
                if (direccionValidada == "")
                {
                    MessageBox.Show("La Dirección debe tener al menos 5 caracteres válidos, máximo 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            // Crear objeto E_Persona
            E_Persona persona = new E_Persona
            {
                Nombre = nombreValidado,
                Apellido = apellidoValidado,
                Dni = txtDocumento.Text,
                Telefono = telefonoValidado,
                Direccion = direccionValidada,
                Email = emailValidado,
                FichaMedica = chkFicha.Checked
            };

            // Guardar la persona en la base
            PersonasDatos datos = new PersonasDatos();
            int idPersona = datos.NuevaPersona(persona);

            if (idPersona == 0)
            {
                MessageBox.Show("La persona ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmCompletarInscripcion completar = new frmCompletarInscripcion
                {
                    IdPersona = idPersona
                };
                completar.Show();
                this.Hide();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            chkFicha.Checked = false;
            txtNombre.Focus();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        // Validaciones básicas en tiempo real de campos (Solo números/letras)
        // Máximo de caracteres mediante ToolTips
        private void txtDocumento_TextChanged(object sender, KeyPressEventArgs e)
        {
            AyudanteValidador.PermitirSoloNumeros(e, txtDocumento, toolTipDocumento);
            AyudanteValidador.LimiteDeCaracteres(e, txtDocumento, toolTipDocumento, 8);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            AyudanteValidador.PermitirSoloNumeros(e, txtTelefono, toolTipTelefono);
            AyudanteValidador.LimiteDeCaracteres(e, txtTelefono, toolTipTelefono, 10);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            AyudanteValidador.PermitirSoloLetras(e, txtNombre, toolTipNombre);
            AyudanteValidador.LimiteDeCaracteres(e, txtNombre, toolTipNombre);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            AyudanteValidador.PermitirSoloLetras(e, txtApellido, toolTipApellido);
            AyudanteValidador.LimiteDeCaracteres(e, txtApellido, toolTipApellido);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            AyudanteValidador.LimiteDeCaracteres(e, txtEmail, toolTipEmail, 100);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            AyudanteValidador.LimiteDeCaracteres(e, txtDireccion, toolTipDireccion, 100);
        }
    }
}
