using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace StockManager.WF.Model
{
    class DB
    {

        // établir la connection de base de données.

        /// <summary>
        /// connection => connnectionSQL
        /// </summary>
        public static string _ConnectionString = "Server=localhost\\SQLEXPRESS;Database=StockManager;Integrated security=True;";
        public SqlConnection connection= new SqlConnection(_ConnectionString);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader SelectDataReader(string sql)
        {
            connection.Open();
            SqlCommand com = new SqlCommand(sql, connection);
            return com.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // fermeture de la base
        public void CloseConnection()
        {
            connection.Close();
        }

        public int ExecuteSQLCommand(string sql)
        {
            connection.Open();
            SqlCommand com = new SqlCommand(sql, connection);
            int a = com.ExecuteNonQuery();
            connection.Close();
            return a;
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="sql">Command SQL</param>
       /// <param name="result"> résultat retourner</param>
       /// <returns></returns>
        public DataSet GetDataSet(string sql, string result)
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, result);
            connection.Close();
            return dataSet;
        }

        public int GetSingleIntValue(string sql)
        {
            connection.Open();
            SqlCommand com = new SqlCommand(sql, connection);
            int a = 0;
            var t = com.ExecuteScalar();
            // quand command.ExecuteScalar() est vide retourne 0;
            if (t == DBNull.Value || t == null)
            {

            }
            else
            {
                a = (int)com.ExecuteScalar();
            }
            connection.Close();
            return a;
        }

        public bool GetSingleBoolValue(string sql)
        {
            connection.Open();
            SqlCommand com = new SqlCommand(sql, connection);
            bool a = false;
            var t = com.ExecuteScalar();

            if (t == DBNull.Value || t == null)
            {
           
            }
            else
            {
                a = Convert.ToBoolean(com.ExecuteScalar());
            }
            connection.Close();
            return a;
        }



    }
}
