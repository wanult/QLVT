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
    public partial class FormTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoLogin()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTaoLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_DHDataSet.V_DSPM);
            // TODO: This line of code loads data into the 'dSNV.V_DSNVCHUACOLOGIN' table. You can move, or remove it, as needed.
            this.v_DSNVCHUACOLOGINTableAdapter.Fill(this.dSNV.V_DSNVCHUACOLOGIN);

            txtMaNV.Enabled = false;
            if (Program.userGroup == "CONGTY")
            {
                cbNhom.Items.Add("CONGTY");
            }
            else
            {
                cbNhom.Items.Add("CHINHANH");
                cbNhom.Items.Add("USER");
            }
            if (Program.mChinhanh == 0)
            {
                cbxCN.SelectedItem = cbxCN.Items[0];
            }
            else
            {
                cbxCN.SelectedItem = cbxCN.Items[1];
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtTen.Focus();
            }
            else if (txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtMK.Focus();
            }
            else if (txtPassCF.Text.Trim() == "")
            {
                MessageBox.Show("Xác nhận khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtPassCF.Focus();
            }
            else if (cbNhom.Text.Trim() == "")
            {
                MessageBox.Show("Nhóm quyên không được để trống. Kiểm tra lại !!!", "Thông báo");
            }
            else if (txtMK.Text.Equals(txtPassCF.Text) == false)
            {
                MessageBox.Show("Mật khẩu phải trùng nhau. Kiểm tra lại !!!", "Thông báo");
            }
            else
            {
                if (Program.Connect() == false)
                {
                    return;
                }
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_TAOLOGIN] " +
                        "@LGNAME = N'" + txtTen.Text + "'," + "@PASS = N'" + txtMK.Text + "'," +
                        "@USERNAME = N'" + txtMaNV.Text + "'," + "@ROLE = N'" + cbNhom.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;
 
                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1 || value1 == 2)
                {
                    MessageBox.Show("UserName bị trùng.");
                    return;
                }
                else if(value1 == 0)
                {
                    MessageBox.Show("THANH CONG");

                    txtTen.Text = txtMK.Text = txtPassCF.Text = cbNhom.Text = "";
                    this.v_DSNVCHUACOLOGINTableAdapter.Fill(this.dSNV.V_DSNVCHUACOLOGIN);
                }

            }
        }

        private void cbxCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCN.SelectedValue != null)
            {
                if (cbxCN.ValueMember != "")
                {
                    if (Program.server != cbxCN.SelectedValue.ToString())
                    {
                        Program.server = cbxCN.SelectedValue.ToString();
                    }
                    if (cbxCN.SelectedIndex != Program.mChinhanh)
                    {
                        Program.userName = Program.remoteLogin;
                        Program.password = Program.remotePassword;
                    }
                    else
                    {
                        Program.userName = Program.userNameHTai;
                        Program.password = Program.passwordHTai;
                    }
                    if (Program.Connect() == false)
                    {
                        MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {

                        this.v_DSNVCHUACOLOGINTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.v_DSNVCHUACOLOGINTableAdapter.Fill(this.dSNV.V_DSNVCHUACOLOGIN);
                    }

                }
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}