using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Categoria_db
    {
        public static bool guardarCategoria_db(string nombre, string tipo, int baja)
        {
            string sql = "INSERT INTO Categoria2(nombre, tipo, baja) VALUES (@nombre, @tipo, @baja)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[0].Value = nombre;

                Cx.SqlCmd.Parameters.Add("@tipo", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = tipo;

                Cx.SqlCmd.Parameters.Add("@baja", SqlDbType.Int);
                Cx.SqlCmd.Parameters[2].Value = baja;

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

        public static DataTable tablaCategorias_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Categoria2 WHERE baja = 0";
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

        public static DataTable tablaCategorias_db(string nombre)
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Categoria2 WHERE nombre LIKE @nombre AND baja = 0";
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

        public static DataTable tablaCategoriaCombo_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT id_categoria FROM Categoria2 WHERE baja = 0";
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

        public static bool guardarModificadoCategoria_db(int id_categoria, string nombre, string tipo)
        {
            string sql = "UPDATE Categoria2 SET nombre = @nombre, tipo = @tipo WHERE baja = 0 AND id_categoria = @id_categoria";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@id_categoria", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = id_categoria;

                Cx.SqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = nombre;

                Cx.SqlCmd.Parameters.Add("@tipo", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[2].Value = tipo;

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

        public static bool eliminarCategoria_db(int ID)
        {
            string sql = "UPDATE Categoria2 SET baja = 1 WHERE id_categoria = @ID";

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
