using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_FINAL_Progra_II.Data.Models;
using PROYECTO_FINAL_Progra_II.Data.Repositories;


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
 
           frmAgregarProductoLista frm = new frmAgregarProductoLista();
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }


        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_NuevaLista_Load(object sender, EventArgs e)
        {
            SupermercadoRepository supermercadoRepository = new SupermercadoRepository();
            var supermercados = supermercadoRepository.GetSupermercados();
            foreach (var supermercado in supermercados) 
            {
                cmbSupermercados.Items.Add(supermercado.Nombre);
            }
    
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void txt_Supermercado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
