
namespace AAVD
{
    partial class FormParametros
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.tbRango3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRango2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRango1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCuotaFija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvParametro = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(66, 19);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 1;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.tbRango3);
            this.gbParametros.Controls.Add(this.label5);
            this.gbParametros.Controls.Add(this.tbRango2);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.tbRango1);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.tbCuotaFija);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.tbId);
            this.gbParametros.Location = new System.Drawing.Point(12, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(180, 158);
            this.gbParametros.TabIndex = 2;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Informacion parametros";
            // 
            // tbRango3
            // 
            this.tbRango3.Location = new System.Drawing.Point(66, 123);
            this.tbRango3.Name = "tbRango3";
            this.tbRango3.Size = new System.Drawing.Size(100, 20);
            this.tbRango3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rango3:";
            // 
            // tbRango2
            // 
            this.tbRango2.Location = new System.Drawing.Point(66, 97);
            this.tbRango2.Name = "tbRango2";
            this.tbRango2.Size = new System.Drawing.Size(100, 20);
            this.tbRango2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rango2:";
            // 
            // tbRango1
            // 
            this.tbRango1.Location = new System.Drawing.Point(66, 71);
            this.tbRango1.Name = "tbRango1";
            this.tbRango1.Size = new System.Drawing.Size(100, 20);
            this.tbRango1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rango1:";
            // 
            // tbCuotaFija
            // 
            this.tbCuotaFija.Location = new System.Drawing.Point(66, 45);
            this.tbCuotaFija.Name = "tbCuotaFija";
            this.tbCuotaFija.Size = new System.Drawing.Size(100, 20);
            this.tbCuotaFija.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuota fija:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(198, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(198, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(198, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvParametro
            // 
            this.dgvParametro.AllowUserToAddRows = false;
            this.dgvParametro.AllowUserToDeleteRows = false;
            this.dgvParametro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametro.Location = new System.Drawing.Point(279, 12);
            this.dgvParametro.Name = "dgvParametro";
            this.dgvParametro.ReadOnly = true;
            this.dgvParametro.Size = new System.Drawing.Size(418, 158);
            this.dgvParametro.TabIndex = 6;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(198, 99);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 180);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvParametro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbParametros);
            this.Name = "FormParametros";
            this.Text = "Parametros";
            this.Load += new System.EventHandler(this.FormParametros_Load);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.TextBox tbRango3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRango2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRango1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCuotaFija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvParametro;
        private System.Windows.Forms.Button btnRegresar;
    }
}