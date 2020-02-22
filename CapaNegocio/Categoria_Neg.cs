using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    public class Categoria_Neg
    {
        private string nombre { get => nombre; set => nombre = value; }

        public Categoria_Neg() { }

        public Categoria_Neg(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool guardarCategoria(string nombre, string tipo, int baja)
        {
            return Categoria_db.guardarCategoria_db(nombre, tipo, baja);
        }

        public static DataTable listarCategorias()
        {
            return Categoria_db.tablaCategorias_db();
        }

        public static DataTable listarCategorias(string nombre)
        {
            return Categoria_db.tablaCategorias_db(nombre);
        }

        public static DataTable listarCategoriasCombo()
        {
            return Categoria_db.tablaCategoriaCombo_db();
        }

        public static bool guardarModificadoCategoria(int indice, string nombre, string tipo)
        {
            return Categoria_db.guardarModificadoCategoria_db(indice, nombre, tipo);
        }

        public static bool eliminarCategoria(int indice)
        {
            return Categoria_db.eliminarCategoria_db(indice);
        }
    }
}
