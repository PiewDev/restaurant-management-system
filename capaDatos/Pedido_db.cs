using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Pedido_db
    {
        public static bool guardarTemporal_db(int id, int mesa, int id_mozo, int id_productosimple, int baja)
        {
            string sql = "INSERT INTO Temporal3(id, mesa, id_mozo, id_productosimple, baja) VALUES (@id, @mesa, @id_mozo, @id_productosimple, @baja)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@id", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = id;

                Cx.SqlCmd.Parameters.Add("@mesa", SqlDbType.Int);
                Cx.SqlCmd.Parameters[1].Value = mesa;

                Cx.SqlCmd.Parameters.Add("@id_mozo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[2].Value = id_mozo;

                Cx.SqlCmd.Parameters.Add("@id_productosimple", SqlDbType.Int);
                Cx.SqlCmd.Parameters[3].Value = id_productosimple;

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

        public static bool guardarTemporal_db2(int id, int mesa, int id_mozo, int id_productocompuesto, int baja)
        {
            string sql = "INSERT INTO Temporal3(id, mesa, id_mozo, id_productocompuesto, baja) VALUES (@id, @mesa, @id_mozo, @id_productocompuesto, @baja)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@id", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = id;

                Cx.SqlCmd.Parameters.Add("@mesa", SqlDbType.Int);
                Cx.SqlCmd.Parameters[1].Value = mesa;

                Cx.SqlCmd.Parameters.Add("@id_mozo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[2].Value = id_mozo;

                Cx.SqlCmd.Parameters.Add("@id_productocompuesto", SqlDbType.Int);
                Cx.SqlCmd.Parameters[3].Value = id_productocompuesto;

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

        public static bool guardarVenta_db(int comanda, string mozo, int mesa, string fecha, string hora, int total, int baja)
        {
            string sql = "INSERT INTO Venta2(comanda, mozo, mesa, fecha, hora, total, baja) VALUES (@comanda, @mozo, @mesa, @fecha, @hora, @total, @baja)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@comanda", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = comanda;

                Cx.SqlCmd.Parameters.Add("@mozo", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = mozo;

                Cx.SqlCmd.Parameters.Add("@mesa", SqlDbType.Int);
                Cx.SqlCmd.Parameters[2].Value = mesa;

                Cx.SqlCmd.Parameters.Add("@fecha", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[3].Value = fecha;

                Cx.SqlCmd.Parameters.Add("@hora", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[4].Value = hora;

                Cx.SqlCmd.Parameters.Add("@total", SqlDbType.Int);
                Cx.SqlCmd.Parameters[5].Value = total;

                Cx.SqlCmd.Parameters.Add("@baja", SqlDbType.Int);
                Cx.SqlCmd.Parameters[6].Value = baja;


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

        public static DataTable listarVenta_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Venta2 WHERE baja = 0";
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
    }
}
