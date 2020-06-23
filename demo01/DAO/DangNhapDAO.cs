using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.Sql;
using System.Data.SqlClient;
using demo01.DAO;

namespace demo01.DAO
{
    public class DangNhapDAO
    {
        private static DangNhapDAO instance;

        public static DangNhapDAO Instance {

            get { if(instance==null) instance = new DangNhapDAO(); return DangNhapDAO.instance; }
            private set { DangNhapDAO.instance = value; }
        }

        private DangNhapDAO() { }

        private ConnectState Conn = new ConnectState();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader LeerFilas;

        public bool TaiKhoanDangNhap(string username,string password)
        {
            string xmlstring = "<T taikhoan=" + username + " matkhau=" + password+ "/>";
            XmlDocument xm = new XmlDocument();
            XmlDocument xm1 = new XmlDocument();
            xm.LoadXml(string.Format("<root>{0}</root>", xmlstring));

            DataTable data = DataProvider.Instance.ExecuteQuery("exec CSDL_DangNhap @InputValue ='"+xm+"'");

            return data.Rows.Count > 0;
        }


    }
}
