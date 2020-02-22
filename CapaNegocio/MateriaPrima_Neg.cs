using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    public class MateriaPrima_Neg
    {
        private string marca { get => marca; set => marca = value; }
        private string categoria { get => categoria; set => categoria = value; }
        private string descripcion { get => descripcion; set => descripcion = value; }
        private int costo { get => costo; set => costo = value; }
        private int cantidad { get => cantidad; set => cantidad = value; }

        public MateriaPrima_Neg() { }

        public MateriaPrima_Neg(string marca, string categoria, string descripcion, int costo, int cantidad)
        {
            this.marca = marca;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.costo = costo;
            this.cantidad = cantidad;
        }

        public static bool guardarMateriaPrima(/*string marca,*/ string nombre, string descripcion, int costo, int cantidad, int baja)
        {
            return MateriaPrima_db.guardarMateriaPrima_db(/*marca,*/ nombre, descripcion, costo, cantidad, baja);
        }

        public static DataTable listarMateriasPrimas()
        {
            return MateriaPrima_db.tablaMateriaPrima_db();
        }

        public static DataTable listarMateriasPrimas(string nombre)
        {
            return MateriaPrima_db.tablaMateriaPrima_db(nombre);
        }

        public static bool guardarModificadoMateriaPrima(int indice, /*string marca,*/ string nombre, string descripcion, int costo, int cantidad)
        {
            return MateriaPrima_db.guardarModificadoMateriaPrima_db(indice, /*marca,*/ nombre, descripcion, costo, cantidad);
        }

        public static bool eliminarMateriaPrima(int indice)
        {
            return MateriaPrima_db.eliminarMateriaPrima_db(indice);
        }

        public static DataTable listarIngredientes()
        {
            return MateriaPrima_db.Listar_Ingredientes_db();
        }

        public static bool descontarCantidad(int id, int cantidad)
        {
            return MateriaPrima_db.descontarCantidad_db(id, cantidad);
        }
    }
}
