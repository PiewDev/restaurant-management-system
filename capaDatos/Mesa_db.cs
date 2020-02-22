using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Mesa_db
    {
        public static bool guardarMesa_db(int numero, int baja)
        {
            string sql = "INSERT INTO Mesa4(numero, baja) VALUES (@numero, @baja)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@numero", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = numero;

                //Cx.SqlCmd.Parameters.Add("@estado", SqlDbType.Int);
                //Cx.SqlCmd.Parameters[1].Value = estado;

                Cx.SqlCmd.Parameters.Add("@baja", SqlDbType.Int);
                Cx.SqlCmd.Parameters[1].Value = baja;


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

        public static DataTable tablaMesas_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Mesa4 WHERE baja = 0";

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

        public static DataTable tablaMesas_db(int numero)
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Mesa4 WHERE numero LIKE @numero AND baja = 0";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@numero", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = numero;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(medios); //Llenamos el DataTable

            }
            catch (Exception)
            {
                medios = null;
            }
            return medios;
        }

        public static bool guardarModificadoMesa_db(int id_mesa, int numero)
        {
            string sql = "UPDATE Mesa4 SET numero = @numero WHERE baja = 0 AND id_mesa = @id_mesa";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@id_mesa", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = id_mesa;

                Cx.SqlCmd.Parameters.Add("@numero", SqlDbType.Int);
                Cx.SqlCmd.Parameters[1].Value = numero;

                //Cx.SqlCmd.Parameters.Add("@estado", SqlDbType.Int);
                //Cx.SqlCmd.Parameters[2].Value = estado;

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

        public static bool eliminarMesa_db(int ID)
        {
            string sql = "UPDATE Mesa4 SET baja = 1 WHERE id_mesa = @ID";

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

        //public static DataTable Combo_box_Mesa_Estado_db()
        //{
        //    DataTable medios = new DataTable("Medios");

        //    string sql = "SELECT * FROM Estados";

        //    try
        //    {
        //        Conexion Cx = new Conexion();
        //        Cx.SetComandoTexto();
        //        Cx.SetSQL(sql);
        //        SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
        //        sqlDat.Fill(medios); //Llenamos el DataTable

        //    }
        //    catch (Exception)
        //    {
        //        medios = null;
        //    }
        //    return medios;
        //}
    }
}
