using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_Progra_II.Dto
{
    public class DetalleCompraHistoricoDto
    {
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public double Precio { get; set; }
        public double Cantidad { get; set; }
        public byte[] Foto { get; set; }
        public double SubTotal { get { return Precio * Cantidad; } }
    }
}
