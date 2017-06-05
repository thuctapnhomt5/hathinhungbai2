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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from dbo.NhanVien";

        private void btnThem_Click(object sender, EventArgs e)
        {

            btnOk.Visible = true;
            btnThem.Visible = false;
            txtID.Text = txtHoTen.Text = txtGioiTinh.Text = txtNgaySinh.Text = txtQueQuan.Text = txtCMND.Text = string.Empty;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đuổi không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("Delete_NhanVien", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@ID_NhanVien", txtID.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Đã đuổi thành công");
                    conn.KhoiTao(dataGridView1, @"select * from NhanVien");
                    txtID.Text = txtHoTen.Text = txtQueQuan.Text = txtGioiTinh.Text = txtCMND.Text = txtNgaySinh.Text = txtFind.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Có lỗi, không thể xóa dữ liệu");
                }
                conn.DongKetNoi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đuổi không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("Delete_NhanVien", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@ID_NhanVien", txtID.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Đã đuổi thành công");
                    conn.KhoiTao(dataGridView1, @"select * from NhanVien");
                    txtID.Text = txtHoTen.Text = txtQueQuan.Text = txtGioiTinh.Text = txtCMND.Text = txtNgaySinh.Text = txtFind.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Có lỗi, không thể xóa dữ liệu");
                }
                conn.DongKetNoi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("Edit_NhanVien", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;

            sqlcm.Parameters.AddWithValue("@id_nhanvien", txtID.Text);
            sqlcm.Parameters.AddWithValue("@hoten", txtHoTen.Text);
            sqlcm.Parameters.AddWithValue("@quequan", txtQueQuan.Text);
            sqlcm.Parameters.AddWithValue("@gt", txtGioiTinh.Text);
            sqlcm.Parameters.AddWithValue("@CMND", txtCMND.Text);
            sqlcm.Parameters.AddWithValue("@ngaysinh", txtNgaySinh.Text);


            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from dbo.NhanVien");
                txtID.Text = txtHoTen.Text = txtQueQuan.Text = txtGioiTinh.Text = txtCMND.Text = txtGioiTinh.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Visible = false;
            btnThem.Visible = true;
            dataGridView1.Enabled = true;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("Add_NhanVien", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@id_nhanvien", txtID.Text);
            sqlcm.Parameters.AddWithValue("@hoten", txtHoTen.Text);
            sqlcm.Parameters.AddWithValue("@quequan", txtQueQuan.Text);
            sqlcm.Parameters.AddWithValue("@gt", txtGioiTinh.Text);
            sqlcm.Parameters.AddWithValue("@CMND", txtCMND.Text);
            sqlcm.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(txtNgaySinh.Text));

            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                conn.KhoiTao(dataGridView1, @"select * from NhanVien");
                txtID.Text = txtHoTen.Text = txtQueQuan.Text = txtGioiTinh.Text = txtCMND.Text = txtGioiTinh.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtHoTen.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtQueQuan.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtGioiTinh.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtCMND.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                DateTime dt;
                dt = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
                txtNgaySinh.Text = dt.ToShortDateString();
            }
            else
            {
                return;
            }
        }
    }
}
