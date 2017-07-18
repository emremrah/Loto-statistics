﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoStatistics.DataAccessLayer {
    class DataAccessLayer {
        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=lotoistatistik.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'";

        OleDbConnection connection = new OleDbConnection();
        DataTable dataTable = new DataTable();  //Bellekteki verilerin bir tablosunu temsil ediyor.

        //SELECT
        public DataTable Read() {
            connection.ConnectionString = connectionString;
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                connection.Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM [Sheet1$]", connection);
            return Execute(command);
        }

        public DataTable Execute(OleDbCommand command) {
            OleDbDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
        }
    }
}