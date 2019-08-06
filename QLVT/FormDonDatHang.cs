using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDonDatHang : Form
    {
        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSMVT.V_LAYMAVT' table. You can move, or remove it, as needed.
            this.v_LAYMAVTTableAdapter.Fill(this.dSMVT.V_LAYMAVT);
            // TODO: This line of code loads data into the 'dSMK.SP_LAYMAKHO' table. You can move, or remove it, as needed.
            this.sP_LAYMAKHOTableAdapter.Fill(this.dSMK.SP_LAYMAKHO);
            // TODO: This line of code loads data into the 'dataSetQLVT.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTDDHTableAdapter.Fill(this.dataSetQLVT.CTDDH);
            // TODO: This line of code loads data into the 'dataSetQLVT.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.datHangTableAdapter.Fill(this.dataSetQLVT.DatHang);
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_DHDataSet.V_DSPM);
            
            if (Program.userGroup == "CONGTY")
            {
                btnThemDDH.Enabled = btnXoaDDH.Enabled  = btnLuuDDH.Enabled = btnRefreshDDH.Enabled 
                    = groupBoxDH.Enabled = groupBoxCTDH.Enabled  = false;
                ccbxCNDDH.Enabled = true;
                groupBoxbtnCTDDH.Visible = false;
            }
            else
            {
               
                ccbxCNDDH.Enabled = groupBoxDH.Enabled  = groupBoxCTDH.Enabled = false;
                btnThemDDH.Enabled = btnXoaDDH.Enabled  = btnLuuDDH.Enabled = btnRefreshDDH.Enabled 
                     = true;
                groupBoxbtnCTDDH.Visible = true;

            }
            if (Program.mChinhanh == 0)
            {
                ccbxCNDDH.SelectedItem = ccbxCNDDH.Items[0];
            }
            else
            {
                ccbxCNDDH.SelectedItem = ccbxCNDDH.Items[1];
            }
        }

        private void ccbxCNDDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ccbxCNDDH.SelectedValue != null)
            {
                if (ccbxCNDDH.ValueMember != "")
                {
                    if (Program.server != ccbxCNDDH.SelectedValue.ToString())
                    {
                        Program.server = ccbxCNDDH.SelectedValue.ToString();
                    }
                    if (ccbxCNDDH.SelectedIndex != Program.mChinhanh)
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

                        this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.datHangTableAdapter.Fill(this.dataSetQLVT.DatHang);
                        this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.cTDDHTableAdapter.Fill(this.dataSetQLVT.CTDDH);
                    }

                }
            }
        }

        private void btnExitDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefreshDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.datHangTableAdapter.Fill(this.dataSetQLVT.DatHang);
            groupBoxDH.Enabled = groupBoxCTDH.Enabled  = false;
            
            datHangGridControl.Enabled =cTDDHGridControl.Enabled = true;
        }

        private void btnThemDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDH.AddNew();
            groupBoxDH.Enabled = true;
            txtNgay.DateTime = DateTime.Now;
            string temp = DateTime.Now.ToString("d");
            txtNgay.Enabled = false;
            txtMANVDDH.Text = Program.userId;
            
            btnThemDDH.Enabled = btnXoaDDH.Enabled = btnLuuDDH.Enabled = btnRefreshDDH.Enabled=
            cTDDHGridControl.Enabled = groupBoxCTDH.Enabled  = false;
            
            btnOK.Visible = true;
            btnHuy.Visible = true;
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đặt hàng không được để trống!");
                txtMaDDH.Focus();
            }
            else if (txtNCC.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống!");
                txtNCC.Focus();
            }
            else if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống!");
                txtMaKho.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaDatHang] " +
                        "@MADDH = N'" + txtMaDDH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã đặt hàng đã tồn tại.Nhập lại.");
                    txtMaDDH.Focus();
                }
                else
                {
                    bdsDH.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsDH.ResetCurrentItem();
                    this.datHangTableAdapter.Update(this.dataSetQLVT.DatHang);
                    //groupBoxbtnCTDH.Visible = false;
                    btnOK.Visible = btnHuy.Visible = false;
                    groupBoxDH.Enabled = groupBoxCTDH.Enabled  = false;
                    btnThemDDH.Enabled = btnXoaDDH.Enabled = btnLuuDDH.Enabled = btnRefreshDDH.Enabled
                         = true;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.bdsDH.EndEdit();
            bdsDH.RemoveCurrent();
            btnOK.Visible = btnHuy.Visible  = false;
            groupBoxDH.Enabled = groupBoxCTDH.Enabled  = false;
            btnThemDDH.Enabled = btnXoaDDH.Enabled = btnLuuDDH.Enabled = btnRefreshDDH.Enabled 
             = cTDDHGridControl.Enabled    = true;

        }

        private void btnXoaDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemDDH.Enabled  =
                btnExitDDH.Enabled = btnRefreshDDH.Enabled =
                datHangGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa đặt hàng.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaDonDatHang] " +
                        "@MADDH = N'" + txtMaDDH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Đơn đặt hàng đã tồn tại trong chi tiết đơn đặt hàng.Không thể xóa.");
                    return;
                }
                else
                {
                    groupBoxDH.Enabled = false;
                    bdsDH.RemoveCurrent();
                    bdsDH.EndEdit();
                }
            }
            else
            {
                btnThemDDH.Enabled = btnXoaDDH.Enabled = btnLuuDDH.Enabled = btnRefreshDDH.Enabled = true;

            }
        }

        private void btnLuuDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.datHangTableAdapter.Update(this.dataSetQLVT.DatHang);
            groupBoxDH.Enabled = btnHuy.Visible  = btnOK.Visible = false;
            btnThemDDH.Enabled = btnXoaDDH.Enabled = btnLuuDDH.Enabled = btnRefreshDDH.Enabled = true;
            datHangGridControl.Enabled = true;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            this.cTDDHTableAdapter.Fill(this.dataSetQLVT.CTDDH);
            groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;
            btnOkCT.Visible = btnHuyCT.Visible = false;
            datHangGridControl.Enabled = cTDDHGridControl.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled =
                btnXoa.Enabled = btnTaiLai.Enabled = cTDDHGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa chi tiết đơn đặt hàng.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaChiTietDonDatHang] " +
                        "@MADDH = N'" + txtMaDDH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Chi tiết đơn đặt hàng đã tồn tại trong phiếu nhập.Không thể xóa.");
                    return;
                }
                else
                {
                    groupBoxCTDH.Enabled = false;
                    bdsCTDDH.RemoveCurrent();
                    bdsCTDDH.EndEdit();
                    this.cTDDHTableAdapter.Update(this.dataSetQLVT.CTDDH);
                }
            }
            else
            {
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = true;

            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            this.bdsCTDDH.EndEdit();
            bdsCTDDH.RemoveCurrent();
            btnOkCT.Visible = btnHuyCT.Visible = false;
            groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;
            btnThem.Visible = btnXoa.Visible = btnTaiLai.Visible = true;
            datHangGridControl.Enabled = cTDDHGridControl.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bdsCTDDH.AddNew();
            groupBoxCTDH.Enabled = true;
            txtMaCTDDH.Text = txtMaDDH.Text;
            btnThem.Visible = btnXoa.Visible = btnTaiLai.Visible = datHangGridControl.Enabled = false;
            btnOkCT.Visible = true;
            btnHuyCT.Visible = true;
        }

        private void btnOkCT_Click(object sender, EventArgs e)
        {
            if (txtMaCTDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đặt hàng không được để trống!");
                txtMaCTDDH.Focus();
            }
            else if (txtMaVTDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được để trống!");
                txtMaVTDH.Focus();
            }
            else if (txtSLDDH.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được để trống!");
                txtSLDDH.Focus();
                
            }
            else if (txtDGDDH.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá không được để trống!");
                txtDGDDH.Focus();
               
            }
            
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaCTDDH] " +
            "@MADDH = N'" + txtMaDDH.Text + "', "+" @MAVT = N'" + txtMaVTDH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Chi tiết đặt hàng đã tồn tại.Nhập lại.");
                    txtMaDDH.Focus();
                }
                else
                {
                    bdsCTDDH.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsCTDDH.ResetCurrentItem();
                    this.cTDDHTableAdapter.Update(this.dataSetQLVT.CTDDH);
                    btnOkCT.Visible = btnHuyCT.Visible = false;
                    groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;
                    btnThem.Visible = btnXoa.Visible = btnTaiLai.Visible = true;
                }
            }
        }
    }
}
