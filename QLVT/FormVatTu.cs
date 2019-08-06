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
    public partial class FormVatTu : DevExpress.XtraEditors.XtraForm
    {
        string macn = "";
        public FormVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLVT);

        }
        public void ShowAll()
        {
            btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = btnLuuVT.Enabled
                    = btnRefreshVT.Enabled = btnExitVT.Enabled = vattuGridControl.Enabled = true;
            groupBoxVT.Enabled = false;
        }
        private void FormVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_DHDataSet.V_DSPM);

            // TODO: This line of code loads data into the 'dataSetQLVT.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.vattuTableAdapter.Fill(this.dataSetQLVT.Vattu);
            if (Program.userGroup == "CONGTY")
            {
                btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = btnLuuVT.Enabled
                    = btnRefreshVT.Enabled = false;
                
            }
            else
            {
                btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = btnLuuVT.Enabled
                    = btnRefreshVT.Enabled = true;
            }
        }

        private void btnThemVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVT.AddNew();
            groupBoxVT.Enabled = true;

            btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = vattuGridControl.Enabled
                    = btnRefreshVT.Enabled = false;
            btnLuuVT.Enabled = true;
            txtDVT.Text = "Cái";
            btnOKVT.Visible = true;
            btnHuyVT.Visible = true;
            btnEditVT.Visible = false;
        }

        private void btnRefreshVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Fill(this.dataSetQLVT.Vattu);
                groupBoxVT.Enabled = false;
                vattuGridControl.Enabled = true;
                btnEditVT.Visible = btnOKVT.Visible = btnHuyVT.Visible = false;
                ShowAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnExitVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuuVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.vattuTableAdapter.Update(this.dataSetQLVT.Vattu);
            groupBoxVT.Enabled = btnHuyVT.Visible = btnEditVT.Visible = btnOKVT.Visible = false;
            btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = vattuGridControl.Enabled
                   = btnRefreshVT.Enabled =btnExitVT.Enabled= true;
        }

        private void btnXoaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemVT.Enabled = btnSuaVT.Enabled =
                btnExitVT.Enabled = btnRefreshVT.Enabled =
                vattuGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa vật tư.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaVatTu] " +
                        "@MAVT = N'" + txtMAVT.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã Vật tư đã tồn tại trong chi tiết phiếu nhập,phiếu xuất hay đặt hàng.Không thể xóa.");
                    return;
                }
                else
                {
                    groupBoxVT.Enabled = false;
                    bdsVT.RemoveCurrent();
                    bdsVT.EndEdit();
                }
            }
            else
            {
                btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = btnLuuVT.Enabled
                    = btnRefreshVT.Enabled = true;
            }
        }

        private void btnSuaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBoxVT.Enabled = true;
            btnThemVT.Enabled = btnSuaVT.Enabled = btnXoaVT.Enabled = btnRefreshVT.Enabled
                = btnExitVT.Enabled  = vattuGridControl.Enabled = false;
            btnLuuVT.Enabled = true;
            txtMAVT.Enabled = false;
            btnEditVT.Visible = true;
            btnHuyVT.Visible = true;
            btnOKVT.Visible = false;
        }

        private void btnHuyVT_Click(object sender, EventArgs e)
        {
            this.bdsVT.EndEdit();
            ShowAll();
        }

        private void btnEditVT_Click(object sender, EventArgs e)
        {
            this.bdsVT.EndEdit();
            this.vattuTableAdapter.Update(this.dataSetQLVT.Vattu);
            btnOKVT.Visible = btnHuyVT.Visible = btnEditVT.Visible = false;
            ShowAll();
        }

        private void btnOKVT_Click(object sender, EventArgs e)
        {
            if (txtMAVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được để trống!");
                txtMAVT.Focus();
            }
            else if (txtTENVT.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được để trống!");
                txtTENVT.Focus();
            }
            else if (txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống!");
                txtDVT.Focus();
            }
            else if (txtSLT.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng tồn không được để trống!");
                txtSLT.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaVatTu] " +
                        "@MAVT = N'" + txtMAVT.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã vật tư đã tồn tại.Nhập lại.");
                    txtMAVT.Focus();
                }
                else
                {
                    bdsVT.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsVT.ResetCurrentItem();
                    this.vattuTableAdapter.Update(this.dataSetQLVT.Vattu);
                    btnOKVT.Visible = btnHuyVT.Visible = btnEditVT.Visible = false;
                    ShowAll();
                }
            }
        }
    }
}