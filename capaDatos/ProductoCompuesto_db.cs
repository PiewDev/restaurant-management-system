using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class ProductoCompuesto_db
    {
        public static bool guardarProductoCompuesto_db(string nombre, int categoria, int costo, int precio_venta, int baja)
        {
            string sql = "INSERT INTO ProductoCompuesto5(nombre, costo, precio_venta, id_categoria, baja) VALUES (@nombre, @costo, @precio_venta, @id_categoria, @baja)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[0].Value = nombre;

                Cx.SqlCmd.Parameters.Add("@costo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[1].Value = costo;

                Cx.SqlCmd.Parameters.Add("@precio_venta", SqlDbType.Int);
                Cx.SqlCmd.Parameters[2].Value = precio_venta;

                Cx.SqlCmd.Parameters.Add("@id_categoria", SqlDbType.Int);
                Cx.SqlCmd.Parameters[3].Value = categoria;

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

        public static DataTable tablaProductoCompuesto_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM ProductoCompuesto3 WHERE baja = 0";
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

        public static DataTable tablaProductoCompuestoPedido_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT id_productocompuesto, nombre, precio_venta FROM ProductoCompuesto5 WHERE baja = 0";
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

        public static DataTable tablaProductoCompuesto_db(string categoria)
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM ProductoCompuesto3 WHERE categoria LIKE @categoria AND baja = 0";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@categoria", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[0].Value = categoria;

                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando()); //Tomamos los datos de la BD
                sqlDat.Fill(medios); //Llenamos el DataTable

            }
            catch (Exception)
            {
                medios = null;
            }
            return medios;
        }

        public static DataTable tablaProductoCompuesto_db(string categoria, string nombre)
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM ProductoCompuesto3 WHERE categoria, nombre LIKE @categoria, @nombre AND baja = 0";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@categoria", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[0].Value = categoria;

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

        public static bool guardarModificadoProductoCompuesto_db(int id_productocompuesto, string categoria, string nombre, string descripcion, int costo, int precio_venta)
        {
            string sql = "UPDATE ProductoCompuesto3 SET categoria = @categoria, nombre = @nombre, descripcion = @descripcion, costo = @costo, precio_venta = @precio_venta WHERE baja = 0 AND id_productocompuesto = @id_productocompuesto";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@id_productocompuesto", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = id_productocompuesto;

                Cx.SqlCmd.Parameters.Add("@categoria", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = categoria;

                Cx.SqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[2].Value = nombre;

                Cx.SqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[3].Value = descripcion;

                Cx.SqlCmd.Parameters.Add("@costo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[4].Value = costo;

                Cx.SqlCmd.Parameters.Add("@precio_venta", SqlDbType.Int);
                Cx.SqlCmd.Parameters[5].Value = precio_venta;


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

        public static bool eliminarProductoCompuesto_db(int ID)
        {
            string sql = "UPDATE ProductoCompuesto3 SET baja = 1 WHERE id_productocompuesto = @ID";

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

        public static DataTable comboBoxCategoria_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT id_categoria, nombre FROM Categoria2 WHERE tipo = 'Compuesto'";
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
