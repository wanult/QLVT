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
    public partial class FormXuatHang : Form
    {
        public FormXuatHang()
        {
            InitializeComponent();
        }

        private void FormXuatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSVT.V_DSVT' table. You can move, or remove it, as needed.
            this.v_DSVTTableAdapter.Fill(this.dSVT.V_DSVT);
            // TODO: This line of code loads data into the 'dSMVT.V_LAYMAVT' table. You can move, or remove it, as needed.
            this.v_LAYMAVTTableAdapter.Fill(this.dSMVT.V_LAYMAVT);
            // TODO: This line of code loads data into the 'dSMK.SP_LAYMAKHO' table. You can move, or remove it, as needed.
            this.sP_LAYMAKHOTableAdapter.Fill(this.dSMK.SP_LAYMAKHO);
            // TODO: This line of code loads data into the 'dataSetQLVT.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPXTableAdapter.Fill(this.dataSetQLVT.CTPX);
            // TODO: This line of code loads data into the 'dataSetQLVT.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuXuatTableAdapter.Fill(this.dataSetQLVT.PhieuXuat);
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_DHDataSet.V_DSPM);
            if (Program.userGroup == "CONGTY")
            {
                btnThemPX.Enabled = btnXoaPX.Enabled = btnReload.Enabled
                    = groupBox.Enabled = groupBoxCT.Enabled = btnThemCTPX.Enabled  = false;
                cbxCNPX.Enabled = true;
            }
            else
            {

                cbxCNPX.Enabled = groupBox.Enabled = groupBoxCT.Enabled = false;
                btnThemPX.Enabled = btnXoaPX.Enabled = btnReload.Enabled = btnXoaPX.Enabled = btnThemCTPX.Enabled
                   = true;

            }
            if (Program.mChinhanh == 0)
            {
                cbxCNPX.SelectedItem = cbxCNPX.Items[0];
            }
            else
            {
                cbxCNPX.SelectedItem = cbxCNPX.Items[1];
            }
        }

        private void cbxCNPX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCNPX.SelectedValue != null)
            {
                if (cbxCNPX.ValueMember != "")
                {
                    if (Program.server != cbxCNPX.SelectedValue.ToString())
                    {
                        Program.server = cbxCNPX.SelectedValue.ToString();
                    }
                    if (cbxCNPX.SelectedIndex != Program.mChinhanh)
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

                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.phieuXuatTableAdapter.Fill(this.dataSetQLVT.PhieuXuat);
                        this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.cTPXTableAdapter.Fill(this.dataSetQLVT.CTPX);
                    }
                }
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.phieuXuatTableAdapter.Fill(this.dataSetQLVT.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.dataSetQLVT.CTPX);
            groupBox.Enabled = groupBoxCT.Enabled = false;
            phieuXuatGridControl.Enabled = cTPXGridControl.Enabled = true;
        }

        private void btnHuyPX_Click(object sender, EventArgs e)
        {
            this.bdsPX.EndEdit();
            bdsPX.RemoveCurrent();
            btnOKPX.Visible = btnHuyPX.Visible = false;
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemPX.Enabled = btnXoaPX.Enabled = cTPXGridControl.Enabled = phieuXuatGridControl.Enabled = true;
        }

        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            btnThemPX.Enabled = phieuXuatGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa phiếu xuất.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaPhieuXuất] " +
                        "@MAPX = N'" + txtMaPX.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Phiếu xuất đã tồn tại trong chi tiết phiếu xuất.Không thể xóa.");
                    return;
                }
                else
                {
                    groupBox.Enabled = false;
                    bdsPX.RemoveCurrent();
                    bdsPX.EndEdit();
                }
            }
            else
            {
                btnThemPX.Enabled = btnXoaPX.Enabled = true;

            }
        }

        private void btnThemPX_Click(object sender, EventArgs e)
        {
            bdsPX.AddNew();
            groupBox.Enabled = true;
            txtNgay.DateTime = DateTime.Now;
            string temp = DateTime.Now.ToString("d");
            txtNgay.Enabled = false;
            txtMANV.Text = Program.userId;

            btnThemPX.Enabled = btnXoaPX.Enabled = btnThemCTPX.Enabled  =
            cTPXGridControl.Enabled = groupBoxCT.Enabled = phieuXuatGridControl.Enabled = false;

            btnOKPX.Visible = true;
            btnHuyPX.Visible = true;
        }

        private void btnOKPX_Click(object sender, EventArgs e)
        {
            if (txtMaPX.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu xuất không được để trống!");
                txtMaPX.Focus();
            }
            else if (txtKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống!");
                txtKH.Focus();
            }
            else if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống!");
                txtMaKho.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaPhieuXuat] " +
                        "@MAPX = N'" + txtMaPX.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã phiếu xuất đã tồn tại.Nhập lại.");
                    txtMaPX.Focus();
                }
                else
                {
                    bdsPX.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsPX.ResetCurrentItem();
                    this.phieuXuatTableAdapter.Update(this.dataSetQLVT.PhieuXuat);
                    btnOKPX.Visible = btnHuyPX.Visible = false;
                    groupBox.Enabled = groupBoxCT.Enabled = false;
                    btnThemPX.Enabled = btnXoaPX.Enabled = phieuXuatGridControl.Enabled =
                        cTPXGridControl.Enabled = true;
                }
            }
        }

        private void btnThemCTPX_Click(object sender, EventArgs e)
        {
            bdsCTPX.AddNew();
            groupBoxCT.Enabled = true;
            txtMaPXCT.Text = txtMaPX.Text;
            btnThemCTPX.Visible  = phieuXuatGridControl.Enabled = false;
            btnOKCT.Visible = true;
            btnHuyCT.Visible = true;
            groupBoxCT.Enabled = true;
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            this.bdsCTPX.EndEdit();
            bdsCTPX.RemoveCurrent();
            btnOKCT.Visible = btnHuyCT.Visible = false;
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemCTPX.Enabled  = cTPXGridControl.Enabled = phieuXuatGridControl.Enabled = true;
        }

        private void btnOKCT_Click(object sender, EventArgs e)
        {
            if (txtMAVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được để trống!");
                txtMAVT.Focus();
            }
            else if (txtSL.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được để trống!");
                txtSL.Focus();
            }
            else if (txtDG.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá không được để trống!");
                txtDG.Focus();

            }
            string temp = txtSL.Text;

            if (Convert.ToInt32(temp) > SLT)
            {
                MessageBox.Show("số lượng tồn không đủ để xuất hàng!");
                txtSL.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaCTPX] " +
            "@MADDH = N'" + txtMaPX.Text + "', " + " @MAVT = N'" + txtMAVT.Text + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);

                if (myReader == null) return;

                myReader.Read();
                int value1 = myReader.GetInt32(0);

                myReader.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Chi tiết phiếu xuất đã tồn tại.Nhập lại.");
                    txtMaPX.Focus();
                }
                else
                {
                    bdsCTPX.EndEdit();
                MessageBox.Show("Thành công!");
                bdsCTPX.ResetCurrentItem();
                this.cTPXTableAdapter.Update(this.dataSetQLVT.CTPX);
                btnOKCT.Visible = btnHuyCT.Visible = false;
                groupBox.Enabled = groupBoxCT.Enabled = false;
                phieuXuatGridControl.Enabled   = btnThemCTPX.Visible = true;
                }
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_CAPNHATSOLUONGTONGIAM] " +
            "@MAVT = N'" + txtMAVT.Text + "', " + " @SL = N'" + Convert.ToInt32(temp) + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);
            }
        }
        int SLT;
        private void txtMAVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader myReader;
            String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_SOLUONGTON] " +
                        "@MAVT = N'" + txtMAVT.Text + "' SELECT  'Return Value' = @return_value";
            myReader = Program.ExecSqlDataReader(strlenh1);
            if (myReader == null) return;
            myReader.Read();
            try
            {
                SLT = myReader.GetInt32(0);
                txtSL.Text = Convert.ToString(SLT);

            }
            catch
            {

            }
            myReader.Close();

        }

        private void txtSL_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
