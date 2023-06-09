﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace Cinema.DB_Layer
{
    internal class DBMain
    {
        string strConnectionString;
        SqlConnection con = null;
        SqlDataAdapter sql_data = null;
        DataTable data = null;

        public DBMain(int type)
        {
            if (type == 0)
            {
                strConnectionString = "Data Source=172.16.30.56;Initial Catalog=Cinema;Integrated Security=False;User ID=login123;Password=login";
            }
            else
            {
                strConnectionString = "Data Source=172.16.30.56;Initial Catalog=Cinema;Integrated Security=False;User ID=customer123;Password=customer";
            }
            con = new SqlConnection(strConnectionString);
        }
        public DataTable LoadMovies(string sql)
        {
            sql_data = new SqlDataAdapter(sql, con);
            data = new DataTable();
            sql_data.Fill(data);

            return data;
        }
        public List<int> LoadSeats(string sql)
        {
            List<int> list = new List<int>();

            if (con.State == ConnectionState.Open)
                con.Close();
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
        public void SumTotalCost(string sql, ref int cost)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cost = reader.GetInt32(0);
                    }
                }
            }
        }
        public void UserInformation(string sql, ref User cus)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cus.Balance = reader.GetInt32(0);
                        cus.Point = reader.GetInt32(1);
                        cus.isVip = reader.GetBoolean(2);
                        cus.Expense = reader.GetInt32(3);
                    }
                }
            }
        }
        public void CustomerLogin(string sql, ref User cus, ref bool result)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cus.User_ID = reader.GetString(0);
                        cus.Name = reader.GetString(1);
                        cus.Balance = reader.GetInt32(2);
                        cus.Point = reader.GetInt32(3);
                        cus.isVip = reader.GetBoolean(4);
                        result = true;
                    }
                }
            }
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
