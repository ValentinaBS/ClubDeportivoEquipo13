namespace ClubDeportivoEquipo13.Forms
{
    partial class frmCompletarInscripcion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RadioButton rdoSocio;
        private System.Windows.Forms.RadioButton rdoNoSocio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoInscripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFormaPago;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rdoSocio = new System.Windows.Forms.RadioButton();
            this.rdoNoSocio = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoInscripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.grpNoSocios = new System.Windows.Forms.GroupBox();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.lblActividadHorario = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.grpNoSocios.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoSocio
            // 
            this.rdoSocio.Location = new System.Drawing.Point(33, 33);
            this.rdoSocio.Name = "rdoSocio";
            this.rdoSocio.Size = new System.Drawing.Size(104, 24);
            this.rdoSocio.TabIndex = 0;
            this.rdoSocio.Text = "Socio";
            this.rdoSocio.CheckedChanged += new System.EventHandler(this.rdoSocio_CheckedChanged);
            // 
            // rdoNoSocio
            // 
            this.rdoNoSocio.Location = new System.Drawing.Point(146, 33);
            this.rdoNoSocio.Name = "rdoNoSocio";
            this.rdoNoSocio.Size = new System.Drawing.Size(104, 24);
            this.rdoNoSocio.TabIndex = 1;
            this.rdoNoSocio.Text = "No Socio";
            this.rdoNoSocio.CheckedChanged += new System.EventHandler(this.rdoNoSocio_CheckedChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(30, 90);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(220, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(30, 150);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 4;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.Location = new System.Drawing.Point(150, 150);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(100, 21);
            this.cboFormaPago.TabIndex = 5;
            this.cboFormaPago.SelectedIndexChanged += new System.EventHandler(this.cboFormaPago_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(30, 260);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar y Pagar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(150, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoInscripcion
            // 
            this.lblTipoInscripcion.Location = new System.Drawing.Point(30, 10);
            this.lblTipoInscripcion.Name = "lblTipoInscripcion";
            this.lblTipoInscripcion.Size = new System.Drawing.Size(150, 20);
            this.lblTipoInscripcion.TabIndex = 8;
            this.lblTipoInscripcion.Text = "Tipo de inscripción:";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(30, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(150, 20);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha de inscripción:";
            this.lblFecha.Visible = false;
            // 
            // lblMonto
            // 
            this.lblMonto.Location = new System.Drawing.Point(30, 130);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(100, 20);
            this.lblMonto.TabIndex = 10;
            this.lblMonto.Text = "Monto:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.Location = new System.Drawing.Point(150, 130);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(100, 20);
            this.lblFormaPago.TabIndex = 11;
            this.lblFormaPago.Text = "Forma de pago:";
            // 
            // grpNoSocios
            // 
            this.grpNoSocios.Controls.Add(this.cboHorario);
            this.grpNoSocios.Controls.Add(this.cboActividad);
            this.grpNoSocios.Controls.Add(this.lblActividadHorario);
            this.grpNoSocios.Controls.Add(this.lblActividad);
            this.grpNoSocios.Enabled = false;
            this.grpNoSocios.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNoSocios.Location = new System.Drawing.Point(1, 180);
            this.grpNoSocios.Name = "grpNoSocios";
            this.grpNoSocios.Size = new System.Drawing.Size(279, 74);
            this.grpNoSocios.TabIndex = 21;
            this.grpNoSocios.TabStop = false;
            this.grpNoSocios.Text = "No-Socios";
            // 
            // cboHorario
            // 
            this.cboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHorario.Location = new System.Drawing.Point(149, 39);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(100, 21);
            this.cboHorario.TabIndex = 17;
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.Location = new System.Drawing.Point(29, 39);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(100, 21);
            this.cboActividad.TabIndex = 17;
            this.cboActividad.SelectedIndexChanged += new System.EventHandler(this.cboActividad_SelectedIndexChanged);
            // 
            // lblActividadHorario
            // 
            this.lblActividadHorario.Location = new System.Drawing.Point(142, 22);
            this.lblActividadHorario.Name = "lblActividadHorario";
            this.lblActividadHorario.Size = new System.Drawing.Size(129, 20);
            this.lblActividadHorario.TabIndex = 19;
            this.lblActividadHorario.Text = "Horarios Disponibles:";
            // 
            // lblActividad
            // 
            this.lblActividad.Location = new System.Drawing.Point(32, 22);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(100, 14);
            this.lblActividad.TabIndex = 18;
            this.lblActividad.Text = "Actividad:";
            // 
            // frmCompletarInscripcion
            // 
            this.ClientSize = new System.Drawing.Size(280, 302);
            this.Controls.Add(this.grpNoSocios);
            this.Controls.Add(this.rdoSocio);
            this.Controls.Add(this.rdoNoSocio);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTipoInscripcion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFormaPago);
            this.Name = "frmCompletarInscripcion";
            this.Text = "Completar Inscripción";
            this.Load += new System.EventHandler(this.frmCompletarInscripcion_Load);
            this.grpNoSocios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox grpNoSocios;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.Label lblActividadHorario;
        private System.Windows.Forms.Label lblActividad;
    }
}