using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLVT
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
            Program.server = "MYPC\\SERVER_1";
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được trống.", "Bị lỗi đăng nhập.", MessageBoxButtons.OK);
                txtLoginName.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được trống.", "Bị lỗi đăng nhập.", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            
            Program.userName = txtLoginName.Text;
            Program.password = txtPassword.Text;
            Program.server = cmbDSPM.SelectedValue.ToString();
            if (Program.Connect())
            {
                Program.mChinhanh = cmbDSPM.SelectedIndex;
                Program.bindingSourceCN = BindingSourceDSPM;
                Program.userServer = Program.server;
                Program.userNameHTai = Program.userName;
                Program.passwordHTai = Program.password;
                Program.formMain = new FormMain();
                Program.formMain.Activate();
                Program.formMain.Show();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            this.v_DSPMTableAdapter1.Fill(this.qLVT_DHDataSet.V_DSPM);
            Program.bindingSourceCN = new BindingSource();
            Program.bindingSourceCN = BindingSourceDSPM;
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
