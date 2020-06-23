using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace demo01.DAO
{
    class ConnectState
    {
       
        private static string Conn = "Data Source=.\\sqlexpress;Initial Catalog=CSDL_QuanLyDiemSinhVien;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(Conn);

        public SqlConnection OpenConnect()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }
        public SqlConnection CloseConnect()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return connection;
        }
    }
}
