using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DB_Layer
{
    internal class DBMain
    {
        string strConnectionString = "Data Source=localhost;Initial Catalog=Cinema;Integrated Security=False;User ID=sa;Password=123456";

        SqlConnection con = null;

        public DBMain()
        {
            con = new SqlConnection(strConnectionString);
        }

        public List<int> LoadData(string sql)
        {
            List<int> list = new List<int>();

            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetInt32(0));
                    }
                }
            }
            return list;
        }

        public void MyExecuteNonQuery(string sql)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
    }
}
