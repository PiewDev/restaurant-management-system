using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Reportes_db
    {
        public static DataTable listarVentasXMozo_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT c.id_mozo, COUNT(c.id_mozo) AS Cantidad FROM Comanda2 AS c INNER JOIN Mozo2 AS m ON c.id_mozo = m.id_mozo GROUP BY c.id_mozo";
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

        //public static DataTable listarVentasXMozo_db(string mozo)
        //{
        //    DataTable medios = new DataTable("Medios");

        //    string sql = "SELECT * FROM Venta2 WHERE mozo LIKE @mozo AND baja = 0";
        //    try
        //    {
        //        Conexion Cx = new Conexion();
        //        Cx.SetComandoTexto();
        //        Cx.SetSQL(sql);

        //        Cx.SqlCmd.Parameters.Add("@mozo", SqlDbType.VarChar);
        //        Cx.SqlCmd.Parameters[0].Value = mozo;

        //        SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
        //        sqlDat.Fill(medios); //Llenamos el DataTable

        //    }
        //    catch (Exception)
        //    {
        //        medios = null;
        //    }
        //    return medios;
        //}

        //public static DataTable listarVentasDiaria_db()
        //{
        //    DataTable medios = new DataTable("Medios");

        //    string sql = "SELECT * FROM Comanda2 WHERE baja = 0";
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

        public static DataTable listarVentasDiaria_db(string fecha)
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM Comanda2 WHERE fecha LIKE @fecha";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@fecha", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[0].Value = fecha;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(medios); //Llenamos el DataTable

            }
            catch (Exception)
            {
                medios = null;
            }
            return medios;
        }

        //public static DataTable listarPrecioCategoria_db()
        //{
        //    DataTable medios = new DataTable("Medios");

        //    string sql = "SELECT ps.id_productosimple, ps. FROM ProductoSimple2 AS ps, ProductoCompuesto5 AS pc, Categoria2 AS c WHERE baja = 0";
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

        public static DataTable listarPrecioCategoriaSimple_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT ps.id_productosimple, ps.marca, ps.precio_venta FROM ProductoSimple2 AS ps INNER JOIN Categoria2 AS c ON ps.id_categoria = c.id_categoria";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                //Cx.SqlCmd.Parameters.Add("@categoria", SqlDbType.VarChar);
                //Cx.SqlCmd.Parameters[0].Value = categoria;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(medios); //Llenamos el DataTable

            }
            catch (Exception)
            {
                medios = null;
            }
            return medios;
        }

        public static DataTable listarPrecioCategoriaCompuesto_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT pc.id_productocompuesto, pc.nombre, pc.precio_venta FROM ProductoCompuesto5 AS pc INNER JOIN Categoria2 AS c ON pc.id_categoria = c.id_categoria";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                //Cx.SqlCmd.Parameters.Add("@categoria", SqlDbType.VarChar);
                //Cx.SqlCmd.Parameters[0].Value = categoria;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(medios); //Llenamos el DataTable

            }
            catch (Exception)
            {
                medios = null;
            }
            return medios;
        }

        //    public static DataTable listarPrecioProductoCompuesto_db()
        //    {
        //        DataTable medios = new DataTable("Medios");

        //        string sql = "SELECT * FROM ProductoCompuesto3 WHERE baja = 0";
        //        try
        //        {
        //            Conexion Cx = new Conexion();
        //            Cx.SetComandoTexto();
        //            Cx.SetSQL(sql);
        //            SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
        //            sqlDat.Fill(medios); //Llenamos el DataTable

        //        }
        //        catch (Exception)
        //        {
        //            medios = null;
        //        }
        //        return medios;
        //    }

        //    public static DataTable listarPrecioProductoCompuesto_db(string categoria)
        //    {
        //        DataTable medios = new DataTable("Medios");

        //        string sql = "SELECT * FROM ProductoCompuesto3 WHERE categoria LIKE @categoria AND baja = 0";
        //        try
        //        {
        //            Conexion Cx = new Conexion();
        //            Cx.SetComandoTexto();
        //            Cx.SetSQL(sql);

        //            Cx.SqlCmd.Parameters.Add("@categoria", SqlDbType.VarChar);
        //            Cx.SqlCmd.Parameters[0].Value = categoria;

        //            SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
        //            sqlDat.Fill(medios); //Llenamos el DataTable

        //        }
        //        catch (Exception)
        //        {
        //            medios = null;
        //        }
        //        return medios;
        //    }

        //    public static DataTable listarPrecioMateriaPrima_db()
        //    {
        //        DataTable medios = new DataTable("Medios");

        //        string sql = "SELECT * FROM MateriaPrima WHERE baja = 0";
        //        try
        //        {
        //            Conexion Cx = new Conexion();
        //            Cx.SetComandoTexto();
        //            Cx.SetSQL(sql);
        //            SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
        //            sqlDat.Fill(medios); //Llenamos el DataTable

        //        }
        //        catch (Exception)
        //        {
        //            medios = null;
        //        }
        //        return medios;
        //    }

        //    public static DataTable listarPrecioMateriaPrima_db(string categoria)
        //    {
        //        DataTable medios = new DataTable("Medios");

        //        string sql = "SELECT * FROM MateriaPrima WHERE categoria LIKE @categoria AND baja = 0";
        //        try
        //        {
        //            Conexion Cx = new Conexion();
        //            Cx.SetComandoTexto();
        //            Cx.SetSQL(sql);

        //            Cx.SqlCmd.Parameters.Add("@categoria", SqlDbType.VarChar);
        //            Cx.SqlCmd.Parameters[0].Value = categoria;

        //            SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
        //            sqlDat.Fill(medios); //Llenamos el DataTable

        //        }
        //        catch (Exception)
        //        {
        //            medios = null;
        //        }
        //        return medios;
        //    }
        //}
    }
}
