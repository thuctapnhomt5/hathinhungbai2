using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSTHi
{
    public partial class frmĐăngNhập : Form
    {
        public frmĐăngNhập()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string str = @"select * from tblUser";

        private void but_join_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bool check = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == txtUser.Text && row[1].ToString() == txtPass.Text)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            if (check == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                txtPass.ReadOnly = txtUser.ReadOnly = true;
                //pAcc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tài khoản đăng nhập không hợp lệ không hợp lệ");
                txtUser.Text = txtPass.Text = string.Empty;
            }
            conn.DongKetNoi();
            frmMeNu fmmn = new frmMeNu();
            fmmn.ShowDialog();
        }

       

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_out_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void pAcc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
