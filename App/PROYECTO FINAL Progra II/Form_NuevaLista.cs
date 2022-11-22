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
using PROYECTO_FINAL_Progra_II.Dto;

namespace PROYECTO_FINAL_Progra_II
{
    public partial class Form_NuevaLista : Form
    {
        double total;
        List<Categoria> categorias;
        List<DetalleListaDto> detalleListas = new List<DetalleListaDto>();
        public Form_NuevaLista()
        {
            InitializeComponent();
        }

        private void txt_CodigoLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AgregarProductos_Click(object sender, EventArgs e)
        {

            if (ndCantidad.Value == 0) 
            {
                MessageBox.Show("Tienes que seleccionar una cantidad");
                return;
            }

            if (dtgProductos.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Tienes que seleccionar un producto");
                return;
            }


            var Dt = new DetalleListaDto();
            Dt.IdProducto = 8;
            Dt.Cantidad = 17;
            Dt.Nombre = "Lechuga";
            Dt.Precio = 10.50;

            total += Dt.SubTotal;
            lbTotal.Text = total.ToString();
            detalleListas.Add(Dt);

            dtgDetalleLista.DataSource = null;
            dtgDetalleLista.Refresh();

            dtgDetalleLista.DataSource = detalleListas;
            dtgDetalleLista.Refresh();

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

            if ( cmbCategoria.SelectedIndex != -1 )
            {
                var pr = productoRepository.GetProducto(categorias[cmbCategoria.SelectedIndex].Id);
                dtgProductos.DataSource = pr;
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarProductoLista_Load(object sender, EventArgs e)
        {

    
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargarProductos();

        }
    }
}
