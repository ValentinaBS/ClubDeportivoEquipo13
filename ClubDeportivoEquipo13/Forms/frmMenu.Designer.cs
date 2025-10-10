namespace ClubDeportivoEquipo13.Forms
{
    partial class frmMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVencimientos;
        private System.Windows.Forms.Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnVencimientos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(20, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 17);
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(30, 60);
            this.btnInscribir.Size = new System.Drawing.Size(200, 40);
            this.btnInscribir.Text = "Inscribir Persona";
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(30, 110);
            this.btnPagar.Size = new System.Drawing.Size(200, 40);
            this.btnPagar.Text = "Pagar Cuota";
            // 
            // btnVencimientos
            // 
            this.btnVencimientos.Location = new System.Drawing.Point(30, 160);
            this.btnVencimientos.Size = new System.Drawing.Size(200, 40);
            this.btnVencimientos.Text = "Listar Vencimientos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(30, 210);
            this.btnSalir.Size = new System.Drawing.Size(200, 40);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenu
            // 
            this.ClientSize = new System.Drawing.Size(280, 280);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnVencimientos);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmMenu";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}