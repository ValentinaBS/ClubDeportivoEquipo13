using ClubDeportivoEquipo13.Datos;
using ClubDeportivoEquipo13.Entidades;
using System;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Forms
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
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

            // Crear objeto E_Persona
            E_Persona persona = new E_Persona
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Dni = txtDocumento.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Email = txtEmail.Text,
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

        private void lblAsterisco1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
