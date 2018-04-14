using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incident.Persistencia
{
    class Conexion
    {
        static string strCon = string.Empty;

        public static string Conec()
        {
            strCon = "server=localhost;user id=root;database=incidencias";

            return strCon;
        }
    }
}
