using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Datos
{
    partial class frmConexionDatos
    {

        private System.ComponentModel.IContainer components = null;

        private Label lblServidor;
        private TextBox txtServidor;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblClave;
        private TextBox txtClave;
        private Label lblPuerto;
        private TextBox txtPuerto;
        private Button btnAceptar;
        private Button btnCancelar;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
           this.components = new System.ComponentModel.Container();

            this.lblServidor = new Label();
            this.lblUsuario = new Label();
            this.lblClave = new Label();
            this.lblPuerto = new Label();
            this.txtServidor = new TextBox();
            this.txtUsuario = new TextBox();
            this.txtClave = new TextBox();
            this.txtPuerto = new TextBox();
            this.btnAceptar = new Button();
            this.btnCancelar = new Button();

            this.lblServidor.Text = "Servidor:";
            this.lblServidor.Left = 20;
            this.lblServidor.Top = 20;

            this.txtServidor.Left = 120;
            this.txtServidor.Top = 20;
            this.txtServidor.Width = 220;

            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Left = 20;
            this.lblUsuario.Top = 60;

            this.txtUsuario.Left = 120;
            this.txtUsuario.Top = 60;
            this.txtUsuario.Width = 220;

            this.lblClave.Text = "Clave:";
            this.lblClave.Left = 20;
            this.lblClave.Top = 100;

            this.txtClave.Left = 120;
            this.txtClave.Top = 100;
            this.txtClave.Width = 220;
            this.txtClave.UseSystemPasswordChar = true;

            this.lblPuerto.Text = "Puerto:";
            this.lblPuerto.Left = 20;
            this.lblPuerto.Top = 140;

            this.txtPuerto.Left = 120;
            this.txtPuerto.Top = 140;
            this.txtPuerto.Width = 220;

            this.btnAceptar.Text = "Aceptar";

            this.btnAceptar.Left = 120;
            this.btnAceptar.Top = 200;
            this.btnAceptar.Width = 100;

            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = DialogResult.Cancel;

            this.btnCancelar.Left = 240;
            this.btnCancelar.Top = 200;
            this.btnCancelar.Width = 100;

            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);

            this.Text = "Datos de conexión MySQL";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 400;
            this.Height = 300;
            this.MaximizeBox = false;
            this.MinimizeBox = false;           

            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
        }

    }
}