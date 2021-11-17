
namespace AAVD
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbMAD = new System.Windows.Forms.CheckBox();
            this.cbAAVD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(101, 12);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(156, 20);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(101, 38);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(156, 20);
            this.tbContraseña.TabIndex = 3;
            this.tbContraseña.TextChanged += new System.EventHandler(this.tbContraseña_TextChanged);
            this.tbContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContraseña_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de usuario:";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Items.AddRange(new object[] {
            "Cliente",
            "Empleado",
            "Administrador"});
            this.cbEmpleado.Location = new System.Drawing.Point(101, 64);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(156, 21);
            this.cbEmpleado.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(182, 91);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(101, 91);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbMAD
            // 
            this.cbMAD.AutoSize = true;
            this.cbMAD.Checked = true;
            this.cbMAD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMAD.Location = new System.Drawing.Point(276, 15);
            this.cbMAD.Name = "cbMAD";
            this.cbMAD.Size = new System.Drawing.Size(50, 17);
            this.cbMAD.TabIndex = 9;
            this.cbMAD.Text = "MAD";
            this.cbMAD.UseVisualStyleBackColor = true;
            this.cbMAD.Click += new System.EventHandler(this.cbMAD_Click);
            // 
            // cbAAVD
            // 
            this.cbAAVD.AutoSize = true;
            this.cbAAVD.Location = new System.Drawing.Point(276, 39);
            this.cbAAVD.Name = "cbAAVD";
            this.cbAAVD.Size = new System.Drawing.Size(55, 17);
            this.cbAAVD.TabIndex = 10;
            this.cbAAVD.Text = "AAVD";
            this.cbAAVD.UseVisualStyleBackColor = true;
            this.cbAAVD.Click += new System.EventHandler(this.cbAAVD_Click);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 152);
            this.Controls.Add(this.cbAAVD);
            this.Controls.Add(this.cbMAD);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FormInicioSesion";
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.FormInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox cbMAD;
        private System.Windows.Forms.CheckBox cbAAVD;
    }
}

