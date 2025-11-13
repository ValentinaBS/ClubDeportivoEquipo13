using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Datos
{
    partial class frmConexionDatos : Form
    {
        public string Servidor { get; private set; } = "";
        public string Usuario { get; private set; } = "";
        public string Clave { get; private set; } = "";
        public string Puerto { get; private set; } = "";

        public frmConexionDatos()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            txtServidor.Text = "localhost";
            txtServidor.ForeColor = Color.Gray;
            txtServidor.Enter += (sender, e) =>
            {
                if (txtServidor.Text == "localhost")
                {
                    txtServidor.Text = "";
                    txtServidor.ForeColor = Color.Black;
                }
            };

            txtServidor.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtServidor.Text))
                {
                    txtServidor.Text = "localhost";
                    txtServidor.ForeColor = Color.Gray;
                }
            };

            txtUsuario.Text = "root";
            txtUsuario.ForeColor = Color.Gray;

            txtUsuario.Enter += (sender, e) =>
            {
                if (txtUsuario.Text == "root")
                {
                    txtUsuario.Text = "";
                    txtUsuario.ForeColor = Color.Black;
                }
            };

            txtUsuario.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    txtUsuario.Text = "root";
                    txtUsuario.ForeColor = Color.Gray;
                }
            };

            txtPuerto.Text = "3306";
            txtPuerto.ForeColor = Color.Gray;

            txtPuerto.Enter += (sender, e) =>
            {
                if (txtPuerto.Text == "3306")
                {
                    txtPuerto.Text = "";
                    txtPuerto.ForeColor = Color.Black;
                }
            };

            txtPuerto.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtPuerto.Text))
                {
                    txtPuerto.Text = "3306";
                    txtPuerto.ForeColor = Color.Gray;
                }
            };

            btnAceptar.Click += btnAceptar_Click;
        }

        private void btnAceptar_Click(Object sender, EventArgs e)
        {
            Servidor = txtServidor.Text;
            Usuario = txtUsuario.Text;
            Clave = txtClave.Text;
            Puerto = txtPuerto.Text;

            String cadenaConexion = $"Server={Servidor};Database=equipo13_coma;User Id={Usuario};Password={Clave};Port={Puerto};";

            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection prueba = new MySql.Data.MySqlClient.MySqlConnection(cadenaConexion))
                {
                    prueba.Open();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
