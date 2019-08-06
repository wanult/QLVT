using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
namespace QLVT
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Program.connectionString);
            sqlConnection.Open();
            string sql = "EXEC SP_DANGNHAP '" + Program.userName + "'";

            Program.sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            Program.dataReader = Program.sqlCommand.ExecuteReader();
            Program.dataReader.Read();
            Program.userId = Program.dataReader.GetValue(0).ToString();
            Program.username = Program.dataReader.GetValue(1).ToString();
            Program.userGroup = Program.dataReader.GetValue(2).ToString();
            Program.dataReader.Close();

            this.lbMaNV.Text += Program.userId;
            this.lbTenNV.Text += Program.username;
            this.lbNhom.Text += Program.userGroup;

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btDX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormNhanVien));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                FormNhanVien fnv = new FormNhanVien();
                fnv.MdiParent = this;
                fnv.Activate();
                fnv.Show();
            }
        }

        private void btVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormVatTu));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formVT = new FormVatTu();
                Program.formVT.MdiParent = Program.formMain;
                Program.formVT.Activate();
                Program.formVT.Show();
            }
        }

        private void btKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormKho));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formKho = new FormKho();
                Program.formKho.MdiParent = Program.formMain;
                Program.formKho.Activate();
                Program.formKho.Show();
            }
        }

        private void btDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormDonDatHang));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formDonDatHang = new FormDonDatHang();
                Program.formDonDatHang.MdiParent = Program.formMain;
                Program.formDonDatHang.Activate();
                Program.formDonDatHang.Show();
            }
        }

        private void ntPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormNhapHang));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formNhapHang = new FormNhapHang();
                Program.formNhapHang.MdiParent = Program.formMain;
                Program.formNhapHang.Activate();
                Program.formNhapHang.Show();
            }
        }

        private void btPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormXuatHang));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formXuatHang = new FormXuatHang();
                Program.formXuatHang.MdiParent = Program.formMain;
                Program.formXuatHang.Activate();
                Program.formXuatHang.Show();
            }
        }
    }
}
