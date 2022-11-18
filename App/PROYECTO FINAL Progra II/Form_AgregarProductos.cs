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
    public partial class Form_AgregarProductos : Form
    {
        List<Supermercado> supermercados;
        List<Categoria> categorias;
        public Form_AgregarProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = txtNombre.Text;
            producto.Precio =double.Parse(txtPrecio.Text);
            producto.IdCategoria = categorias[cmbCategoria.SelectedIndex].Id;
            producto.IdSupermercado = supermercados[cmbSupermercados.SelectedIndex].Id;
            producto.Foto = ptxFoto.Image;

            var repository = new ProductoRepository();
            var resul = repository.AddProducto(producto);

            MessageBox.Show("PRODUCTO GUARDADO SATISFATORIAMENTE");

        }

        private void Form_AgregarProductos_Load(object sender, EventArgs e)
        {
            SupermercadoRepository supermercadoRepository = new SupermercadoRepository();
            supermercados = supermercadoRepository.GetSupermercados();
            foreach (var supermercado in supermercados)
            {
                cmbSupermercados.Items.Add(supermercado.Nombre);
            }

            CategoriaRepository categoriaRepository = new CategoriaRepository();
            categorias = categoriaRepository.GetCategoria();
            foreach (var categoria in categorias)
            {
                cmbCategoria.Items.Add(categoria.Nombre);
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;

            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                fileName = dlgAbrir.FileName;
                ptxFoto.ImageLocation = fileName;
            }

           
        }
    }
}
