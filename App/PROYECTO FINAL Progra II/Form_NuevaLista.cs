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
        List<Supermercado> supermercados = new List<Supermercado>();
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

            var row = dtgProductos.SelectedRows[0];

            var Dt = new DetalleListaDto();
            Dt.IdProducto = int.Parse(row.Cells[0].Value.ToString());
            Dt.Cantidad = double.Parse(ndCantidad.Value.ToString());
            Dt.Nombre = row.Cells[1].Value.ToString();
            Dt.Precio = double.Parse(row.Cells[2].Value.ToString());
            total += Dt.SubTotal;
            lbTotal.Text = total.ToString();
            detalleListas.Add(Dt);

            dtgDetalleLista.DataSource = null;
            dtgDetalleLista.Refresh();

            dtgDetalleLista.DataSource = detalleListas;
            dtgDetalleLista.Refresh();

            ndCantidad.Value = 1;

        }


        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_NuevaLista_Load(object sender, EventArgs e)
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

            CargarProductos();
            ListaCompraRepository repository = new ListaCompraRepository();
            var newId = repository.GetNewId();
            lbIdLista.Text = newId.ToString();

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

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dtgDetalleLista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el producto que desea eliminar");
                return;
            }
            else{
                int seleccionado = dtgDetalleLista.SelectedRows[0].Index;
                dtgDetalleLista.DataSource = null;
                detalleListas.RemoveAt(seleccionado);
                dtgDetalleLista.DataSource = detalleListas;
            }
        }

        private void bton_Guardar_Click(object sender, EventArgs e)
        {
            if (cmbSupermercados.SelectedIndex != -1 && dtgDetalleLista.Rows.Count > 0) { 
            ListaCompra ls = new ListaCompra();
            ls.FechaCompra = DateTime.Now;
            ls.IdSupermercado = supermercados[cmbSupermercados.SelectedIndex].Id;
            ListaCompraRepository repository = new ListaCompraRepository();
            ls.Id = repository.AddListaCompra(ls);


                foreach (DetalleListaDto d in detalleListas)
                {
                    DetalleLista dl = new DetalleLista();
                    dl.IdListaCompra = ls.Id;
                    dl.IdProducto = d.IdProducto;
                    dl.Cantidad = d.Cantidad;
                    dl.Precio = d.Precio;

                    DetalleListaRepository repositoryDetalle = new DetalleListaRepository();
                    repositoryDetalle.AddDetalleLista(dl);

                }

                MessageBox.Show("Lista de compra guardada correctamente");
                dtgDetalleLista.DataSource = null;
                detalleListas = new List<DetalleListaDto>();
                dtgDetalleLista.DataSource = detalleListas;
                var newId = repository.GetNewId();
                lbIdLista.Text = newId.ToString();
            }

        }
    }
}
