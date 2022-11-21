namespace PROYECTO_FINAL_Progra_II
{
    partial class frmAgregarProductoLista
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
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(346, 28);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.RowHeadersWidth = 51;
            this.dtgProductos.RowTemplate.Height = 24;
            this.dtgProductos.Size = new System.Drawing.Size(564, 286);
            this.dtgProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CANTIDAD\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CATEGORIA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(143, 141);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(143, 79);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // frmAgregarProductoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 380);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgProductos);
            this.Name = "frmAgregarProductoLista";
            this.Text = "frmAgregarProductoLista";
            this.Load += new System.EventHandler(this.frmAgregarProductoLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}