using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Mozo_db
    {
        public static bool guardarMozo_db(string nombre, string apellido, string dni, string nacimiento, int baja)
        {
            string sql = "INSERT INTO Mozo2(nombre, apellido, dni, fecha_nacimiento, baja) VALUES (@nombre, @apellido, @dni, @fecha_nacimiento, @baja)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[0].Value = nombre;

                Cx.SqlCmd.Parameters.Add("@apellido", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = apellido;

                Cx.SqlCmd.Parameters.Add("@dni", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[2].Value = dni;

                Cx.SqlCmd.Parameters.Add("@fecha_nacimiento", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[3].Value = nacimiento;

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

        public static DataTable tablaMozos_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Mozo2 WHERE baja = 0";
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

        public static DataTable tablaMozos_db(string nombre)
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Mozo2 WHERE nombre LIKE @nombre AND baja = 0";
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

        public static DataTable tablaMozosCombo_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT id_mozo, nombre FROM Mozo2 WHERE baja = 0";
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

        public static DataTable buscarMozos_db(string nombre)
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Mozo2 WHERE nombre = @nombre AND baja = 0";
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

        public static bool guardarModificadoMozo_db(int id_mozo, string nombre, string apellido, string dni, string fecha_nacimiento)
        {
            string sql = "UPDATE Mozo2 SET nombre = @nombre, apellido = @apellido, dni = @dni, fecha_nacimiento = @fecha_nacimiento WHERE baja = 0 AND id_mozo = @id_mozo";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@id_mozo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = id_mozo;

                Cx.SqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = nombre;

                Cx.SqlCmd.Parameters.Add("@apellido", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[2].Value = apellido;

                Cx.SqlCmd.Parameters.Add("@dni", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[3].Value = dni;

                Cx.SqlCmd.Parameters.Add("@fecha_nacimiento", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[4].Value = fecha_nacimiento;


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

        public static bool eliminarMozo_db(int ID)
        {
            string sql = "UPDATE Mozo2 SET baja = 1 WHERE id_mozo = @ID";

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
    }
}
