using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Data.SqlClient;

namespace capaDatos
{
    class Conexion
    {
        private SqlCommand sqlCmd;
        private SqlConnection sqlCon;

        private SqlTransaction tran = null;

        public Conexion()
        {
            string servidor = ConfigurationManager.AppSettings["server"];
            string usuario = ConfigurationManager.AppSettings["user_db"];
            string baseDatos = ConfigurationManager.AppSettings["base_db"];
            string password = ConfigurationManager.AppSettings["password_db"];

            sqlCon = new SqlConnection();
            //1. Establecer la cadena de conexion

            sqlCon.ConnectionString = "Data Source = " + servidor + "; Initial Catalog = " + baseDatos + "; User ID =" + usuario + "; Password = " + password;


            //sqlCon.ConnectionString = "User ID=postgres;Password=" + password + ";Host=" + servidor + ";Port=5432;Database=drogueria"; (Para Postgress)


            //2. Establecer el comando

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCon; //La conexion que va a usar el comando
            sqlCmd.CommandTimeout = 0;
        }
        
        public SqlCommand SqlCmd
        {
            get
            {
                return sqlCmd;
            }

            set
            {
                sqlCmd = value;
            }
        }
        
        public void SetComandoTexto()
        {
            sqlCmd.CommandType = CommandType.Text;
        }

        public void SetSQL(string query)
        {
            sqlCmd.CommandText = query;
        }

        public SqlCommand Comando()
        {
            return sqlCmd;
        }

        public void Abrir()
        {
            sqlCon.Open();
        }

        public void Cerrar()
        {
            sqlCon.Close();
        }
    }
}
