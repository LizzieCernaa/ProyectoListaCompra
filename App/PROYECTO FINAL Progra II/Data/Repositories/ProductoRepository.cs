using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_FINAL_Progra_II.Data.Models;
using Dapper;

namespace PROYECTO_FINAL_Progra_II.Data.Repositories
{
    public class ProductoRepository:Repository
    {
        public int AddProducto(Producto producto) 
        {
            var db = this.GetConnection();

            //Generamos la consulta con sus correspondientes parametros, agregamos
            //OUTPUT para que nos devuelva el id del registro insertado.
            string sql = @"insert into Producto ( Nombre, Precio, Foto, IdCategoria, IdSupermercado)
                                OUTPUT INSERTED.Id
                               values( @Nombre, @Precio, @Foto, @IdCategoria, @IdSupermercado);"; 


                //Mapeamos los parametros y ejecutamos la consulta.
                var id = db.QuerySingle<int>(sql, new
                {
                    Nombre = producto.Nombre,
                    Precio = producto.Precio,
                    Foto = producto.Foto,
                    IdCategoria = producto.IdCategoria,
                    idSupermercado = producto.IdSupermercado,
                });

                //Devolvemos el id del registro insertado
                return id ;

        }

        public List<Producto> GetProducto( int IdCategoria)
        {

            var parameters = new { IdCategoria = IdCategoria };
            //SQL que ejecutara Dapper, aquí puedes jugar con los orders que quieras.
            string sql = @"select Id, Nombre, Precio, Foto, IdCategoria, IdSupermercado from Producto where IdCategoria = @IdCategoria order by Nombre;";

            //Iniciar la conexión con la base de datos
            var db = this.GetConnection();

            //Ejecutar la consulta SQL y almacenar las líneas en nuestro modelo. 
            var productos = db.Query<Producto>(sql, parameters);

            //Dapper devuelve un IEnumerable para trabajar más cómodos lo convertimos a listas. 
            return productos.ToList();

        }
    }
}
