using PROYECTO_FINAL_Progra_II.Data.Models;
using PROYECTO_FINAL_Progra_II.Data.Repositories;
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
    public partial class frmAgregarProductoLista : Form
    {
        List<Categoria> categorias;
        public frmAgregarProductoLista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarProductoLista_Load(object sender, EventArgs e)
        {

            CategoriaRepository categoriaRepository = new CategoriaRepository();
            categorias = categoriaRepository.GetCategoria();
            foreach (var categoria in categorias)
            {
                cmbCategoria.Items.Add(categoria.Nombre);
            }

            CargarProductos();
        }

        private void CargarProductos() 
        {
            ProductoRepository productoRepository = new ProductoRepository();
            var pr = productoRepository.GetProducto();
            dtgProductos.DataSource = pr;
        }
    }
}
