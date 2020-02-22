using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    public class Pedido_Neg
    {
        public static bool guardarTemporal(int id, int mesa, int id_mozo, int id_productosimple, int baja)
        {
            return Pedido_db.guardarTemporal_db(id, mesa, id_mozo, id_productosimple, baja);
        }

        public static bool guardarTemporal2(int id, int mesa, int id_mozo, int id_productocompuesto, int baja)
        {
            return Pedido_db.guardarTemporal_db(id, mesa, id_mozo, id_productocompuesto, baja);
        }

        public static bool guardarVenta(int comanda, string mozo, int mesa, string fecha, string hora, int total, int baja)
        {
            return Pedido_db.guardarVenta_db(comanda, mozo, mesa, fecha, hora, total, baja);
        }

        public static DataTable listarVenta()
        {
            return Pedido_db.listarVenta_db();
        }
    }
}