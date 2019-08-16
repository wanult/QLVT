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
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        
        string macn = "";
        string Macn = "";
        public FormNhanVien()
        {
            InitializeComponent();
            Program.server = "MYPC\\SERVER_1";
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.BindingSourceNhanVien.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSetMain);

        }
        public void ShowAll()
        {
            btnLuuNV.Enabled = btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled =
                btnExitNV.Enabled = btnCCN.Enabled = btnTaoLogin.Enabled = btnRefreshNV.Enabled =
                nhanVienGridControl.Enabled =true;
            groupBoxNV.Enabled = false;
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_DHDataSet.V_DSPM);
            // TODO: This line of code loads data into the 'dataSetQLVT.NhanVien' table. You can move, or remove it, as needed.

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Fill(this.dataSetQLVT.NhanVien);
           

            macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            if (Program.userGroup == "CONGTY")
            {
                btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnLuuNV.Enabled
                    = btnRefreshNV.Enabled = btnCCN.Enabled = false;
                cbxCN.Enabled = true;
            }
            else
            {
                cbxCN.Enabled = false;
                ShowAll();
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

        private void cbxCN_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void btnExitNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefreshNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dataSetQLVT.NhanVien);
                groupBoxNV.Enabled = false;
                btnEdit.Visible = btnOKNV.Visible = btnHuyNV.Visible = false;
                nhanVienGridControl.Enabled = true;
                ShowAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBoxNV.Enabled = true;
            btnThemNV.Enabled = btnSuaNV.Enabled = btnXoaNV.Enabled = btnRefreshNV.Enabled 
                = btnExitNV.Enabled =btnCCN.Enabled= nhanVienGridControl.Enabled = false;
            btnLuuNV.Enabled = true;
            btnTaoLogin.Enabled = false;
            txtMANV.Enabled = false;
            txtMACN.Enabled = false;
            txtTrangThaiXoa.Enabled = false;
            btnEdit.Visible = true;
            btnHuyNV.Visible = true;
        }

        private void btnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bdsNV.AddNew();
            groupBoxNV.Enabled = true;

            txtMACN.Text = macn;
            txtTrangThaiXoa.EditValue = "0";

            btnThemNV.Enabled = btnCCN.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnExitNV.Enabled
            = btnRefreshNV.Enabled = nhanVienGridControl.Enabled = btnTaoLogin.Enabled = false;
            btnLuuNV.Enabled = true;
            txtMACN.Enabled = false;
            txtTrangThaiXoa.Enabled = false;
            txtLUONG.EditValue = "4000000";
            txtLUONG.Enabled = false;
            btnOKNV.Visible = true;
            btnHuyNV.Visible = true;
            btnEdit.Visible = false;
        }

        private void nhanVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLVT);

        }

        private void descriptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
                        
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.nhanVienTableAdapter.Fill(this.dataSetQLVT.NhanVien);
                        macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
                    }

                }
            }
        }

        private void btnOKNV_Click(object sender, EventArgs e)
        {
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!");
                txtMANV.Focus();
            }
            else if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!");
                txtTEN.Focus();
            }
            else if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống!");
                txtHO.Focus();
            }
            else if (txtNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh nhân viên không được để trống!");
                txtNgaySinh.Focus();
            }
            else if (txtDC.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống!");
                txtDC.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaNhanVien] " +
                        "@MANV = N'" + txtMANV.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại.Nhập lại.");
                    txtMANV.Focus();
                }
                else
                {
                    bdsNV.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsNV.ResetCurrentItem();
                    this.nhanVienTableAdapter.Update(this.dataSetQLVT.NhanVien);
                    ShowAll();
                }
            }
        }

        private void btnLuuNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Update(this.dataSetQLVT.NhanVien);
            btnHuyNV.Visible = btnEdit.Visible = btnOKNV.Visible = false;
            ShowAll();
        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemNV.Enabled  = btnSuaNV.Enabled =
                btnExitNV.Enabled = btnCCN.Enabled = btnTaoLogin.Enabled = btnRefreshNV.Enabled =
                nhanVienGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa nhân viên.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaNhanVien] " +
                        "@MANV = N'" + txtMANV.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại trong phiếu nhập,phiếu xuất hay đặt hàng.Không thể xóa.");
                    return;
                }
                else
                {
                    groupBoxNV.Enabled = false;
                    txtTrangThaiXoa.Text = "1";
                    bdsNV.EndEdit();
                }             
            }
            else
            {
                ShowAll();
            }
        }

        private void btnHuyNV_Click(object sender, EventArgs e)
        {
            this.bdsNV.EndEdit();
            btnOKNV.Visible = btnHuyNV.Visible = btnEdit.Visible = false;
            ShowAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.bdsNV.EndEdit();
            this.nhanVienTableAdapter.Update(this.dataSetQLVT.NhanVien);
            btnOKNV.Visible = btnHuyNV.Visible = btnEdit.Visible = false;
            ShowAll();
        }

        private void btnCCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTrangThaiXoa.Text = "1";
            bdsNV.EndEdit();
            this.nhanVienTableAdapter.Update(this.dataSetQLVT.NhanVien);
            SqlDataReader myReader1;
            String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_MaxMaNV] " +
                        "@temp = N'" + 0 + "' SELECT  'Return Value' = @return_value";
            myReader1 = Program.ExecSqlDataReader(strlenh1);

            if (myReader1 == null) return;

            myReader1.Read();
            int value1 = myReader1.GetInt32(0);
            int manv = value1 + 1;
            myReader1.Close();
            if (Program.mChinhanh == 0)
            {
                Program.server = "MYPC\\SERVER_2";
                Macn ="CN2";
            }
            else
            {
                Program.server = "MYPC\\SERVER_1";
                Macn = "CN1";
            }
            Program.userName = Program.remoteLogin;
            Program.password = Program.remotePassword;
            if (Program.Connect() == false)
            {
                MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                return;
            }
            else
            {

                nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;

                string ngaysinh = txtNgaySinh.Text;
                DateTime dt = Convert.ToDateTime(ngaysinh);

                SqlDataReader myReader2;

                string lenh = "EXEC  sp_CHUYENCHINHANH " +
                                manv + ",'" +
                                txtHO.Text + "','" +
                                txtTEN.Text + "','" +
                                txtDC.Text + "','" +
                                dt + "','" +
                                txtLUONG.Text + "','" +
                                Macn + "'," +
                                0 + "";
                myReader2 = Program.ExecSqlDataReader(lenh);
                //if (myReader2 == null) return;
                //myReader2.Read();
                //myReader2.Close();
                Program.userName = Program.userNameHTai;
                Program.password = Program.passwordHTai;
                if (Program.mChinhanh == 0)
                {
                    Program.server = "MYPC\\SERVER_1";
                    Macn = "CN1";
                }
                else
                {
                    Program.server = "MYPC\\SERVER_2";
                    Macn = "CN2";
                }
                if (Program.Connect() == false)
                {
                    MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                    return;
                }
                nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                nhanVienTableAdapter.Fill(dataSetQLVT.NhanVien);
            }
        }

        private void btnTaoLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTaoLogin form = new FormTaoLogin();
            form.Show();
        }
    }
}