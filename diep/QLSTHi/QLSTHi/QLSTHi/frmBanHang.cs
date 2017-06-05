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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
            Load += frmBanHang_Load;
        }

        ConnectData con = new ConnectData();
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            txtNgayBan.Text = DateTime.Now.ToShortDateString();
            txtNgayBan.ReadOnly = true;

            con.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(@"select TenHang, SoLuong from HangHoa", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            con.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(@"select TenHang, SoLuong from HangHoa", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bool check = false;
            foreach (DataRow dr in dt.Rows)
            {
                if (txtTenHang.Text.Trim() == dr[0].ToString().Trim() && int.Parse(txtSoLuong.Text) <= int.Parse(dr[1].ToString().Trim()))
                {
                    check = true;
                    break;
                }
            }
            if (check == true)
            {
                SqlCommand sqlcm = new SqlCommand("BanHang", con.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@tenhang", txtTenHang.Text);
                sqlcm.Parameters.AddWithValue("@soluong", int.Parse(txtSoLuong.Text));
                sqlcm.Parameters.AddWithValue("@ngayban", Convert.ToDateTime(txtNgayBan.Text).ToShortDateString());
                int test = (int)sqlcm.ExecuteNonQuery();
                if (test > 0)
                {
                    MessageBox.Show("Bán thành công");
                    txtNgayBan.Text = txtSoLuong.Text = txtTenHang.Text = string.Empty;
                }
                else MessageBox.Show("Có lỗi");
            }
            else MessageBox.Show("Có lỗi");
            con.DongKetNoi();
        }
    }
}
