using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class MateriaPrima_db
    {
        public static bool guardarMateriaPrima_db(string nombre, string descripcion, int costo, int cantidad, int baja)
        {
            string sql = "INSERT INTO MateriaPrima2(nombre, descripcion, costo, cantidad, baja) VALUES (@nombre, @descripcion, @costo, @cantidad, @baja)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[0].Value = nombre;

                Cx.SqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = descripcion;

                Cx.SqlCmd.Parameters.Add("@costo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[2].Value = costo;

                Cx.SqlCmd.Parameters.Add("@cantidad", SqlDbType.Int);
                Cx.SqlCmd.Parameters[3].Value = cantidad;

                Cx.SqlCmd.Parameters.Add("@baja", SqlDbType.Int);
                Cx.SqlCmd.Parameters[4].Value = baja;

                Cx.Abrir();
                Object nro = Cx.SqlCmd.ExecuteNonQuery();
                Cx.Cerrar();

                if (Convert.ToInt32(nro) > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable tablaMateriaPrima_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM MateriaPrima2 WHERE baja = 0";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(medios); //Llenamos el DataTable

            }
            catch (Exception)
            {
                medios = null;
            }
            return medios;
        }

        public static DataTable tablaMateriaPrima_db(string nombre)
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM MateriaPrima2 WHERE nombre LIKE @nombre AND baja = 0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[0].Value = nombre;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(medios); //Llenamos el DataTable

            }
            catch (Exception)
            {
                medios = null;
            }
            return medios;
        }

        public static bool guardarModificadoMateriaPrima_db(int id_productosimple, string nombre, string descripcion, int costo, int cantidad)
        {
            string sql = "UPDATE MateriaPrima2 SET nombre = @nombre, descripcion = @descripcion, costo = @costo, cantidad = @cantidad WHERE baja = 0 AND id_materiaprima = @id_materiaprima";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@id_materiaprima", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = id_productosimple;

                Cx.SqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = nombre;

                Cx.SqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[2].Value = descripcion;

                Cx.SqlCmd.Parameters.Add("@costo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[3].Value = costo;

                Cx.SqlCmd.Parameters.Add("@cantidad", SqlDbType.Int);
                Cx.SqlCmd.Parameters[4].Value = cantidad;

                Cx.Abrir();
                Object nro = Cx.SqlCmd.ExecuteNonQuery();
                Cx.Cerrar();

                if (Convert.ToInt32(nro) > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool eliminarMateriaPrima_db(int ID)
        {
            string sql = "UPDATE MateriaPrima2 SET baja = 1 WHERE id_materiaprima = @ID";

            bool ex;

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@ID", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = ID;

                Cx.Abrir();
                Object nro = Cx.SqlCmd.ExecuteScalar();
                Cx.Cerrar();

                if (Convert.ToInt32(nro) > 0)
                    ex = false;
                else
                    ex = true;
            }
            catch (Exception)
            {
                ex = true;
            }

            return ex;
        }

        public static DataTable Listar_Ingredientes_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT id_materiaprima, categoria FROM MateriaPrima";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(medios); //Llenamos el DataTable

            }
            catch (Exception)
            {
                medios = null;
            }
            return medios;
        }

        public static bool descontarCantidad_db(int indice, int cantidad)
        {
            string sql = "SELECT (cantidad-@cantidad) AS RESTA FROM MateriaPrima WHERE id_materiaprima = @indice";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@indice", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = indice;

                Cx.SqlCmd.Parameters.Add("@cantidad", SqlDbType.Int);
                Cx.SqlCmd.Parameters[1].Value = cantidad;

                Cx.Abrir();
                Object nro = Cx.SqlCmd.ExecuteNonQuery();
                Cx.Cerrar();

                if (Convert.ToInt32(nro) > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
