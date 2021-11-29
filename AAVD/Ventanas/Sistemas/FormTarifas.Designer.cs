
namespace AAVD
{
    partial class FormTarifas
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
            this.gbTarifas = new System.Windows.Forms.GroupBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCuotaFija = new System.Windows.Forms.TextBox();
            this.tbRango3 = new System.Windows.Forms.TextBox();
            this.tbRango2 = new System.Windows.Forms.TextBox();
            this.tbRango1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.dgvTarifas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFiltroZona = new System.Windows.Forms.ComboBox();
            this.cbFiltroAño = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFiltroMes = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.numeroZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotaFija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rango1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rango2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rango3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTarifas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zona:";
            // 
            // gbTarifas
            // 
            this.gbTarifas.Controls.Add(this.cbMes);
            this.gbTarifas.Controls.Add(this.cbAño);
            this.gbTarifas.Controls.Add(this.cbTipoServicio);
            this.gbTarifas.Controls.Add(this.label8);
            this.gbTarifas.Controls.Add(this.tbCuotaFija);
            this.gbTarifas.Controls.Add(this.tbRango3);
            this.gbTarifas.Controls.Add(this.tbRango2);
            this.gbTarifas.Controls.Add(this.tbRango1);
            this.gbTarifas.Controls.Add(this.label7);
            this.gbTarifas.Controls.Add(this.label6);
            this.gbTarifas.Controls.Add(this.label5);
            this.gbTarifas.Controls.Add(this.label4);
            this.gbTarifas.Controls.Add(this.label3);
            this.gbTarifas.Controls.Add(this.label2);
            this.gbTarifas.Controls.Add(this.cbZona);
            this.gbTarifas.Controls.Add(this.label1);
            this.gbTarifas.Location = new System.Drawing.Point(12, 12);
            this.gbTarifas.Name = "gbTarifas";
            this.gbTarifas.Size = new System.Drawing.Size(754, 86);
            this.gbTarifas.TabIndex = 1;
            this.gbTarifas.TabStop = false;
            this.gbTarifas.Text = "Informacion tarifas";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(641, 19);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(100, 21);
            this.cbMes.TabIndex = 3;
            // 
            // cbAño
            // 
            this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(480, 19);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(100, 21);
            this.cbAño.TabIndex = 2;
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Location = new System.Drawing.Point(301, 19);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cbTipoServicio.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo de Servicio:";
            // 
            // tbCuotaFija
            // 
            this.tbCuotaFija.Location = new System.Drawing.Point(75, 50);
            this.tbCuotaFija.Name = "tbCuotaFija";
            this.tbCuotaFija.Size = new System.Drawing.Size(121, 20);
            this.tbCuotaFija.TabIndex = 4;
            // 
            // tbRango3
            // 
            this.tbRango3.Location = new System.Drawing.Point(620, 50);
            this.tbRango3.Name = "tbRango3";
            this.tbRango3.Size = new System.Drawing.Size(121, 20);
            this.tbRango3.TabIndex = 7;
            // 
            // tbRango2
            // 
            this.tbRango2.Location = new System.Drawing.Point(439, 50);
            this.tbRango2.Name = "tbRango2";
            this.tbRango2.Size = new System.Drawing.Size(100, 20);
            this.tbRango2.TabIndex = 6;
            // 
            // tbRango1
            // 
            this.tbRango1.Location = new System.Drawing.Point(265, 50);
            this.tbRango1.Name = "tbRango1";
            this.tbRango1.Size = new System.Drawing.Size(100, 20);
            this.tbRango1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rango 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rango 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rango 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuota fija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año:";
            // 
            // cbZona
            // 
            this.cbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Location = new System.Drawing.Point(75, 19);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(121, 21);
            this.cbZona.TabIndex = 0;
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroZona,
            this.tipoServicio,
            this.anio,
            this.mes,
            this.cuotaFija,
            this.rango1,
            this.rango2,
            this.rango3});
            this.dgvTarifas.Location = new System.Drawing.Point(12, 104);
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.Size = new System.Drawing.Size(754, 272);
            this.dgvTarifas.TabIndex = 2;
            this.dgvTarifas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifas_CellClick);
            this.dgvTarifas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvTarifas_CellValidating);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(772, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(772, 46);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(772, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(792, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Zona:";
            // 
            // cbFiltroZona
            // 
            this.cbFiltroZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroZona.FormattingEnabled = true;
            this.cbFiltroZona.Location = new System.Drawing.Point(772, 161);
            this.cbFiltroZona.Name = "cbFiltroZona";
            this.cbFiltroZona.Size = new System.Drawing.Size(75, 21);
            this.cbFiltroZona.TabIndex = 6;
            // 
            // cbFiltroAño
            // 
            this.cbFiltroAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroAño.FormattingEnabled = true;
            this.cbFiltroAño.Location = new System.Drawing.Point(772, 201);
            this.cbFiltroAño.Name = "cbFiltroAño";
            this.cbFiltroAño.Size = new System.Drawing.Size(75, 21);
            this.cbFiltroAño.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(792, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Año:";
            // 
            // cbFiltroMes
            // 
            this.cbFiltroMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroMes.FormattingEnabled = true;
            this.cbFiltroMes.Location = new System.Drawing.Point(772, 241);
            this.cbFiltroMes.Name = "cbFiltroMes";
            this.cbFiltroMes.Size = new System.Drawing.Size(75, 21);
            this.cbFiltroMes.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(792, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mes:";
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(853, 17);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(772, 104);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 4;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(853, 46);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // numeroZona
            // 
            this.numeroZona.DataPropertyName = "numeroZona";
            this.numeroZona.HeaderText = "Numero de Zona";
            this.numeroZona.Name = "numeroZona";
            this.numeroZona.ReadOnly = true;
            // 
            // tipoServicio
            // 
            this.tipoServicio.DataPropertyName = "tipoServicio";
            this.tipoServicio.HeaderText = "Tipo de Servicio";
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.ReadOnly = true;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // cuotaFija
            // 
            this.cuotaFija.DataPropertyName = "cuotaFija";
            this.cuotaFija.HeaderText = "Cuota Fija";
            this.cuotaFija.Name = "cuotaFija";
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
            // FormTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 388);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.cbFiltroMes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFiltroAño);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbFiltroZona);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTarifas);
            this.Controls.Add(this.gbTarifas);
            this.Name = "FormTarifas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifas";
            this.Load += new System.EventHandler(this.FormTarifas_Load);
            this.gbTarifas.ResumeLayout(false);
            this.gbTarifas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTarifas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.TextBox tbRango3;
        private System.Windows.Forms.TextBox tbRango2;
        private System.Windows.Forms.TextBox tbRango1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCuotaFija;
        private System.Windows.Forms.DataGridView dgvTarifas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFiltroZona;
        private System.Windows.Forms.ComboBox cbFiltroAño;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFiltroMes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotaFija;
        private System.Windows.Forms.DataGridViewTextBoxColumn rango1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rango2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rango3;
    }
}