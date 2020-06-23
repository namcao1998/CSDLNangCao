using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.DTO
{
    public class DangNhapDTO
    {
        public DangNhapDTO(string tentk, string matkhautk)
        {
            this.TenTaiKhoan_Login = tentk;
            this.MatKhau_Login = matkhautk;
        }

        public DangNhapDTO(DataRow rows)
        {
            this.TenTaiKhoan_Login = rows["tentk"].ToString();
            this.MatKhau_Login = rows["matkhautk"].ToString();
        }

        private string matKhau_Login;

        private string tenTaiKhoan_Login;

        public string TenTaiKhoan_Login { get => tenTaiKhoan_Login; set => tenTaiKhoan_Login = value; }
        public string MatKhau_Login { get => matKhau_Login; set => matKhau_Login = value; }
        
    }
}
