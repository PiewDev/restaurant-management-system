using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Comanda_db
    {
        public static bool guardarComanda_db(int id_mozo, int total, string fecha, string hora, int id_mesa)
        {
            string sql = "INSERT INTO Comanda2(id_mozo, total, fecha, hora, id_mesa) VALUES (@id_mozo, @total, @fecha, @hora, @id_mesa)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@id_mozo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = id_mozo;

                Cx.SqlCmd.Parameters.Add("@total", SqlDbType.Int);
                Cx.SqlCmd.Parameters[1].Value = total;

                Cx.SqlCmd.Parameters.Add("@fecha", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[2].Value = fecha;

                Cx.SqlCmd.Parameters.Add("@hora", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[3].Value = hora;

                Cx.SqlCmd.Parameters.Add("@id_mesa", SqlDbType.Int);
                Cx.SqlCmd.Parameters[4].Value = id_mesa;

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

        public static DataTable tablaComanda_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Comanda2";
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
