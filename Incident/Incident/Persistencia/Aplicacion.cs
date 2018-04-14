using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace Incident.Persistencia
{
    class Aplicacion
    {

        public static bool Insertar(string aplicacion)
        {
            string query = string.Empty;
            bool respuesta = false;

            query = string.Format("insert into aplicacion (aplicacion) values ({0})",aplicacion);

            MySqlConnection conecion = new MySqlConnection(Conexion.Conec());
            MySqlCommand comando = new MySqlCommand(query,conecion);
            conecion.Open();

            var filasAfectadas = comando.ExecuteNonQuery();
            
            if (filasAfectadas > 0)
                respuesta = true;

            return respuesta;
        }

        public static bool Actualizar(string aplicacion)
        {
            string query = string.Empty;
            bool respuesta = false;

            query = string.Format("update aplicacion set aplicacion = '{0}' ", aplicacion);

            MySqlConnection conecion = new MySqlConnection(Conexion.Conec());
            MySqlCommand comando = new MySqlCommand(query, conecion);
            conecion.Open();

            var filasAfectadas = comando.ExecuteNonQuery();

            if (filasAfectadas > 0)
                respuesta = true;

            return respuesta;
        }

        public static DataTable Aplicaciones()
        {
            string query = string.Empty;
            DataTable tbl = new DataTable();

            query = string.Format("select * from aplicacion where estado = true order by aplicacion_id");
            MySqlConnection conecion = new MySqlConnection(Conexion.Conec());
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conecion);

            adapter.Fill(tbl);

            return tbl;
        }

    }
}
