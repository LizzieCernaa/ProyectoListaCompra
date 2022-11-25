namespace PROYECTO_FINAL_Progra_II
{
    partial class Form_Historial
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
            this.components = new System.ComponentModel.Container();
            this.dtgHistorico = new System.Windows.Forms.DataGridView();
            this.idListaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supermercadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaCompraHistoricoDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtgListas = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleCompraHistoricoDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompraHistoricoDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraHistoricoDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHistorico
            // 
            this.dtgHistorico.AutoGenerateColumns = false;
            this.dtgHistorico.BackgroundColor = System.Drawing.Color.Linen;
            this.dtgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idListaCompraDataGridViewTextBoxColumn,
            this.supermercadoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dtgHistorico.DataSource = this.listaCompraHistoricoDtoBindingSource;
            this.dtgHistorico.Location = new System.Drawing.Point(28, 127);
            this.dtgHistorico.MultiSelect = false;
            this.dtgHistorico.Name = "dtgHistorico";
            this.dtgHistorico.ReadOnly = true;
            this.dtgHistorico.RowHeadersWidth = 51;
            this.dtgHistorico.RowTemplate.Height = 24;
            this.dtgHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHistorico.Size = new System.Drawing.Size(583, 369);
            this.dtgHistorico.TabIndex = 0;
            this.dtgHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtgHistorico.SelectionChanged += new System.EventHandler(this.dtgHistorico_SelectionChanged);
            // 
            // idListaCompraDataGridViewTextBoxColumn
            // 
            this.idListaCompraDataGridViewTextBoxColumn.DataPropertyName = "IdListaCompra";
            this.idListaCompraDataGridViewTextBoxColumn.HeaderText = "IdListaCompra";
            this.idListaCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idListaCompraDataGridViewTextBoxColumn.Name = "idListaCompraDataGridViewTextBoxColumn";
            this.idListaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idListaCompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // supermercadoDataGridViewTextBoxColumn
            // 
            this.supermercadoDataGridViewTextBoxColumn.DataPropertyName = "Supermercado";
            this.supermercadoDataGridViewTextBoxColumn.HeaderText = "Supermercado";
            this.supermercadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supermercadoDataGridViewTextBoxColumn.Name = "supermercadoDataGridViewTextBoxColumn";
            this.supermercadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.supermercadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // listaCompraHistoricoDtoBindingSource
            // 
            this.listaCompraHistoricoDtoBindingSource.DataSource = typeof(PROYECTO_FINAL_Progra_II.Dto.ListaCompraHistoricoDto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORIAL DE COMPRAS";
            // 
            // dtgListas
            // 
            this.dtgListas.AutoSize = true;
            this.dtgListas.Location = new System.Drawing.Point(39, 95);
            this.dtgListas.Name = "dtgListas";
            this.dtgListas.Size = new System.Drawing.Size(136, 16);
            this.dtgListas.TabIndex = 2;
            this.dtgListas.Text = "LISTAS DE COMPRA";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(1383, 523);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(128, 45);
            this.btn_Cerrar.TabIndex = 14;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AutoGenerateColumns = false;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.subTotalDataGridViewTextBoxColumn});
            this.dtgDetalle.DataSource = this.detalleCompraHistoricoDtoBindingSource;
            this.dtgDetalle.Location = new System.Drawing.Point(701, 116);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.RowHeadersWidth = 51;
            this.dtgDetalle.RowTemplate.Height = 24;
            this.dtgDetalle.Size = new System.Drawing.Size(810, 369);
            this.dtgDetalle.TabIndex = 15;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Width = 60;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 60;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 60;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotoDataGridViewImageColumn.MinimumWidth = 6;
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            this.fotoDataGridViewImageColumn.Width = 125;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // detalleCompraHistoricoDtoBindingSource
            // 
            this.detalleCompraHistoricoDtoBindingSource.DataSource = typeof(PROYECTO_FINAL_Progra_II.Dto.DetalleCompraHistoricoDto);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(713, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "TOTAL";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotal.Location = new System.Drawing.Point(893, 488);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(180, 23);
            this.lbTotal.TabIndex = 22;
            this.lbTotal.Text = "0.0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_FINAL_Progra_II.Properties.Resources._120269;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.dtgListas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Historial";
            this.Text = "HISTORIAL DE COMPRAS";
            this.Load += new System.EventHandler(this.Form_Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompraHistoricoDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraHistoricoDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHistorico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dtgListas;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idListaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supermercadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listaCompraHistoricoDtoBindingSource;
        private System.Windows.Forms.BindingSource detalleCompraHistoricoDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}