using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_FINAL_Progra_II.Data.Models;
using Dapper;
using PROYECTO_FINAL_Progra_II.Dto;

namespace PROYECTO_FINAL_Progra_II.Data.Repositories
{
    public class DetalleListaRepository : Repository
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

        public List<DetalleCompraHistoricoDto> GetDetalleHistoricoDtos( int idListaCompra)
        {
            var parameters = new { idListaCompra = idListaCompra };
            //SQL que ejecutara Dapper, aquí puedes jugar con los orders que quieras.
            string sql = @"SELECT d.IdProducto, d.Precio, d.Cantidad, p.Nombre Producto,p.Foto
                            FROM DetalleLista d
                            INNER JOIN Producto p on d.IdProducto = p.Id
                            WHERE d.IdListaCompra = @idListaCompra";

            //Iniciar la conexión con la base de datos
            var db = this.GetConnection();

            //Ejecutar la consulta SQL y almacenar las líneas en nuestro modelo. 
            var detalleCompra = db.Query<DetalleCompraHistoricoDto>(sql, parameters);

            //Dapper devuelve un IEnumerable para trabajar más cómodos lo convertimos a listas. 
            return detalleCompra.ToList();

        }
    }

}
