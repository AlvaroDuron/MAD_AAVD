
namespace AAVD
{
    partial class FormConsumos
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
            this.gbConsumos = new System.Windows.Forms.GroupBox();
            this.tbLecturaActual = new System.Windows.Forms.TextBox();
            this.tbLecturaAnterior = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.tbNumeroMedidor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvConsumo = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroMedidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturaAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturaActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsumos
            // 
            this.gbConsumos.Controls.Add(this.tbLecturaActual);
            this.gbConsumos.Controls.Add(this.tbLecturaAnterior);
            this.gbConsumos.Controls.Add(this.label3);
            this.gbConsumos.Controls.Add(this.label2);
            this.gbConsumos.Controls.Add(this.cbMes);
            this.gbConsumos.Controls.Add(this.tbNumeroMedidor);
            this.gbConsumos.Controls.Add(this.label11);
            this.gbConsumos.Controls.Add(this.label1);
            this.gbConsumos.Controls.Add(this.cbAño);
            this.gbConsumos.Controls.Add(this.label10);
            this.gbConsumos.Location = new System.Drawing.Point(12, 12);
            this.gbConsumos.Name = "gbConsumos";
            this.gbConsumos.Size = new System.Drawing.Size(247, 131);
            this.gbConsumos.TabIndex = 0;
            this.gbConsumos.TabStop = false;
            this.gbConsumos.Text = "Informacion de consumos";
            // 
            // tbLecturaActual
            // 
            this.tbLecturaActual.Location = new System.Drawing.Point(114, 98);
            this.tbLecturaActual.Name = "tbLecturaActual";
            this.tbLecturaActual.Size = new System.Drawing.Size(119, 20);
            this.tbLecturaActual.TabIndex = 29;
            // 
            // tbLecturaAnterior
            // 
            this.tbLecturaAnterior.Location = new System.Drawing.Point(114, 72);
            this.tbLecturaAnterior.Name = "tbLecturaAnterior";
            this.tbLecturaAnterior.Size = new System.Drawing.Size(119, 20);
            this.tbLecturaAnterior.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Lectura actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lectura anterior:";
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(158, 45);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(75, 21);
            this.cbMes.TabIndex = 24;
            // 
            // tbNumeroMedidor
            // 
            this.tbNumeroMedidor.Location = new System.Drawing.Point(114, 19);
            this.tbNumeroMedidor.Name = "tbNumeroMedidor";
            this.tbNumeroMedidor.Size = new System.Drawing.Size(119, 20);
            this.tbNumeroMedidor.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de medidor:";
            // 
            // cbAño
            // 
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(41, 45);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(75, 21);
            this.cbAño.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Año:";
            // 
            // dgvConsumo
            // 
            this.dgvConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.año,
            this.mes,
            this.numeroMedidor,
            this.lecturaAnterior,
            this.lecturaActual,
            this.consumo});
            this.dgvConsumo.Location = new System.Drawing.Point(12, 149);
            this.dgvConsumo.Name = "dgvConsumo";
            this.dgvConsumo.Size = new System.Drawing.Size(328, 131);
            this.dgvConsumo.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(265, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(265, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(265, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(265, 99);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(346, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mes:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(346, 165);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Año:";
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(346, 12);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 34;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(345, 232);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 35;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // año
            // 
            this.año.DataPropertyName = "año";
            this.año.HeaderText = "Año";
            this.año.Name = "año";
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            // 
            // numeroMedidor
            // 
            this.numeroMedidor.DataPropertyName = "numeroMedidor";
            this.numeroMedidor.HeaderText = "Numero de Medidor";
            this.numeroMedidor.Name = "numeroMedidor";
            // 
            // lecturaAnterior
            // 
            this.lecturaAnterior.DataPropertyName = "lecturaAnterior";
            this.lecturaAnterior.HeaderText = "Lectura Anterior";
            this.lecturaAnterior.Name = "lecturaAnterior";
            // 
            // lecturaActual
            // 
            this.lecturaActual.DataPropertyName = "lecturaActual";
            this.lecturaActual.HeaderText = "Lectura Actual";
            this.lecturaActual.Name = "lecturaActual";
            // 
            // consumo
            // 
            this.consumo.DataPropertyName = "consumo";
            this.consumo.HeaderText = "Consumo";
            this.consumo.Name = "consumo";
            // 
            // FormConsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 290);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvConsumo);
            this.Controls.Add(this.gbConsumos);
            this.Name = "FormConsumos";
            this.Text = "Consumos";
            this.gbConsumos.ResumeLayout(false);
            this.gbConsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsumos;
        private System.Windows.Forms.TextBox tbNumeroMedidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLecturaActual;
        private System.Windows.Forms.TextBox tbLecturaAnterior;
        private System.Windows.Forms.DataGridView dgvConsumo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroMedidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturaAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturaActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumo;
    }
}