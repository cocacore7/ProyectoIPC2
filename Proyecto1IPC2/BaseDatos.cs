using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto1IPC2
{
    public class BaseDatos
    {
        public SqlConnection registrar()
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BaseDatos"].ConnectionString);
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            else
            {
                conexion.Open();
            }
            return conexion;
        }
    }
}