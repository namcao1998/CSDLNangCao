using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo01
{
    public partial class FStudentInfo : Form
    {
        public FStudentInfo()
        {
            InitializeComponent();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAccount account = new FAccount();
            account.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FSubject subject = new FSubject();
            subject.Show();
        }

        private void nhómMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGroupSubject groupsub = new FGroupSubject();
            groupsub.Show();
        }
    }
}
