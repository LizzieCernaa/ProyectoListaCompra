namespace PROYECTO_FINAL_Progra_II
{
    partial class Form_AgregarProductos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.ptxFoto = new System.Windows.Forms.PictureBox();
            this.cmbSupermercados = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "AGREGAR PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SUPERMERCADO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE DEL PRODUCTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRECIO:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(286, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(286, 181);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 22);
            this.txtPrecio.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(115, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 41);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(271, 292);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(101, 46);
            this.btn_Cerrar.TabIndex = 11;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // ptxFoto
            // 
            this.ptxFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptxFoto.Location = new System.Drawing.Point(454, 66);
            this.ptxFoto.Name = "ptxFoto";
            this.ptxFoto.Size = new System.Drawing.Size(276, 208);
            this.ptxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxFoto.TabIndex = 14;
            this.ptxFoto.TabStop = false;
            // 
            // cmbSupermercados
            // 
            this.cmbSupermercados.FormattingEnabled = true;
            this.cmbSupermercados.Location = new System.Drawing.Point(286, 95);
            this.cmbSupermercados.Name = "cmbSupermercados";
            this.cmbSupermercados.Size = new System.Drawing.Size(121, 24);
            this.cmbSupermercados.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(286, 223);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "CATEGORIA:";
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(655, 280);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(75, 23);
            this.btnImagen.TabIndex = 17;
            this.btnImagen.Text = "...";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // Form_AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 391);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.ptxFoto);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSupermercados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_AgregarProductos";
            this.Text = "AGREGAR PRODUCTOS";
            this.Load += new System.EventHandler(this.Form_AgregarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.PictureBox ptxFoto;
        private System.Windows.Forms.ComboBox cmbSupermercados;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}