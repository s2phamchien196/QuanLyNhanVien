using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien
{
    class KetNoi
    {
        
        static string stringConnect = @"Data Source=luongvanngoc;Initial Catalog=QuanLyNhanVien2;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(stringConnect);
        public static void Open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static DataTable loadTable(string cauLenh)
        {
            Open();
            SqlCommand cmd = new SqlCommand(cauLenh, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            Close();
        }

        public static void ThucThi(string cauLenh)
        {
            
                Open();
                SqlCommand cmd = new SqlCommand(cauLenh, con);
                cmd.ExecuteNonQuery();
                Close();
           
        }
        //
        public static SqlDataReader reader(string cauLenh)
        {
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(cauLenh, con);
                 return cmd.ExecuteReader();
                Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
        }
    }
}
