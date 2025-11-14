namespace ClubDeportivoEquipo13.Forms
{
    partial class frmInscripcion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.CheckBox chkFicha;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;

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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkFicha = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblAsterisco1 = new System.Windows.Forms.Label();
            this.lblAsterisco2 = new System.Windows.Forms.Label();
            this.lblAsterisco = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAsterisco3 = new System.Windows.Forms.Label();
            this.toolTipDocumento = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTelefono = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNombre = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipApellido = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEmail = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDireccion = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(20, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(20, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 23);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.Location = new System.Drawing.Point(20, 110);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(100, 23);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "DNI:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(20, 140);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(20, 170);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(100, 23);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(120, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(120, 110);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(200, 20);
            this.txtDocumento.TabIndex = 8;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 140);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(120, 170);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // chkFicha
            // 
            this.chkFicha.Location = new System.Drawing.Point(120, 230);
            this.chkFicha.Name = "chkFicha";
            this.chkFicha.Size = new System.Drawing.Size(104, 24);
            this.chkFicha.TabIndex = 12;
            this.chkFicha.Text = "Apto Médico";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(245, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(136, 270);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(23, 270);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblAsterisco1
            // 
            this.lblAsterisco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco1.Location = new System.Drawing.Point(326, 55);
            this.lblAsterisco1.Name = "lblAsterisco1";
            this.lblAsterisco1.Size = new System.Drawing.Size(100, 23);
            this.lblAsterisco1.TabIndex = 16;
            this.lblAsterisco1.Text = "*";
            // 
            // lblAsterisco2
            // 
            this.lblAsterisco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco2.Location = new System.Drawing.Point(326, 81);
            this.lblAsterisco2.Name = "lblAsterisco2";
            this.lblAsterisco2.Size = new System.Drawing.Size(100, 23);
            this.lblAsterisco2.TabIndex = 17;
            this.lblAsterisco2.Text = "*";
            // 
            // lblAsterisco
            // 
            this.lblAsterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco.Location = new System.Drawing.Point(198, 231);
            this.lblAsterisco.Name = "lblAsterisco";
            this.lblAsterisco.Size = new System.Drawing.Size(100, 23);
            this.lblAsterisco.TabIndex = 19;
            this.lblAsterisco.Text = "*";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(326, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(326, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 21;
            // 
            // lblAsterisco3
            // 
            this.lblAsterisco3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco3.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco3.Location = new System.Drawing.Point(326, 110);
            this.lblAsterisco3.Name = "lblAsterisco3";
            this.lblAsterisco3.Size = new System.Drawing.Size(100, 23);
            this.lblAsterisco3.TabIndex = 18;
            this.lblAsterisco3.Text = "*";
            // 
            // frmInscripcion
            // 
            this.ClientSize = new System.Drawing.Size(350, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAsterisco);
            this.Controls.Add(this.lblAsterisco3);
            this.Controls.Add(this.lblAsterisco2);
            this.Controls.Add(this.lblAsterisco1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkFicha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscribir Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblAsterisco1;
        private System.Windows.Forms.Label lblAsterisco2;
        private System.Windows.Forms.Label lblAsterisco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAsterisco3;
        private System.Windows.Forms.ToolTip toolTipDocumento;
        private System.Windows.Forms.ToolTip toolTipTelefono;
        private System.Windows.Forms.ToolTip toolTipNombre;
        private System.Windows.Forms.ToolTip toolTipApellido;
        private System.Windows.Forms.ToolTip toolTipEmail;
        private System.Windows.Forms.ToolTip toolTipDireccion;
    }
}