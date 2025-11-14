namespace ClubDeportivoEquipo13.Forms
{
    partial class frmPagarCuota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPagarCuota = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTipoDeCuota = new System.Windows.Forms.Label();
            this.rdoMensual = new System.Windows.Forms.RadioButton();
            this.rdoDiaria = new System.Windows.Forms.RadioButton();
            this.lblFechaDePago = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.grpNoSocios = new System.Windows.Forms.GroupBox();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.lblActividadHorario = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.toolTipDni = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMonto = new System.Windows.Forms.ToolTip(this.components);
            this.grpNoSocios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPagarCuota
            // 
            this.lblPagarCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagarCuota.Location = new System.Drawing.Point(111, 9);
            this.lblPagarCuota.Name = "lblPagarCuota";
            this.lblPagarCuota.Size = new System.Drawing.Size(114, 29);
            this.lblPagarCuota.TabIndex = 0;
            this.lblPagarCuota.Text = "Pagar Cuota";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(13, 51);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(71, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "Persona DNI:";
            // 
            // lblTipoDeCuota
            // 
            this.lblTipoDeCuota.AutoSize = true;
            this.lblTipoDeCuota.Location = new System.Drawing.Point(13, 89);
            this.lblTipoDeCuota.Name = "lblTipoDeCuota";
            this.lblTipoDeCuota.Size = new System.Drawing.Size(79, 13);
            this.lblTipoDeCuota.TabIndex = 3;
            this.lblTipoDeCuota.Text = "Tipo De Cuota:";
            // 
            // rdoMensual
            // 
            this.rdoMensual.AutoSize = true;
            this.rdoMensual.Location = new System.Drawing.Point(103, 85);
            this.rdoMensual.Name = "rdoMensual";
            this.rdoMensual.Size = new System.Drawing.Size(65, 17);
            this.rdoMensual.TabIndex = 4;
            this.rdoMensual.TabStop = true;
            this.rdoMensual.Text = "Mensual";
            this.rdoMensual.UseVisualStyleBackColor = true;
            this.rdoMensual.CheckedChanged += new System.EventHandler(this.rdoMensual_CheckedChanged);
            // 
            // rdoDiaria
            // 
            this.rdoDiaria.AutoSize = true;
            this.rdoDiaria.Location = new System.Drawing.Point(177, 85);
            this.rdoDiaria.Name = "rdoDiaria";
            this.rdoDiaria.Size = new System.Drawing.Size(52, 17);
            this.rdoDiaria.TabIndex = 5;
            this.rdoDiaria.TabStop = true;
            this.rdoDiaria.Text = "Diaria";
            this.rdoDiaria.UseVisualStyleBackColor = true;
            this.rdoDiaria.CheckedChanged += new System.EventHandler(this.rdoDiaria_CheckedChanged);
            // 
            // lblFechaDePago
            // 
            this.lblFechaDePago.AutoSize = true;
            this.lblFechaDePago.Location = new System.Drawing.Point(9, 123);
            this.lblFechaDePago.Name = "lblFechaDePago";
            this.lblFechaDePago.Size = new System.Drawing.Size(83, 13);
            this.lblFechaDePago.TabIndex = 6;
            this.lblFechaDePago.Text = "Fecha de Pago:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(103, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(201, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(52, 160);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(103, 157);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(121, 20);
            this.txtMonto.TabIndex = 9;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Location = new System.Drawing.Point(13, 197);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(82, 13);
            this.lblFormaDePago.TabIndex = 10;
            this.lblFormaDePago.Text = "Forma de Pago:";
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(177, 312);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(106, 43);
            this.btnRegistrarPago.TabIndex = 13;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(37, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 43);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(103, 194);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(121, 21);
            this.cboFormaPago.TabIndex = 15;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(103, 48);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(122, 20);
            this.txtDni.TabIndex = 16;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_TextChanged);
            // 
            // cboHorario
            // 
            this.cboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHorario.Location = new System.Drawing.Point(161, 39);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(100, 21);
            this.cboHorario.TabIndex = 17;
            this.cboHorario.SelectedIndexChanged += new System.EventHandler(this.cboHorario_SelectedIndexChanged);
            // 
            // grpNoSocios
            // 
            this.grpNoSocios.Controls.Add(this.cboHorario);
            this.grpNoSocios.Controls.Add(this.cboActividad);
            this.grpNoSocios.Controls.Add(this.lblActividadHorario);
            this.grpNoSocios.Controls.Add(this.lblActividad);
            this.grpNoSocios.Enabled = false;
            this.grpNoSocios.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNoSocios.Location = new System.Drawing.Point(16, 232);
            this.grpNoSocios.Name = "grpNoSocios";
            this.grpNoSocios.Size = new System.Drawing.Size(278, 74);
            this.grpNoSocios.TabIndex = 20;
            this.grpNoSocios.TabStop = false;
            this.grpNoSocios.Text = "Selector de Actividades:";
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.Location = new System.Drawing.Point(25, 39);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(100, 21);
            this.cboActividad.TabIndex = 17;
            this.cboActividad.SelectedIndexChanged += new System.EventHandler(this.cboActividad_SelectedIndexChanged);
            // 
            // lblActividadHorario
            // 
            this.lblActividadHorario.Location = new System.Drawing.Point(143, 22);
            this.lblActividadHorario.Name = "lblActividadHorario";
            this.lblActividadHorario.Size = new System.Drawing.Size(129, 20);
            this.lblActividadHorario.TabIndex = 19;
            this.lblActividadHorario.Text = "Horarios Disponibles:";
            // 
            // lblActividad
            // 
            this.lblActividad.Location = new System.Drawing.Point(25, 22);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(100, 14);
            this.lblActividad.TabIndex = 18;
            this.lblActividad.Text = "Actividad:";
            // 
            // frmPagarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 364);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.lblFormaDePago);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFechaDePago);
            this.Controls.Add(this.rdoDiaria);
            this.Controls.Add(this.rdoMensual);
            this.Controls.Add(this.lblTipoDeCuota);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblPagarCuota);
            this.Controls.Add(this.grpNoSocios);
            this.Name = "frmPagarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar Cuota";
            this.Load += new System.EventHandler(this.FrmPagarCuota_Load);
            this.grpNoSocios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPagarCuota;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblTipoDeCuota;
        private System.Windows.Forms.RadioButton rdoMensual;
        private System.Windows.Forms.RadioButton rdoDiaria;
        private System.Windows.Forms.Label lblFechaDePago;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.GroupBox grpNoSocios;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblActividadHorario;
        private System.Windows.Forms.ToolTip toolTipDni;
        private System.Windows.Forms.ToolTip toolTipMonto;
    }
}