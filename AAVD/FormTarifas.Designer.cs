
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
            this.cbParametro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCuotaFija = new System.Windows.Forms.TextBox();
            this.tbExcedente = new System.Windows.Forms.TextBox();
            this.tbIntermedio = new System.Windows.Forms.TextBox();
            this.tbBasico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMes = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumeroZona = new System.Windows.Forms.ComboBox();
            this.dgvTarifas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbTarifas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de zona:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbTarifas
            // 
            this.gbTarifas.Controls.Add(this.cbParametro);
            this.gbTarifas.Controls.Add(this.label8);
            this.gbTarifas.Controls.Add(this.tbCuotaFija);
            this.gbTarifas.Controls.Add(this.tbExcedente);
            this.gbTarifas.Controls.Add(this.tbIntermedio);
            this.gbTarifas.Controls.Add(this.tbBasico);
            this.gbTarifas.Controls.Add(this.label7);
            this.gbTarifas.Controls.Add(this.label6);
            this.gbTarifas.Controls.Add(this.label5);
            this.gbTarifas.Controls.Add(this.label4);
            this.gbTarifas.Controls.Add(this.tbMes);
            this.gbTarifas.Controls.Add(this.tbAño);
            this.gbTarifas.Controls.Add(this.label3);
            this.gbTarifas.Controls.Add(this.label2);
            this.gbTarifas.Controls.Add(this.cbNumeroZona);
            this.gbTarifas.Controls.Add(this.label1);
            this.gbTarifas.Location = new System.Drawing.Point(12, 12);
            this.gbTarifas.Name = "gbTarifas";
            this.gbTarifas.Size = new System.Drawing.Size(754, 86);
            this.gbTarifas.TabIndex = 1;
            this.gbTarifas.TabStop = false;
            this.gbTarifas.Text = "Informacion tarifas";
            // 
            // cbParametro
            // 
            this.cbParametro.FormattingEnabled = true;
            this.cbParametro.Location = new System.Drawing.Point(620, 19);
            this.cbParametro.Name = "cbParametro";
            this.cbParametro.Size = new System.Drawing.Size(121, 21);
            this.cbParametro.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Parametro:";
            // 
            // tbCuotaFija
            // 
            this.tbCuotaFija.Location = new System.Drawing.Point(101, 50);
            this.tbCuotaFija.Name = "tbCuotaFija";
            this.tbCuotaFija.Size = new System.Drawing.Size(121, 20);
            this.tbCuotaFija.TabIndex = 14;
            // 
            // tbExcedente
            // 
            this.tbExcedente.Location = new System.Drawing.Point(620, 50);
            this.tbExcedente.Name = "tbExcedente";
            this.tbExcedente.Size = new System.Drawing.Size(121, 20);
            this.tbExcedente.TabIndex = 13;
            // 
            // tbIntermedio
            // 
            this.tbIntermedio.Location = new System.Drawing.Point(447, 50);
            this.tbIntermedio.Name = "tbIntermedio";
            this.tbIntermedio.Size = new System.Drawing.Size(100, 20);
            this.tbIntermedio.TabIndex = 12;
            // 
            // tbBasico
            // 
            this.tbBasico.Location = new System.Drawing.Point(276, 50);
            this.tbBasico.Name = "tbBasico";
            this.tbBasico.Size = new System.Drawing.Size(100, 20);
            this.tbBasico.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 53);
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
            this.label5.Location = new System.Drawing.Point(228, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rango 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuota fija:";
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(447, 19);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(100, 20);
            this.tbMes.TabIndex = 6;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(276, 19);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(100, 20);
            this.tbAño.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbNumeroZona
            // 
            this.cbNumeroZona.FormattingEnabled = true;
            this.cbNumeroZona.Location = new System.Drawing.Point(101, 19);
            this.cbNumeroZona.Name = "cbNumeroZona";
            this.cbNumeroZona.Size = new System.Drawing.Size(121, 21);
            this.cbNumeroZona.TabIndex = 1;
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifas.Location = new System.Drawing.Point(12, 104);
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.Size = new System.Drawing.Size(754, 158);
            this.dgvTarifas.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(772, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(772, 46);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(772, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
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
            // cbZona
            // 
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Location = new System.Drawing.Point(772, 161);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(75, 21);
            this.cbZona.TabIndex = 17;
            // 
            // cbAño
            // 
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(772, 201);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(75, 21);
            this.cbAño.TabIndex = 18;
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
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(772, 241);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(75, 21);
            this.cbMes.TabIndex = 20;
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
            this.btnImportar.TabIndex = 22;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(772, 104);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 23;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(853, 46);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // FormTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 274);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbAño);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbZona);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTarifas);
            this.Controls.Add(this.gbTarifas);
            this.Name = "FormTarifas";
            this.Text = "Tarifas";
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
        private System.Windows.Forms.ComboBox cbNumeroZona;
        private System.Windows.Forms.TextBox tbExcedente;
        private System.Windows.Forms.TextBox tbIntermedio;
        private System.Windows.Forms.TextBox tbBasico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbParametro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCuotaFija;
        private System.Windows.Forms.DataGridView dgvTarifas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnRegresar;
    }
}