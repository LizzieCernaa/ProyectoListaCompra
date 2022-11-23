using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_FINAL_Progra_II.Data.Repositories;
using PROYECTO_FINAL_Progra_II.Data.Models;


namespace PROYECTO_FINAL_Progra_II
{
    public partial class MenúPrincipal : Form
    {
        public MenúPrincipal()
        {
            InitializeComponent();
        }

        private void nuevaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

           //Supermercado s = new Supermercado();
           // s.Nombre = "Despensa de Don Juan";

           // SupermercadoRepository r = new SupermercadoRepository();
           //var resuldato = r.AddSupermercado(s);
           // MessageBox.Show(resuldato.ToString());

            //ProductoRepository productoRepository = new ProductoRepository();
            //var pr = productoRepository.GetProducto();
            //MessageBox.Show(pr.ToString());

        }

        

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Actualizar Actualizar = new Form_Actualizar();
            Actualizar.MdiParent = this;
            Actualizar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Eliminar Eliminar = new Form_Eliminar();
            Eliminar.MdiParent = this;
            Eliminar.Show();
        }

        private void tablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Mostrar Mostrar = new Form_Mostrar();
            Mostrar.MdiParent = this;
            Mostrar.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void historialDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Historial Historial = new Form_Historial();
            Historial.MdiParent = this;
            Historial.Show();
        }

        private void listasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tablaListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void tablaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void pruebaDeConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void crearListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NuevaLista Nuevalista = new Form_NuevaLista();
            Nuevalista.MdiParent = this;
            Nuevalista.Show();
        }

        public void añadirProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AgregarProductos agregarProductos = new Form_AgregarProductos();
            agregarProductos.MdiParent = this;
            agregarProductos.Show();
        }

        private void comprasPorListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AgregarProductos agregarProductos = new Form_AgregarProductos();
            agregarProductos.MdiParent = this;
            agregarProductos.Show();

        }

        private void historicoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Historial Historial = new Form_Historial();
            Historial.MdiParent = this;
            Historial.Show();
        }
    }
}
