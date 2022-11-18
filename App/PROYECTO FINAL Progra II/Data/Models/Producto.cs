using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_Progra_II.Data.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int IdCategoria { get; set; }
        public int IdSupermercado { get; set; }
        public byte[] Foto { get; set; } 
    }
}
