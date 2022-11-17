using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_FINAL_Progra_II.Data.Models;
using Dapper;

namespace PROYECTO_FINAL_Progra_II.Data.Repositories
{
    public class DetalleListaRepository:Repository
    {
        public int AddDetalleLista(DetalleLista detalleLista)
        {
            var db = this.GetConnection();

            //Generamos la consulta con sus correspondientes parametros, agregamos
            //OUTPUT para que nos devuelva el id del registro insertado.
            string sql = @"insert into DetalleLista (IdListaCompra, IdProducto, Precio, Cantidad)
                                OUTPUT INSERTED.Id
                               values( @IdListaCompra, @IdProducto, @Precio, @Cantidad);";


            //Mapeamos los parametros y ejecutamos la consulta.
            var id = db.QuerySingle<int>(sql, new
            {
                IdListaCompra = detalleLista.IdListaCompra,
                IdProducto = detalleLista.IdProducto,
                Precio = detalleLista.Precio,
                Cantidad = detalleLista.Cantidad,

            });

            //Devolvemos el id del registro insertado
            return id;
        }
    }
}
