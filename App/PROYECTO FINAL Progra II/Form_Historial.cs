using PROYECTO_FINAL_Progra_II.Data.Repositories;
using PROYECTO_FINAL_Progra_II.Dto;
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
    public partial class Form_Historial : Form
    {
        double total;
        public Form_Historial()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Historial_Load(object sender, EventArgs e)
        {

            ListaCompraRepository listaCompra = new ListaCompraRepository();

           var lista =  listaCompra.GetCompraHistoricoDts();


            dtgHistorico.DataSource = lista;
        }

        private void dtgHistorico_SelectionChanged(object sender, EventArgs e)
        {

            DetalleListaRepository detalleLista = new DetalleListaRepository();

            var lista = detalleLista.GetDetalleHistoricoDtos();

            dtgDetalle.DataSource = lista;
            foreach (DataGridViewRow row in dtgDetalle.Rows)
            {
                row.Height = 75;
            }
            total = 0;
            foreach (var nombre in lista) 
            {
                total += nombre.SubTotal;
            }

            lbTotal.Text = total.ToString();
        }
    }
}
