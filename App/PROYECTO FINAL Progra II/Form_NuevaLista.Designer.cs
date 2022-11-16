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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CodigoLista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreLista = new System.Windows.Forms.TextBox();
            this.txt_Supermercado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bton_Guardar = new System.Windows.Forms.Button();
            this.btn_AgregarProductos = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "# CÓDIGO DE LISTA:";
            // 
            // txt_CodigoLista
            // 
            this.txt_CodigoLista.Location = new System.Drawing.Point(183, 91);
            this.txt_CodigoLista.Name = "txt_CodigoLista";
            this.txt_CodigoLista.Size = new System.Drawing.Size(130, 22);
            this.txt_CodigoLista.TabIndex = 2;
            this.txt_CodigoLista.TextChanged += new System.EventHandler(this.txt_CodigoLista_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de lista:";
            // 
            // txt_NombreLista
            // 
            this.txt_NombreLista.Location = new System.Drawing.Point(183, 135);
            this.txt_NombreLista.Name = "txt_NombreLista";
            this.txt_NombreLista.Size = new System.Drawing.Size(130, 22);
            this.txt_NombreLista.TabIndex = 4;
            // 
            // txt_Supermercado
            // 
            this.txt_Supermercado.Location = new System.Drawing.Point(183, 184);
            this.txt_Supermercado.Name = "txt_Supermercado";
            this.txt_Supermercado.Size = new System.Drawing.Size(130, 22);
            this.txt_Supermercado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Supermercado:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 229);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 160);
            this.dataGridView1.TabIndex = 9;
            // 
            // bton_Guardar
            // 
            this.bton_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bton_Guardar.Location = new System.Drawing.Point(183, 277);
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
            this.btn_AgregarProductos.Location = new System.Drawing.Point(811, 277);
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
            this.btn_Actualizar.Location = new System.Drawing.Point(374, 277);
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
            this.btn_Cerrar.Location = new System.Drawing.Point(811, 341);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(138, 45);
            this.btn_Cerrar.TabIndex = 13;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Form_NuevaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 398);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_AgregarProductos);
            this.Controls.Add(this.bton_Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_Supermercado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NombreLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CodigoLista);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CodigoLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreLista;
        private System.Windows.Forms.TextBox txt_Supermercado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bton_Guardar;
        private System.Windows.Forms.Button btn_AgregarProductos;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}