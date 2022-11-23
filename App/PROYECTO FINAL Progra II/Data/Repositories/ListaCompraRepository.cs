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
    public class ListaCompraRepository:Repository
    {
        public int AddListaCompra(ListaCompra listaCompra)
        {
            var db = this.GetConnection();

            //Generamos la consulta con sus correspondientes parametros, agregamos
            //OUTPUT para que nos devuelva el id del registro insertado.
            string sql = @"insert into ListaCompra (FechaCompra, IdSupermercado)
                                OUTPUT INSERTED.Id
                               values( @FechaCompra, @IdSupermercado);";


            //Mapeamos los parametros y ejecutamos la consulta.
            var id = db.QuerySingle<int>(sql, new
            {
                FechaCompra = listaCompra.FechaCompra,
                idSupermercado = listaCompra.IdSupermercado,

            });

            //Devolvemos el id del registro insertado
            return id;
        }

        public int GetNewId()
        {
            var db = this.GetConnection();

            //Generamos la consulta con sus correspondientes parametros, agregamos
            //OUTPUT para que nos devuelva el id del registro insertado.
            string sql = @"SELECT MAX(Id) +1  Id FROM ListaCompra;";


            //Mapeamos los parametros y ejecutamos la consulta.
            var id = db.QuerySingle<int>(sql);

            //Devolvemos el id del registro insertado
            return id;
        }

        public List<ListaCompraHistoricoDto> GetCompraHistoricoDts()
        {
            //SQL que ejecutara Dapper, aquí puedes jugar con los orders que quieras.
            string sql = @"SELECT l.Id IdListaCompra, l.FechaCompra Fecha , s.Nombre Supermercado
                            FROM ListaCompra l
                            INNER JOIN Supermercado s on l.IdSupermercado = s.Id;";

            //Iniciar la conexión con la base de datos
            var db = this.GetConnection();

            //Ejecutar la consulta SQL y almacenar las líneas en nuestro modelo. 
            var listaCompra = db.Query<ListaCompraHistoricoDto>(sql);

            //Dapper devuelve un IEnumerable para trabajar más cómodos lo convertimos a listas. 
            return listaCompra.ToList();
        }
    }
}
