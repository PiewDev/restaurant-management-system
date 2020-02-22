using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    public class ProductoSimple_Neg
    {
        private string marca { get => marca; set => marca = value; }
        private string categoria { get => categoria; set => categoria = value; }
        private string descripcion { get => descripcion; set => descripcion = value; }
        private int costo { get => costo; set => costo = value; }
        private int precio_venta { get => precio_venta; set => precio_venta = value; }
        private int cantidad { get => cantidad; set => cantidad = value; }

        public ProductoSimple_Neg() { }

        public ProductoSimple_Neg(string marca, string categoria, string descripcion, int costo, int precio_venta, int cantidad)
        {
            this.marca = marca;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precio_venta = precio_venta;
            this.cantidad = cantidad;
        }

        public static bool guardarProductoSimple(string marca, int categoria, string descripcion, int costo, int precio_venta, int cantidad, int baja)
        {
            return ProductoSimple_db.guardarProductoSimple_db(marca, categoria, descripcion, costo, precio_venta, cantidad, baja);
        }

        public static DataTable listarProductosSimples()
        {
            return ProductoSimple_db.tablaProductoSimple_db();
        }

        public static DataTable listarProductosSimplesPedido()
        {
            return ProductoSimple_db.tablaProductoSimplePedido_db();
        }

        public static DataTable listarProductosSimples(string categoria)
        {
            return ProductoSimple_db.tablaProductoSimple_db(categoria);
        }

        public static bool guardarModificadoProductoSimple(int indice, string marca, string descripcion, int costo, int precio_venta, int cantidad, int categoria)
        {
            return ProductoSimple_db.guardarModificadoProductoSimple_db(indice, marca, descripcion, costo, precio_venta, cantidad, categoria);
        }

        public static bool eliminarProductoSimple(int indice)
        {
            return ProductoSimple_db.eliminarProductoSimple_db(indice);
        }

        public static DataTable listarCategoria()
        {
            return ProductoSimple_db.Listar_Categoria_db();
        }
    }
}
