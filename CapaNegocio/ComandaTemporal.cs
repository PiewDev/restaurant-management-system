using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    public class ComandaTemporal
    {
        public static DataTable listarComandaTemporal()
        {
            return Temporal_db.tablaTemporal_db();
        }
    }
}
