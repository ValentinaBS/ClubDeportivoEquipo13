using ClubDeportivoEquipo13.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Debe completar usuario y contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuarios datos = new Usuarios();
            DataTable dt = datos.Log_Usu(txtUsuario.Text, txtPass.Text);

            if (dt.Rows.Count > 0)
            {
                string rol = dt.Rows[0]["rol"].ToString();
                frmMenu menu = new frmMenu();
                menu.usuario = txtUsuario.Text;
                menu.rol = rol;
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
