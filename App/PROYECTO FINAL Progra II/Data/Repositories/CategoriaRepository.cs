using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_FINAL_Progra_II.Data.Models;
using Dapper;

namespace PROYECTO_FINAL_Progra_II.Data.Repositories
{
    public class CategoriaRepository:Repository
    {
        public int AddCategoria(Categoria categoria)
        {
            var db = this.GetConnection();

            //Generamos la consulta con sus correspondientes parametros, agregamos
            //OUTPUT para que nos devuelva el id del registro insertado.
            string sql = @"insert into Categoria ( Nombre)
                                OUTPUT INSERTED.Id
                               values( @Nombre);";


            //Mapeamos los parametros y ejecutamos la consulta.
            var id = db.QuerySingle<int>(sql, new
            {
                Nombre = categoria.Nombre,
            });

            //Devolvemos el id del registro insertado
            return id;

        }

        public List<Categoria> GetCategoria()
        {
            //SQL que ejecutara Dapper, aquí puedes jugar con los orders que quieras.
            string sql = @"select Id, Nombre from Categoria order by Nombre;";

            //Iniciar la conexión con la base de datos
            var db = this.GetConnection();

            //Ejecutar la consulta SQL y almacenar las líneas en nuestro modelo. 
            var categorias = db.Query<Categoria>(sql);

            //Dapper devuelve un IEnumerable para trabajar más cómodos lo convertimos a listas. 
            return categorias.ToList();
        }
    }
}
