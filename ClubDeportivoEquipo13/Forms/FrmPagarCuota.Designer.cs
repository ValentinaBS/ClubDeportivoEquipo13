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
            this.lblPagarCuota = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.lblTipoDeCuota = new System.Windows.Forms.Label();
            this.rdoMensual = new System.Windows.Forms.RadioButton();
            this.rdoDiaria = new System.Windows.Forms.RadioButton();
            this.lblFechaDePago = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdoEfectivo = new System.Windows.Forms.RadioButton();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(43, 54);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(49, 13);
            this.lblPersona.TabIndex = 1;
            this.lblPersona.Text = "Persona:";
            // 
            // cboPersona
            // 
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Location = new System.Drawing.Point(103, 51);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(201, 21);
            this.cboPersona.TabIndex = 2;
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
            this.rdoMensual.Location = new System.Drawing.Point(129, 87);
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
            this.rdoDiaria.Location = new System.Drawing.Point(209, 87);
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
            this.lblFechaDePago.Visible = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(103, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(201, 20);
            this.dtpFecha.TabIndex = 7;
            this.dtpFecha.Visible = false;
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
            this.txtMonto.Size = new System.Drawing.Size(91, 20);
            this.txtMonto.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(209, 195);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tarjeta";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoEfectivo
            // 
            this.rdoEfectivo.AutoSize = true;
            this.rdoEfectivo.Location = new System.Drawing.Point(129, 195);
            this.rdoEfectivo.Name = "rdoEfectivo";
            this.rdoEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdoEfectivo.TabIndex = 11;
            this.rdoEfectivo.TabStop = true;
            this.rdoEfectivo.Text = "Efectivo";
            this.rdoEfectivo.UseVisualStyleBackColor = true;
            this.rdoEfectivo.CheckedChanged += new System.EventHandler(this.rdoEfectivo_CheckedChanged);
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
            this.btnRegistrarPago.Location = new System.Drawing.Point(40, 234);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(106, 43);
            this.btnRegistrarPago.TabIndex = 13;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(173, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 43);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPagarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 297);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdoEfectivo);
            this.Controls.Add(this.lblFormaDePago);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFechaDePago);
            this.Controls.Add(this.rdoDiaria);
            this.Controls.Add(this.rdoMensual);
            this.Controls.Add(this.lblTipoDeCuota);
            this.Controls.Add(this.cboPersona);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.lblPagarCuota);
            this.Name = "frmPagarCuota";
            this.Text = "FrmPagarCuota";
            this.Load += new System.EventHandler(this.FrmPagarCuota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPagarCuota;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.ComboBox cboPersona;
        private System.Windows.Forms.Label lblTipoDeCuota;
        private System.Windows.Forms.RadioButton rdoMensual;
        private System.Windows.Forms.RadioButton rdoDiaria;
        private System.Windows.Forms.Label lblFechaDePago;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdoEfectivo;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnCancelar;
    }
}