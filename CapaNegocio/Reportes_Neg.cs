using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    public class Reportes_Neg
    {
        public static DataTable listarVentasXMozo()
        {
            return Reportes_db.listarVentasXMozo_db();
        }

        //public static DataTable listarVentasXMozo(string mozo)
        //{
        //    return Reportes_db.listarVentasXMozo_db(mozo);
        //}

        //public static DataTable listarVentasDiaria()
        //{
        //    return Reportes_db.listarVentasDiaria_db();
        //}

        public static DataTable listarVentasDiaria(string fecha)
        {
            return Reportes_db.listarVentasDiaria_db(fecha);
        }

        //public static DataTable listarPrecioCategoria()
        //{
        //    return Reportes_db.listarPrecioCategoria_db();
        //}

        public static DataTable listarPrecioCategoriaSimple()
        {
            return Reportes_db.listarPrecioCategoriaSimple_db();
        }

        public static DataTable listarPrecioCategoriaCompuesto()
        {
            return Reportes_db.listarPrecioCategoriaCompuesto_db();
        }

        //public static DataTable listarPrecioProductoCompuesto()
        //{
        //    return Reportes_db.listarPrecioProductoCompuesto_db();
        //}

        //public static DataTable listarPrecioProductoCompuesto(string categoria)
        //{
        //    return Reportes_db.listarPrecioProductoCompuesto_db(categoria);
        //}

        //public static DataTable listarPrecioMateriaPrima()
        //{
        //    return Reportes_db.listarPrecioMateriaPrima_db();
        //}

        //public static DataTable listarPrecioMateriaPrima(string categoria)
        //{
        //    return Reportes_db.listarPrecioMateriaPrima_db(categoria);
        //}

    }
}
