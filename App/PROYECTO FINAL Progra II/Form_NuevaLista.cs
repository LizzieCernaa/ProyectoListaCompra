using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_Progra_II
{
    public partial class Form_NuevaLista : Form
    {
        public Form_NuevaLista()
        {
            InitializeComponent();
        }

        private void txt_CodigoLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AgregarProductos_Click(object sender, EventArgs e)
        {
 
           Form_AgregarProductos frm = new Form_AgregarProductos();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_NuevaLista_Load(object sender, EventArgs e)
        {

    
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
