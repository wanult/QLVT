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
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        string macn = "";
        public FormKho()
        {
            InitializeComponent();
            Program.server = "MYPC\\SERVER_1";
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLVT);

        }
        public void ShowAll()
        {
            btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = btnLuuKho.Enabled
                    = btnRefreshKho.Enabled = btnExitKho.Enabled = groupBoxKho.Enabled = true;
            khoGridControl.Enabled = true;
        }
        private void FormKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_DHDataSet.V_DSPM);
            // TODO: This line of code loads data into the 'dataSetQLVT.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.khoTableAdapter.Fill(this.dataSetQLVT.Kho);
            macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
            if (Program.userGroup == "CONGTY")
            {
                btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = btnLuuKho.Enabled
                    = btnRefreshKho.Enabled  = false;
                cbxCNKho.Enabled = true;
            }
            else
            {
                cbxCNKho.Enabled = false;
                btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = btnLuuKho.Enabled
                    = btnRefreshKho.Enabled = true;
            }
            if (Program.mChinhanh == 0)
            {
                cbxCNKho.SelectedItem = cbxCNKho.Items[0];
            }
            else
            {
                cbxCNKho.SelectedItem = cbxCNKho.Items[1];
            }
        }

        private void cbxCNKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCNKho.SelectedValue != null)
            {
                if (cbxCNKho.ValueMember != "")
                {
                    if (Program.server != cbxCNKho.SelectedValue.ToString())
                    {
                        Program.server = cbxCNKho.SelectedValue.ToString();
                    }
                    if (cbxCNKho.SelectedIndex != Program.mChinhanh)
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

                        this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.khoTableAdapter.Fill(this.dataSetQLVT.Kho);
                        macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
                    }

                }
            }
        }

        private void btnExitKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefreshKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.dataSetQLVT.Kho);
                groupBoxKho.Enabled = false;
                btnEditKho.Visible = btnOKKho.Visible = btnHuyKho.Visible = false;
                khoGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnLuuKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.khoTableAdapter.Update(this.dataSetQLVT.Kho);
             groupBoxKho.Enabled = btnHuyKho.Visible = btnEditKho.Visible = false;
            btnOKKho.Visible = false;
            btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = btnLuuKho.Enabled
                    = btnRefreshKho.Enabled = btnExitKho.Enabled = khoGridControl.Enabled = true;
        }

        private void btnSuaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBoxKho.Enabled = true;
            btnThemKho.Enabled = btnSuaKho.Enabled = btnXoaKho.Enabled = btnRefreshKho.Enabled
                = btnExitKho.Enabled  = khoGridControl.Enabled = false;
            btnLuuKho.Enabled = true;
            txtMAKHO.Enabled = txtCNKHO.Enabled = btnOKKho.Visible = false;
            btnEditKho.Visible = btnHuyKho.Visible = true;
        }

        private void btnThemKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKho.AddNew();
            groupBoxKho.Enabled = true;
            txtCNKHO.Text = macn;

            btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = khoGridControl.Enabled
                    = btnRefreshKho.Enabled = false;
            btnLuuKho.Enabled = true;
            btnOKKho.Visible = true;
            btnHuyKho.Visible = true;
            btnEditKho.Visible = false;
        }

        private void btnHuyKho_Click(object sender, EventArgs e)
        {
            this.bdsKho.EndEdit();
            btnEditKho.Visible = btnHuyKho.Visible = btnOKKho.Visible = false;
            ShowAll();
            return;
        }

        private void btnEditKho_Click(object sender, EventArgs e)
        {
            this.bdsKho.EndEdit();
            this.khoTableAdapter.Update(this.dataSetQLVT.Kho);
            btnOKKho.Visible = btnHuyKho.Visible = btnEditKho.Visible = false;
            ShowAll();
        }

        private void btnOKKho_Click(object sender, EventArgs e)
        {
            if (txtMAKHO.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống!");
                txtMAKHO.Focus();
            }
            else if (txtTENKHO.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được để trống!");
                txtTENKHO.Focus();
            }
            else if (txtDCKho.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ kho không được để trống!");
                txtDCKho.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaKho] " +
                        "@MAKHO = N'" + txtMAKHO.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã kho đã tồn tại.Nhập lại.");
                    txtMAKHO.Focus();
                }
                else
                {
                    bdsKho.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsKho.ResetCurrentItem();
                    this.khoTableAdapter.Update(this.dataSetQLVT.Kho);
                    btnEditKho.Visible = btnHuyKho.Visible = btnOKKho.Visible = false;
                    ShowAll();
                }
            }
        }

        private void btnXoaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemKho.Enabled = btnSuaKho.Enabled =
                btnExitKho.Enabled = btnRefreshKho.Enabled =
                khoGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa kho.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaKho] " +
                        "@MAKHO = N'" + txtMAKHO.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã kho đã tồn tại trong phiếu nhập,phiếu xuất hay đặt hàng.Không thể xóa.");
                    return;
                }
                else
                {
                    groupBoxKho.Enabled = false;
                    bdsKho.RemoveCurrent();
                    bdsKho.EndEdit();
                }
            }
            else
            {
                btnThemKho.Enabled = btnXoaKho.Enabled = btnSuaKho.Enabled = btnLuuKho.Enabled
                    = btnRefreshKho.Enabled = btnExitKho.Enabled = true;
            }
        }
    }
}