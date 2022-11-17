using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_Progra_II.Data.Models
{
    public class DetalleLista
    {
        public int Id { get; set; }
        public int IdListaCompra { get; set; }
        public int IdProducto { get; set; }
        public double Precio { get; set; }
        public double Cantidad { get; set; }

    }
}
