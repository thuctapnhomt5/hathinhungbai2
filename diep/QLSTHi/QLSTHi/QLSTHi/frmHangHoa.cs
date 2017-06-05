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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from dbo.HangHoa";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("sp_hh_timkiem", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;

            sqlcm.Parameters.Add(new SqlParameter("@value", txtFind.Text));


            SqlDataAdapter da = new SqlDataAdapter(sqlcm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            if (dataGridView1.RowCount <= 0) MessageBox.Show("Nội dung cần tìm không có");
            txtFind.Text = string.Empty;
            conn.DongKetNoi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtTenHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtGiaHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtNgayNhap.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frmnh = new frmNhapHang();
            frmnh.ShowDialog();
            conn.KhoiTao(dataGridView1, @"select * from HangHoa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBanHang frmbh = new frmBanHang();
            frmbh.ShowDialog();
            conn.KhoiTao(dataGridView1, @"select * from HangHoa");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            frmThongKe frmtk = new frmThongKe();
            frmtk.ShowDialog();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }
    }
}
