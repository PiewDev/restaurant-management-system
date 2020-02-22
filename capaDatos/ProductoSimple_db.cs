using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class ProductoSimple_db
    {
        public static bool guardarProductoSimple_db(string marca, int categoria, string descripcion, int costo, int precio_venta, int cantidad, int baja)
        {
            string sql = "INSERT INTO ProductoSimple2(marca, descripcion, costo, precio_venta, cantidad, id_categoria, baja) VALUES (@marca, @descripcion, @costo, @precio_venta, @cantidad, @categoria, @baja)";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@marca", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[0].Value = marca;

                Cx.SqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = descripcion;

                Cx.SqlCmd.Parameters.Add("@costo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[2].Value = costo;

                Cx.SqlCmd.Parameters.Add("@precio_venta", SqlDbType.Int);
                Cx.SqlCmd.Parameters[3].Value = precio_venta;

                Cx.SqlCmd.Parameters.Add("@cantidad", SqlDbType.Int);
                Cx.SqlCmd.Parameters[4].Value = cantidad;

                Cx.SqlCmd.Parameters.Add("@categoria", SqlDbType.Int);
                Cx.SqlCmd.Parameters[5].Value = categoria;

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

        public static DataTable tablaProductoSimple_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM ProductoSimple2 WHERE baja = 0";
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

        public static DataTable tablaProductoSimplePedido_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT id_productosimple, marca, precio_venta FROM ProductoSimple2 WHERE baja = 0";
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

        public static DataTable tablaProductoSimple_db(string categoria)
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT * FROM ProductoSimple2 WHERE categoria LIKE @categoria AND baja = 0";
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

        public static bool guardarModificadoProductoSimple_db(int id_productosimple, string marca, string descripcion, int costo, int precio_venta, int cantidad, int id_categoria)
        {
            string sql = "UPDATE ProductoSimple2 SET marca = @marca, descripcion = @descripcion, costo = @costo, precio_venta = @precio_venta, cantidad = @cantidad, id_categoria = @id_categoria WHERE baja = 0 AND id_productosimple = @id_productosimple";

            try
            {
                Conexion Cx = new Conexion();
                Cx.SetComandoTexto();
                Cx.SetSQL(sql);

                Cx.SqlCmd.Parameters.Add("@id_productosimple", SqlDbType.Int);
                Cx.SqlCmd.Parameters[0].Value = id_productosimple;

                Cx.SqlCmd.Parameters.Add("@marca", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[1].Value = marca;

                Cx.SqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                Cx.SqlCmd.Parameters[2].Value = descripcion;

                Cx.SqlCmd.Parameters.Add("@costo", SqlDbType.Int);
                Cx.SqlCmd.Parameters[3].Value = costo;

                Cx.SqlCmd.Parameters.Add("@precio_venta", SqlDbType.Int);
                Cx.SqlCmd.Parameters[4].Value = precio_venta;

                Cx.SqlCmd.Parameters.Add("@cantidad", SqlDbType.Int);
                Cx.SqlCmd.Parameters[5].Value = cantidad;

                Cx.SqlCmd.Parameters.Add("@id_categoria", SqlDbType.Int);
                Cx.SqlCmd.Parameters[6].Value = id_categoria;

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

        public static bool eliminarProductoSimple_db(int ID)
        {
            string sql = "UPDATE ProductoSimple2 SET baja = 1 WHERE id_productosimple = @ID";

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

        public static DataTable Listar_Categoria_db()
        {
            DataTable medios = new DataTable("Medios");

            string sql = "SELECT id_categoria,nombre FROM Categoria2 WHERE tipo = 'Simple'";

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
