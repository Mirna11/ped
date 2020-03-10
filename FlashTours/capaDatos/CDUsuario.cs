using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    class CDUsuario
    {

        private CDConexion conexion = new CDConexion();
        private SqlDataReader leer;

        public SqlDataReader logearse(string user, string pass)
        {


            SqlCommand comando = new SqlCommand("logearse", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", user);
            comando.Parameters.AddWithValue("@pass", pass);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            return leer;
        }
    }
}
