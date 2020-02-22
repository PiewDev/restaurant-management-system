using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace CapaNegocio
{
    public class Mozo_Neg
    {
        private string nombre { get => nombre; set => nombre = value; }
        private string apellido { get => apellido; set => apellido = value; }
        private string dni { get => dni; set => dni = value; }
        private string fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }

        public Mozo_Neg() { }

        public Mozo_Neg(string nombre, string apellido, string dni, string fecha_nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fecha_nacimiento = fecha_nacimiento;
        }
        
        public static bool guardarMozo(string nombre, string apellido, string dni, string fecha_nacimiento, int baja)
        {
            return Mozo_db.guardarMozo_db(nombre, apellido, dni, fecha_nacimiento, baja);
        }

        public static DataTable listarMozos()
        {
            return Mozo_db.tablaMozos_db();
        }

        public static DataTable listarMozoCombo()
        {
            return Mozo_db.tablaMozosCombo_db();
        }

        public static DataTable listarMozos(string nombre)
        {
            return Mozo_db.tablaMozos_db(nombre);
        }

        public static DataTable buscarMozos(string nombre)
        {
            return Mozo_db.buscarMozos_db(nombre);
        }

        public static bool guardarModificadoMozo(int indice,string nombre, string apellido, string dni, string fecha_nacimiento)
        {
            return Mozo_db.guardarModificadoMozo_db(indice,nombre, apellido, dni, fecha_nacimiento);
        }

        public bool eliminarMozo(int indice)
        {
            return Mozo_db.eliminarMozo_db(indice);
        }

    }
}
