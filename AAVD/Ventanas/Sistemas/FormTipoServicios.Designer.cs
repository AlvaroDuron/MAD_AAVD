
namespace AAVD
{
    partial class FormTipoServicios
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvTipoServicio = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotaDrenaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rango1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rango2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rango3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(563, 41);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvTipoServicio
            // 
            this.dgvTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cuotaDrenaje,
            this.rango1,
            this.rango2,
            this.rango3});
            this.dgvTipoServicio.Location = new System.Drawing.Point(12, 12);
            this.dgvTipoServicio.Name = "dgvTipoServicio";
            this.dgvTipoServicio.Size = new System.Drawing.Size(545, 158);
            this.dgvTipoServicio.TabIndex = 17;
            this.dgvTipoServicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoServicio_CellClick);
            this.dgvTipoServicio.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvTipoServicio_CellValidating);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(563, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Tipo de Servicio";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cuotaDrenaje
            // 
            this.cuotaDrenaje.DataPropertyName = "cuotaDrenaje";
            this.cuotaDrenaje.HeaderText = "Cuota de Drenaje";
            this.cuotaDrenaje.Name = "cuotaDrenaje";
            // 
            // rango1
            // 
            this.rango1.DataPropertyName = "rango1";
            this.rango1.HeaderText = "Rango 1";
            this.rango1.Name = "rango1";
            // 
            // rango2
            // 
            this.rango2.DataPropertyName = "rango2";
            this.rango2.HeaderText = "Rango 2";
            this.rango2.Name = "rango2";
            // 
            // rango3
            // 
            this.rango3.DataPropertyName = "rango3";
            this.rango3.HeaderText = "Rango 3";
            this.rango3.Name = "rango3";
            // 
            // FormTipoServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 185);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvTipoServicio);
            this.Controls.Add(this.btnModificar);
            this.Name = "FormTipoServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de servicio";
            this.Load += new System.EventHandler(this.FormTipoServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvTipoServicio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotaDrenaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn rango1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rango2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rango3;
    }
}