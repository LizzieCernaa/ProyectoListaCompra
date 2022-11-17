using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROYECTO_FINAL_Progra_II.Data.Repositories
{
    public class Repository
    {
        public SqlConnection GetConnection() 
        {
            string connectionString = "Server=127.0.0.1;Database=ListaCompra;User Id=sa;Password=yourStrong(!)Password";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
