using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_TiecCuoi.DAO
{
    class DataProvider
    {
        static string connectionSTR = @"Data Source=XPS13-PC\SQLEXPRESS;Initial Catalog=QUAN_LY_TIEC_CUOI;Integrated Security=True";

        public static DataSet getDataSet(string command)
        {
            DataSet ds = new DataSet();
            using (SqlConnection cn = new SqlConnection(connectionSTR))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(command, cn);
                SqlDataAdapter ap = new SqlDataAdapter(cmd);
                ds.Reset();
                ap.Fill(ds);
                return ds;
            }
        }

        public static DataTable getDataTable(string command)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(connectionSTR))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(command, cn);
                SqlDataAdapter ap = new SqlDataAdapter(cmd);
                dt.Reset();
                ap.Fill(dt);
                return dt;
            }
        }

        public SqlDataReader getDataReader(string cmd)
        {
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(connectionSTR);
            cn.Open();
            SqlCommand command = new SqlCommand(cmd, cn);
            dr = command.ExecuteReader();
            return dr;
        }

        public static void queryDataBase(string cmd)
        {
            try
            {
                SqlConnection cn = new SqlConnection(connectionSTR);
                cn.Open();
                SqlCommand command = new SqlCommand(cmd, cn);
                command.ExecuteNonQuery();
                cn.Close();
                System.Windows.Forms.MessageBox.Show("Executed");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed");
            }
        }

        internal SqlConnection connDB()
        {
            SqlConnection cnn = new SqlConnection(connectionSTR);
            return cnn;
        }
    }
}
