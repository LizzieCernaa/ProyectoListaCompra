using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_FINAL_Progra_II.Data.Models;
using Dapper;

namespace PROYECTO_FINAL_Progra_II.Data.Repositories
{
    public class SupermercadoRepository : Repository
    {
        public int AddSupermercado(Supermercado supermercado)
        {
            var db = this.GetConnection();

            //Generamos la consulta con sus correspondientes parametros, agregamos
            //OUTPUT para que nos devuelva el id del registro insertado.
            string sql = @"insert into Supermercado (Nombre)
                                OUTPUT INSERTED.Id
                               values( @Nombre);";


            //Mapeamos los parametros y ejecutamos la consulta.
            var id = db.QuerySingle<int>(sql, new
            {
                Nombre = supermercado.Nombre,
            });

            //Devolvemos el id del registro insertado
            return id;
        }

        public List<Supermercado> GetSupermercados() 
        {
            //SQL que ejecutara Dapper, aquí puedes jugar con los orders que quieras.
            string sql = @"select Id, Nombre from Supermercado";

            //Iniciar la conexión con la base de datos
            var db = this.GetConnection();

            //Ejecutar la consulta SQL y almacenar las líneas en nuestro modelo. 
            var supermercados = db.Query<Supermercado>(sql);

            //Dapper devuelve un IEnumerable para trabajar más cómodos lo convertimos a listas. 
            return supermercados.ToList();
        }
    }
}
