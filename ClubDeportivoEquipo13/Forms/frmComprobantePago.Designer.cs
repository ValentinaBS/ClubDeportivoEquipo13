namespace ClubDeportivoEquipo13.Forms
{
    partial class frmComprobantePago
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
            this.lblTituloClub = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloNombreCompleto = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblTitutloDni = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTituloMonto = new System.Windows.Forms.Label();
            this.lblMontoAbonado = new System.Windows.Forms.Label();
            this.lblTituloFechaPago = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblTituloFormaPago = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblTituloValido = new System.Windows.Forms.Label();
            this.lblFechaValido = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloClub
            // 
            this.lblTituloClub.AutoSize = true;
            this.lblTituloClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClub.Location = new System.Drawing.Point(76, 13);
            this.lblTituloClub.Name = "lblTituloClub";
            this.lblTituloClub.Size = new System.Drawing.Size(210, 25);
            this.lblTituloClub.TabIndex = 0;
            this.lblTituloClub.Text = "CLUB DEPORTIVO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(90, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 18);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Comprobante de Pago";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.lblFechaValido);
            this.panel1.Controls.Add(this.lblTituloValido);
            this.panel1.Controls.Add(this.lblFormaPago);
            this.panel1.Controls.Add(this.lblTituloFormaPago);
            this.panel1.Controls.Add(this.lblFechaPago);
            this.panel1.Controls.Add(this.lblTituloFechaPago);
            this.panel1.Controls.Add(this.lblMontoAbonado);
            this.panel1.Controls.Add(this.lblTituloMonto);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblTitutloDni);
            this.panel1.Controls.Add(this.lblNombreCompleto);
            this.panel1.Controls.Add(this.lblTituloNombreCompleto);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblTituloClub);
            this.panel1.Location = new System.Drawing.Point(26, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 345);
            this.panel1.TabIndex = 2;
            // 
            // lblTituloNombreCompleto
            // 
            this.lblTituloNombreCompleto.AutoSize = true;
            this.lblTituloNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombreCompleto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTituloNombreCompleto.Location = new System.Drawing.Point(32, 97);
            this.lblTituloNombreCompleto.Name = "lblTituloNombreCompleto";
            this.lblTituloNombreCompleto.Size = new System.Drawing.Size(76, 20);
            this.lblTituloNombreCompleto.TabIndex = 2;
            this.lblTituloNombreCompleto.Text = "Nombre:";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(173, 97);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(73, 20);
            this.lblNombreCompleto.TabIndex = 3;
            this.lblNombreCompleto.Text = "[Nombre]";
            // 
            // lblTitutloDni
            // 
            this.lblTitutloDni.AutoSize = true;
            this.lblTitutloDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutloDni.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitutloDni.Location = new System.Drawing.Point(32, 129);
            this.lblTitutloDni.Name = "lblTitutloDni";
            this.lblTitutloDni.Size = new System.Drawing.Size(41, 20);
            this.lblTitutloDni.TabIndex = 4;
            this.lblTitutloDni.Text = "Dni:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(173, 129);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(41, 20);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "[Dni]";
            // 
            // lblTituloMonto
            // 
            this.lblTituloMonto.AutoSize = true;
            this.lblTituloMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMonto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTituloMonto.Location = new System.Drawing.Point(32, 161);
            this.lblTituloMonto.Name = "lblTituloMonto";
            this.lblTituloMonto.Size = new System.Drawing.Size(144, 20);
            this.lblTituloMonto.TabIndex = 6;
            this.lblTituloMonto.Text = "Monto abonado: ";
            // 
            // lblMontoAbonado
            // 
            this.lblMontoAbonado.AutoSize = true;
            this.lblMontoAbonado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAbonado.Location = new System.Drawing.Point(173, 161);
            this.lblMontoAbonado.Name = "lblMontoAbonado";
            this.lblMontoAbonado.Size = new System.Drawing.Size(131, 20);
            this.lblMontoAbonado.TabIndex = 7;
            this.lblMontoAbonado.Text = "[Monto Abonado]";
            // 
            // lblTituloFechaPago
            // 
            this.lblTituloFechaPago.AutoSize = true;
            this.lblTituloFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFechaPago.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTituloFechaPago.Location = new System.Drawing.Point(32, 191);
            this.lblTituloFechaPago.Name = "lblTituloFechaPago";
            this.lblTituloFechaPago.Size = new System.Drawing.Size(134, 20);
            this.lblTituloFechaPago.TabIndex = 8;
            this.lblTituloFechaPago.Text = "Fecha de pago:";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(173, 191);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(103, 20);
            this.lblFechaPago.TabIndex = 9;
            this.lblFechaPago.Text = "[Fecha Pago]";
            // 
            // lblTituloFormaPago
            // 
            this.lblTituloFormaPago.AutoSize = true;
            this.lblTituloFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormaPago.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTituloFormaPago.Location = new System.Drawing.Point(32, 220);
            this.lblTituloFormaPago.Name = "lblTituloFormaPago";
            this.lblTituloFormaPago.Size = new System.Drawing.Size(135, 20);
            this.lblTituloFormaPago.TabIndex = 10;
            this.lblTituloFormaPago.Text = "Forma de pago:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.Location = new System.Drawing.Point(173, 220);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(104, 20);
            this.lblFormaPago.TabIndex = 11;
            this.lblFormaPago.Text = "[Forma Pago]";
            // 
            // lblTituloValido
            // 
            this.lblTituloValido.AutoSize = true;
            this.lblTituloValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloValido.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTituloValido.Location = new System.Drawing.Point(32, 253);
            this.lblTituloValido.Name = "lblTituloValido";
            this.lblTituloValido.Size = new System.Drawing.Size(114, 20);
            this.lblTituloValido.TabIndex = 12;
            this.lblTituloValido.Text = "Valido hasta:";
            // 
            // lblFechaValido
            // 
            this.lblFechaValido.AutoSize = true;
            this.lblFechaValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaValido.Location = new System.Drawing.Point(173, 253);
            this.lblFechaValido.Name = "lblFechaValido";
            this.lblFechaValido.Size = new System.Drawing.Size(61, 20);
            this.lblFechaValido.TabIndex = 13;
            this.lblFechaValido.Text = "[Valido]";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(250, 286);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 42);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmComprobantePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 374);
            this.Controls.Add(this.panel1);
            this.Name = "frmComprobantePago";
            this.Text = "Comprobante de Pago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloClub;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloNombreCompleto;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblTitutloDni;
        private System.Windows.Forms.Label lblTituloMonto;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblMontoAbonado;
        private System.Windows.Forms.Label lblTituloFechaPago;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblTituloFormaPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblFechaValido;
        private System.Windows.Forms.Label lblTituloValido;
    }
}