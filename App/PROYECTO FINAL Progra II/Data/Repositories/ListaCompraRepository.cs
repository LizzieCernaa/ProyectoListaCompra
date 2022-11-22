using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_FINAL_Progra_II.Data.Models;
using Dapper;

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
    }
}
