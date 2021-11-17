
namespace AAVD
{
    partial class FormPantallaPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTarifas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemZonas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTipoServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.consumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsumoHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.itemReporteConsumos = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGenerarRecibo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsultarRecibo = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoDeServicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnContratos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Location = new System.Drawing.Point(12, 54);
            this.dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.Size = new System.Drawing.Size(481, 339);
            this.dgvClientes.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemParametros,
            this.itemTarifas,
            this.itemZonas,
            this.itemCategorias,
            this.itemTipoServicio,
            this.consumosToolStripMenuItem,
            this.recibosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemParametros
            // 
            this.itemParametros.Name = "itemParametros";
            this.itemParametros.Size = new System.Drawing.Size(79, 20);
            this.itemParametros.Text = "Parametros";
            // 
            // itemTarifas
            // 
            this.itemTarifas.Name = "itemTarifas";
            this.itemTarifas.Size = new System.Drawing.Size(52, 20);
            this.itemTarifas.Text = "Tarifas";
            // 
            // itemZonas
            // 
            this.itemZonas.Name = "itemZonas";
            this.itemZonas.Size = new System.Drawing.Size(51, 20);
            this.itemZonas.Text = "Zonas";
            // 
            // itemCategorias
            // 
            this.itemCategorias.Name = "itemCategorias";
            this.itemCategorias.Size = new System.Drawing.Size(75, 20);
            this.itemCategorias.Text = "Categorias";
            // 
            // itemTipoServicio
            // 
            this.itemTipoServicio.Name = "itemTipoServicio";
            this.itemTipoServicio.Size = new System.Drawing.Size(106, 20);
            this.itemTipoServicio.Text = "Tipos de servicio";
            // 
            // consumosToolStripMenuItem
            // 
            this.consumosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemConsumoHistorico,
            this.itemReporteConsumos});
            this.consumosToolStripMenuItem.Name = "consumosToolStripMenuItem";
            this.consumosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.consumosToolStripMenuItem.Text = "Consumos";
            // 
            // itemConsumoHistorico
            // 
            this.itemConsumoHistorico.Name = "itemConsumoHistorico";
            this.itemConsumoHistorico.Size = new System.Drawing.Size(189, 22);
            this.itemConsumoHistorico.Text = "Consumo historico";
            // 
            // itemReporteConsumos
            // 
            this.itemReporteConsumos.Name = "itemReporteConsumos";
            this.itemReporteConsumos.Size = new System.Drawing.Size(189, 22);
            this.itemReporteConsumos.Text = "Reporte de consumos";
            // 
            // recibosToolStripMenuItem
            // 
            this.recibosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGenerarRecibo,
            this.itemConsultarRecibo});
            this.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            this.recibosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.recibosToolStripMenuItem.Text = "Recibos";
            // 
            // itemGenerarRecibo
            // 
            this.itemGenerarRecibo.Name = "itemGenerarRecibo";
            this.itemGenerarRecibo.Size = new System.Drawing.Size(164, 22);
            this.itemGenerarRecibo.Text = "Generar recibo(s)";
            // 
            // itemConsultarRecibo
            // 
            this.itemConsultarRecibo.Name = "itemConsultarRecibo";
            this.itemConsultarRecibo.Size = new System.Drawing.Size(164, 22);
            this.itemConsultarRecibo.Text = "Consultar recibo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de cliente:";
            // 
            // cbTipoDeServicio
            // 
            this.cbTipoDeServicio.FormattingEnabled = true;
            this.cbTipoDeServicio.Location = new System.Drawing.Point(219, 27);
            this.cbTipoDeServicio.Name = "cbTipoDeServicio";
            this.cbTipoDeServicio.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDeServicio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "curp/rfc:";
            // 
            // tbBuscarCliente
            // 
            this.tbBuscarCliente.Location = new System.Drawing.Point(393, 27);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(100, 20);
            this.tbBuscarCliente.TabIndex = 5;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(499, 54);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 6;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(499, 83);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCliente.TabIndex = 7;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(499, 112);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCliente.TabIndex = 8;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnContratos
            // 
            this.btnContratos.Location = new System.Drawing.Point(499, 141);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(75, 24);
            this.btnContratos.TabIndex = 9;
            this.btnContratos.Text = "Contrato(s)";
            this.btnContratos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(499, 171);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 405);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnContratos);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.tbBuscarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoDeServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPantallaPrincipal";
            this.Text = "Pantalla principal";
            this.Load += new System.EventHandler(this.FormPantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemParametros;
        private System.Windows.Forms.ToolStripMenuItem itemTarifas;
        private System.Windows.Forms.ToolStripMenuItem itemZonas;
        private System.Windows.Forms.ToolStripMenuItem itemCategorias;
        private System.Windows.Forms.ToolStripMenuItem itemTipoServicio;
        private System.Windows.Forms.ToolStripMenuItem consumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemConsumoHistorico;
        private System.Windows.Forms.ToolStripMenuItem itemReporteConsumos;
        private System.Windows.Forms.ToolStripMenuItem recibosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemGenerarRecibo;
        private System.Windows.Forms.ToolStripMenuItem itemConsultarRecibo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoDeServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.Button btnSalir;
    }
}