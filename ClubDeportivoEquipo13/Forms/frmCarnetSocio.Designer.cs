namespace ClubDeportivoEquipo13.Forms
{
    partial class frmCarnetSocio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblVencimieto = new System.Windows.Forms.Label();
            this.lblTituloVencimiento = new System.Windows.Forms.Label();
            this.lblIdSocio = new System.Windows.Forms.Label();
            this.lblTituloIdSocio = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTituloDni = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblTituloNombreCompleto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.lblVencimieto);
            this.panel1.Controls.Add(this.lblTituloVencimiento);
            this.panel1.Controls.Add(this.lblIdSocio);
            this.panel1.Controls.Add(this.lblTituloIdSocio);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblTituloDni);
            this.panel1.Controls.Add(this.lblNombreCompleto);
            this.panel1.Controls.Add(this.lblTituloNombreCompleto);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(16, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 256);
            this.panel1.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImprimir.Location = new System.Drawing.Point(471, 200);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(145, 48);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblVencimieto
            // 
            this.lblVencimieto.AutoSize = true;
            this.lblVencimieto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimieto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVencimieto.Location = new System.Drawing.Point(232, 177);
            this.lblVencimieto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVencimieto.Name = "lblVencimieto";
            this.lblVencimieto.Size = new System.Drawing.Size(132, 25);
            this.lblVencimieto.TabIndex = 8;
            this.lblVencimieto.Text = "[Vencimiento]";
            // 
            // lblTituloVencimiento
            // 
            this.lblTituloVencimiento.AutoSize = true;
            this.lblTituloVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVencimiento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTituloVencimiento.Location = new System.Drawing.Point(73, 177);
            this.lblTituloVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloVencimiento.Name = "lblTituloVencimiento";
            this.lblTituloVencimiento.Size = new System.Drawing.Size(138, 25);
            this.lblTituloVencimiento.TabIndex = 7;
            this.lblTituloVencimiento.Text = "Vencimiento:";
            // 
            // lblIdSocio
            // 
            this.lblIdSocio.AutoSize = true;
            this.lblIdSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSocio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIdSocio.Location = new System.Drawing.Point(229, 125);
            this.lblIdSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdSocio.Name = "lblIdSocio";
            this.lblIdSocio.Size = new System.Drawing.Size(128, 25);
            this.lblIdSocio.TabIndex = 6;
            this.lblIdSocio.Text = "[N° de Socio]";
            // 
            // lblTituloIdSocio
            // 
            this.lblTituloIdSocio.AutoSize = true;
            this.lblTituloIdSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIdSocio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTituloIdSocio.Location = new System.Drawing.Point(73, 125);
            this.lblTituloIdSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloIdSocio.Name = "lblTituloIdSocio";
            this.lblTituloIdSocio.Size = new System.Drawing.Size(134, 25);
            this.lblTituloIdSocio.TabIndex = 5;
            this.lblTituloIdSocio.Text = "N° de Socio:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDni.Location = new System.Drawing.Point(229, 73);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(53, 25);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "[Dni]";
            // 
            // lblTituloDni
            // 
            this.lblTituloDni.AutoSize = true;
            this.lblTituloDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDni.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTituloDni.Location = new System.Drawing.Point(73, 73);
            this.lblTituloDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDni.Name = "lblTituloDni";
            this.lblTituloDni.Size = new System.Drawing.Size(51, 25);
            this.lblTituloDni.TabIndex = 3;
            this.lblTituloDni.Text = "Dni:";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreCompleto.Location = new System.Drawing.Point(229, 23);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(182, 25);
            this.lblNombreCompleto.TabIndex = 2;
            this.lblNombreCompleto.Text = "[Nombre Completo]";
            // 
            // lblTituloNombreCompleto
            // 
            this.lblTituloNombreCompleto.AutoSize = true;
            this.lblTituloNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombreCompleto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTituloNombreCompleto.Location = new System.Drawing.Point(73, 23);
            this.lblTituloNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloNombreCompleto.Name = "lblTituloNombreCompleto";
            this.lblTituloNombreCompleto.Size = new System.Drawing.Size(94, 25);
            this.lblTituloNombreCompleto.TabIndex = 1;
            this.lblTituloNombreCompleto.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(206, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Club Deportivo - Carnet";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(16, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 73);
            this.panel2.TabIndex = 1;
            // 
            // frmCarnetSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCarnetSocio";
            this.Text = "Carnet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloNombreCompleto;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblTituloDni;
        private System.Windows.Forms.Label lblVencimieto;
        private System.Windows.Forms.Label lblTituloVencimiento;
        private System.Windows.Forms.Label lblIdSocio;
        private System.Windows.Forms.Label lblTituloIdSocio;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel2;
    }
}