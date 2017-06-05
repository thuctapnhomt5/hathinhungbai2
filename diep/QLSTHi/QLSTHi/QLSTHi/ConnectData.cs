﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLSTHi
{
    class ConnectData
    {
        public SqlConnection conn = new SqlConnection();
        public string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBANHANG_ST;Integrated Security=True";

        public void MoKetNoi()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.ConnectionString = constr;
                conn.Open();
            }
        }

        public void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void KhoiTao(DataGridView dtgv, string sqlcm)
        {
            MoKetNoi();
            SqlDataAdapter ap = new SqlDataAdapter(sqlcm, conn);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            dtgv.DataSource = dt;
            DongKetNoi();
        }
    }
}

