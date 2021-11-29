
namespace AAVD
{
    partial class FormRecibos
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
            this.dgvRecibo = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTipoServicio = new System.Windows.Forms.CheckBox();
            this.bRegresar = new System.Windows.Forms.Button();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expedicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecibo
            // 
            this.dgvRecibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuario,
            this.numeroContrato,
            this.anio,
            this.mes,
            this.expedicion,
            this.numeroZona,
            this.consumo,
            this.subtotal1,
            this.subtotal2,
            this.subtotal3,
            this.total,
            this.vencimiento,
            this.pagado});
            this.dgvRecibo.Location = new System.Drawing.Point(12, 167);
            this.dgvRecibo.Name = "dgvRecibo";
            this.dgvRecibo.Size = new System.Drawing.Size(778, 271);
            this.dgvRecibo.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "Año:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(124, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 13);
            this.label24.TabIndex = 43;
            this.label24.Text = "Mes:";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(160, 19);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(75, 21);
            this.cbMes.TabIndex = 47;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // cbAño
            // 
            this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(43, 19);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(75, 21);
            this.cbAño.TabIndex = 46;
            this.cbAño.SelectedIndexChanged += new System.EventHandler(this.cbAño_SelectedIndexChanged);
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoServicio.Enabled = false;
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Location = new System.Drawing.Point(114, 80);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cbTipoServicio.TabIndex = 48;
            this.cbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cbTipoServicio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tipo de Servicio:";
            // 
            // bGenerar
            // 
            this.bGenerar.Location = new System.Drawing.Point(82, 114);
            this.bGenerar.Name = "bGenerar";
            this.bGenerar.Size = new System.Drawing.Size(106, 23);
            this.bGenerar.TabIndex = 50;
            this.bGenerar.Text = "Generar Recibos";
            this.bGenerar.UseVisualStyleBackColor = true;
            this.bGenerar.Click += new System.EventHandler(this.bGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTipoServicio);
            this.groupBox1.Controls.Add(this.bGenerar);
            this.groupBox1.Controls.Add(this.cbMes);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.cbTipoServicio);
            this.groupBox1.Controls.Add(this.cbAño);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 149);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbTipoServicio
            // 
            this.rbTipoServicio.AutoSize = true;
            this.rbTipoServicio.Location = new System.Drawing.Point(61, 57);
            this.rbTipoServicio.Name = "rbTipoServicio";
            this.rbTipoServicio.Size = new System.Drawing.Size(127, 17);
            this.rbTipoServicio.TabIndex = 50;
            this.rbTipoServicio.Text = "Por Tipos de Servicio";
            this.rbTipoServicio.UseVisualStyleBackColor = true;
            this.rbTipoServicio.CheckedChanged += new System.EventHandler(this.rbTipoServicio_CheckedChanged);
            // 
            // bRegresar
            // 
            this.bRegresar.Location = new System.Drawing.Point(715, 24);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(75, 23);
            this.bRegresar.TabIndex = 52;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = true;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.DataPropertyName = "nombreUsuario";
            this.nombreUsuario.HeaderText = "Nombre de Usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // numeroContrato
            // 
            this.numeroContrato.DataPropertyName = "numeroContrato";
            this.numeroContrato.HeaderText = "Numero de Contrato";
            this.numeroContrato.Name = "numeroContrato";
            this.numeroContrato.ReadOnly = true;
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
            // expedicion
            // 
            this.expedicion.DataPropertyName = "expedicion";
            this.expedicion.HeaderText = "Lugar de Expedicion";
            this.expedicion.Name = "expedicion";
            this.expedicion.ReadOnly = true;
            // 
            // numeroZona
            // 
            this.numeroZona.DataPropertyName = "numeroZona";
            this.numeroZona.HeaderText = "Numero de Zona";
            this.numeroZona.Name = "numeroZona";
            this.numeroZona.ReadOnly = true;
            // 
            // consumo
            // 
            this.consumo.DataPropertyName = "consumo";
            this.consumo.HeaderText = "Consumo";
            this.consumo.Name = "consumo";
            this.consumo.ReadOnly = true;
            // 
            // subtotal1
            // 
            this.subtotal1.DataPropertyName = "subtotal1";
            this.subtotal1.HeaderText = "Subtotal 1";
            this.subtotal1.Name = "subtotal1";
            this.subtotal1.ReadOnly = true;
            // 
            // subtotal2
            // 
            this.subtotal2.DataPropertyName = "subtotal2";
            this.subtotal2.HeaderText = "Subtotal 2";
            this.subtotal2.Name = "subtotal2";
            this.subtotal2.ReadOnly = true;
            // 
            // subtotal3
            // 
            this.subtotal3.DataPropertyName = "subtotal3";
            this.subtotal3.HeaderText = "Subtotal 3";
            this.subtotal3.Name = "subtotal3";
            this.subtotal3.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // vencimiento
            // 
            this.vencimiento.DataPropertyName = "vencimiento";
            this.vencimiento.HeaderText = "Fecha de Vencimiento";
            this.vencimiento.Name = "vencimiento";
            this.vencimiento.ReadOnly = true;
            // 
            // pagado
            // 
            this.pagado.DataPropertyName = "pagado";
            this.pagado.HeaderText = "Pagado";
            this.pagado.Name = "pagado";
            // 
            // FormRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRecibo);
            this.Name = "FormRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibos";
            this.Load += new System.EventHandler(this.FormRecibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRecibo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rbTipoServicio;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn expedicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal3;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagado;
    }
}