using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;
namespace QLVT
{
    static class Program
    {
        public static FormMain formMain;
        public static FormNhanVien formNV;
        public static FormVatTu formVT;
        public static FormDonDatHang formDonDatHang;
        public static FormNhapHang formNhapHang;
        public static FormXuatHang formXuatHang;
        public static FormKho formKho;

        public static string server = "";
        public static string database = "QLVT_DH";
        public static string userName = "";
        public static string password = "";

        public static string userServer = "";
        public static string userNameHTai = "";
        public static string passwordHTai = "";
        public static string remoteLogin = "HTKN";
        public static string remotePassword = "123";

        public static string userId = "";//manv
        public static string username = "";//ho va ten
        public static string userGroup = "";

        public static BindingSource bindingSourceCN;
        public static SqlConnection sqlConnection;
        public static SqlCommand sqlCommand;
        public static SqlDataReader dataReader;

        public static string connectionString = "";
        public static int mChinhanh;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new FormDangNhap());
        }

        public static bool Connect()
        {
           
            Program.connectionString = "Server=" + Program.server + ";"
                + "Database=" + Program.database + ";"
                + "User Id=" + Program.userName + ";"
                + "Password=" + Program.password;
            Program.sqlConnection = new SqlConnection(Program.connectionString);
            try
            {
                Program.sqlConnection.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ket noi that bai, xem lai login va pasword" + "\nDetails: " + e.Message);
                Program.sqlConnection.Close();
                return false;
            }
        }
        
        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myreader;

            SqlCommand sqlcmd = new SqlCommand(cmd, Program.sqlConnection);
            sqlcmd.CommandType = CommandType.Text;

            sqlcmd.CommandTimeout = 660;
            if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
