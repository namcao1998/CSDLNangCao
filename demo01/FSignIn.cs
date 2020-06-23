using demo01.DAO;
using demo01.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace demo01
{
    public partial class FSignIn : Form
    {
        public FSignIn()
        {
            InitializeComponent();
        }

        bool SignIn(string username,string password)
        {
            return DangNhapDAO.Instance.TaiKhoanDangNhap(username, password);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username1 = txbUserNameSignIn.Text;
            string password1= txbPasswordSignIn.Text;
            if (SignIn(username1, password1))
            {
                FStudentInfo student = new FStudentInfo();
                this.Hide();
                student.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hay mật khẩu, hãy kiểm tra lại!", "Thông báo");
            }
        }

        private void btnCancelSignIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn thoát ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        
        

       
    }
}
