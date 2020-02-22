using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    public class Comanda
    {
        public static bool guardarComanda(int id_mozo, int total, string fecha, string hora, int id_mesa)
        {
            return Comanda_db.guardarComanda_db(id_mozo, total, fecha, hora, id_mesa);
        }

        public static DataTable listarComanda()
        {
            return Comanda_db.tablaComanda_db();
        }
    }
}
