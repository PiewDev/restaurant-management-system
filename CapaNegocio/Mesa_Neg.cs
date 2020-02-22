using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    public class Mesa_Neg
    {
        private int numero { get => numero; set => numero = value; }
        private string estado { get => estado; set => estado = value; }

        public Mesa_Neg() { }

        public Mesa_Neg(int numero, string estado)
        {
            this.numero = numero;
            this.estado = estado;
        }

        public static bool guardarMesa(int numero, int baja)
        {
            return Mesa_db.guardarMesa_db(numero, baja);
        }

        public static DataTable listarMesas()
        {
            return Mesa_db.tablaMesas_db();
        }

        public static DataTable listarMesas(int numero)
        {
            return Mesa_db.tablaMesas_db(numero);
        }

        public static bool guardarModificadoMesa(int indice, int numero)
        {
            return Mesa_db.guardarModificadoMesa_db(indice, numero);
        }

        public static bool eliminarMesa(int indice)
        {
            return Mesa_db.eliminarMesa_db(indice);
        }

        //public static DataTable Combo_box_Mesa_Estado()
        //{
        //    return Mesa_db.Combo_box_Mesa_Estado_db();
        //}
    }
}
