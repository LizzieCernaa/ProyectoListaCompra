namespace PROYECTO_FINAL_Progra_II
{
    partial class Form_NuevaLista
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bton_Guardar = new System.Windows.Forms.Button();
            this.btn_AgregarProductos = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.cmbSupermercados = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR LISTA ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "SUPERMERCADO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 268);
            this.dataGridView1.TabIndex = 9;
            // 
            // bton_Guardar
            // 
            this.bton_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bton_Guardar.Location = new System.Drawing.Point(35, 502);
            this.bton_Guardar.Name = "bton_Guardar";
            this.bton_Guardar.Size = new System.Drawing.Size(130, 47);
            this.bton_Guardar.TabIndex = 10;
            this.bton_Guardar.Text = "Guardar";
            this.bton_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_AgregarProductos
            // 
            this.btn_AgregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_AgregarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProductos.Location = new System.Drawing.Point(532, 404);
            this.btn_AgregarProductos.Name = "btn_AgregarProductos";
            this.btn_AgregarProductos.Size = new System.Drawing.Size(138, 47);
            this.btn_AgregarProductos.TabIndex = 11;
            this.btn_AgregarProductos.Text = "Agregar Productos ->";
            this.btn_AgregarProductos.UseVisualStyleBackColor = false;
            this.btn_AgregarProductos.Click += new System.EventHandler(this.btn_AgregarProductos_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(189, 579);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(105, 47);
            this.btn_Actualizar.TabIndex = 12;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(337, 502);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(138, 45);
            this.btn_Cerrar.TabIndex = 13;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // cmbSupermercados
            // 
            this.cmbSupermercados.FormattingEnabled = true;
            this.cmbSupermercados.Location = new System.Drawing.Point(288, 129);
            this.cmbSupermercados.Name = "cmbSupermercados";
            this.cmbSupermercados.Size = new System.Drawing.Size(164, 24);
            this.cmbSupermercados.TabIndex = 14;
            // 
            // Form_NuevaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 712);
            this.Controls.Add(this.cmbSupermercados);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_AgregarProductos);
            this.Controls.Add(this.bton_Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_NuevaLista";
            this.Text = "NUEVA LISTA";
            this.Load += new System.EventHandler(this.Form_NuevaLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bton_Guardar;
        private System.Windows.Forms.Button btn_AgregarProductos;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.ComboBox cmbSupermercados;
    }
}