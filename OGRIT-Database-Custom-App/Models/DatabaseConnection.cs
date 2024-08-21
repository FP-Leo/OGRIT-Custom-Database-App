﻿using System.Data.SqlClient;
using System.Data;
using OGRIT_Database_Custom_App.Models;


namespace OGRIT_Database_Custom_App.Model
{
    public class DatabaseConnection
    {
        private SqlConnection? Connection;

        public DatabaseConnection(){}
        public void OpenConnection()
        {
            if (Connection == null) return;

            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (Connection == null) return;

            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        public string? SetConnection(ConnectionString connectionString)
        {
            try
            {
                Connection = new SqlConnection(connectionString.ToString());

                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
