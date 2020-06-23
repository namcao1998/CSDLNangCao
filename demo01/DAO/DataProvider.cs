using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace demo01.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectString = "Data Source=.\\sqlexpress;Initial Catalog=CSDL_QuanLyDiemSinhVien;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection sqlConnect = new SqlConnection(connectString))// tạo chuỗi kết nối đến với Oracle
            {
                sqlConnect.Open();

                SqlCommand command = new SqlCommand(query, sqlConnect);//tạo lệnh để thực hiện query trên connectString

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);//là trung gian thực hiện command

                dataAdapter.Fill(data);//đổ dữ liệu lấy được từ query lên bảng dataadapter trên

                sqlConnect.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection sqlConnect = new SqlConnection(connectString))// tạo chuỗi kết nối đến với Oracle
            {
                sqlConnect.Open();

                SqlCommand command = new SqlCommand(query, sqlConnect);//tạo lệnh để thực hiện query trên connectString

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                sqlConnect.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection sqlConnect = new SqlConnection(connectString))// tạo chuỗi kết nối đến với Oracle
            {
                sqlConnect.Open();

                SqlCommand command = new SqlCommand(query, sqlConnect);//tạo lệnh để thực hiện query trên connectString

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                sqlConnect.Close();
            }

            return data;
        }
    }
}

