using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace GymSystemDesktop.DbConnection
{
    public class DbConn
    {

        private static DbConn instance;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter da;
        string connectionString = "Server=tcp:labratsserver.database.windows.net,1433;Initial Catalog=GymRegister;Persist Security Info=False;User ID=labratsadministrator;Password=Pedro123lab;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private DbConn()
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter(cmd);
        }


        public static DbConn GetInstance()
        {
            if(instance == null)
            {
                instance = new DbConn();
            }
            return instance;
        }


        public DataTable ExecuteQuery(string query)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                dt = new DataTable();
                cmd.CommandText = query;
                cmd.Connection = conn;
                da.Fill(dt);
                return dt;
            }

        }

        public DataTable ExecuteQueryWithParams(string query, string[] parametros)
        {
            for(int i = 0; i <parametros.Length-1; i++)
            {
                query += $" '{parametros[i]}',";
            }

            query += $" '{parametros[parametros.Length - 1]}'";
            return ExecuteQuery(query);
        }
        

    }
}
