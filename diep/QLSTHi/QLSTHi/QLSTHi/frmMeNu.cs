using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSTHi
{
    public partial class frmMeNu : Form
    {
        public frmMeNu()
        {
            InitializeComponent();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {

            frmHangHoa frmdg = new frmHangHoa();
            frmdg.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frmdg = new frmHoaDon();
            frmdg.ShowDialog();   
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmdg = new frmKhachHang();
            frmdg.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmdg = new frmNhanVien();
            frmdg.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHuongDan frmdg =  new frmHuongDan();
            frmdg.ShowDialog();
        }
    }
}
