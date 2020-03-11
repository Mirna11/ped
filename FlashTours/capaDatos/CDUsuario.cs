using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CDUsuario
    {

        private CDConexion conexion = new CDConexion();
        private SqlDataReader leer;

        public SqlDataReader logearse(string email, string pass)
        {
            SqlCommand comando = new SqlCommand("logearse", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@pass", pass);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            return leer;
        }
    }
}
