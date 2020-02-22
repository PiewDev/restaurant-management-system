using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;

namespace CapaNegocio
{
    public class ProductoCompuesto_Neg
    {
        //private string categoria { get => categoria; set => categoria = value; }
        private string nombre { get => nombre; set => nombre = value; }
        private string descripcion { get => descripcion; set => descripcion = value; }
        private int costo { get => costo; set => costo = value; }
        private int precio_venta { get => precio_venta; set => precio_venta = value; }

        public ProductoCompuesto_Neg() { }

        public ProductoCompuesto_Neg(/*string categoria, */string nombre, string descripcion, int costo, int precio_venta)
        {
            //this.categoria = categoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precio_venta = precio_venta;
        }

        public static bool guardarProductoCompuesto(string nombre, int categoria, int costo, int precio_venta, int baja)
        {
            return ProductoCompuesto_db.guardarProductoCompuesto_db(nombre, categoria, costo, precio_venta, baja);
        }

        public static DataTable listarProductosCompuestos()
        {
            return ProductoCompuesto_db.tablaProductoCompuesto_db();
        }

        public static DataTable listarProductosCompuestosPedido()
        {
            return ProductoCompuesto_db.tablaProductoCompuestoPedido_db();
        }

        public static DataTable listarProductosCompuestos(string categoria)
        {
            return ProductoCompuesto_db.tablaProductoCompuesto_db(categoria);
        }

        public static DataTable listarProductosCompuestos(string categoria, string nombre)
        {
            return ProductoCompuesto_db.tablaProductoCompuesto_db(categoria, nombre);
        }

        public static bool guardarModificadoProductoCompuesto(int indice, string categoria, string nombre, string descripcion, int costo, int precio_venta)
        {
            return ProductoCompuesto_db.guardarModificadoProductoCompuesto_db(indice, categoria, nombre, descripcion, costo, precio_venta);
        }

        public static bool eliminarProductoCompuesto(int indice)
        {
            return ProductoCompuesto_db.eliminarProductoCompuesto_db(indice);
        }

        public static DataTable comboBox_Categoria()
        {
            return ProductoCompuesto_db.comboBoxCategoria_db();
        }
    }
}
