namespace ClubDeportivoEquipo13.Forms
{
    partial class frmVencimientos
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFechaDeConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDePago = new System.Windows.Forms.Label();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(45, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "SOCIOS CON CUOTAS VENCIDAS";
            // 
            // dtpFechaDeConsulta
            // 
            this.dtpFechaDeConsulta.Location = new System.Drawing.Point(130, 57);
            this.dtpFechaDeConsulta.Name = "dtpFechaDeConsulta";
            this.dtpFechaDeConsulta.Size = new System.Drawing.Size(201, 20);
            this.dtpFechaDeConsulta.TabIndex = 9;
            this.dtpFechaDeConsulta.Value = new System.DateTime(2025, 10, 10, 21, 58, 52, 0);
            // 
            // lblFechaDePago
            // 
            this.lblFechaDePago.AutoSize = true;
            this.lblFechaDePago.Location = new System.Drawing.Point(25, 63);
            this.lblFechaDePago.Name = "lblFechaDePago";
            this.lblFechaDePago.Size = new System.Drawing.Size(99, 13);
            this.lblFechaDePago.TabIndex = 8;
            this.lblFechaDePago.Text = "Fecha de Consulta:";
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(111, 101);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(134, 35);
            this.btnGenerarListado.TabIndex = 10;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Socio,
            this.IdSocio,
            this.FechaVencimiento});
            this.dataGridView1.Location = new System.Drawing.Point(27, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 161);
            this.dataGridView1.TabIndex = 11;
            // 
            // Socio
            // 
            this.Socio.HeaderText = "Socio";
            this.Socio.Name = "Socio";
            // 
            // IdSocio
            // 
            this.IdSocio.HeaderText = "ID Socio";
            this.IdSocio.Name = "IdSocio";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Fecha De Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(141, 342);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmVencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 377);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerarListado);
            this.Controls.Add(this.dtpFechaDeConsulta);
            this.Controls.Add(this.lblFechaDePago);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmVencimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Vencimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaDeConsulta;
        private System.Windows.Forms.Label lblFechaDePago;
        private System.Windows.Forms.Button btnGenerarListado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.Button btnAceptar;
    }
}