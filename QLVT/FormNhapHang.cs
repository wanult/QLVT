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
    public partial class FormNhapHang : Form
    {
        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSMK.SP_LAYMAKHO' table. You can move, or remove it, as needed.
            this.sP_LAYMAKHOTableAdapter.Fill(this.dSMK.SP_LAYMAKHO);
            // TODO: This line of code loads data into the 'dSDH.V_DSMADHCHUANHAP' table. You can move, or remove it, as needed.
            this.v_DSMADHCHUANHAPTableAdapter.Fill(this.dSDH.V_DSMADHCHUANHAP);
            // TODO: This line of code loads data into the 'dataSetQLVT.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPNTableAdapter.Fill(this.dataSetQLVT.CTPN);
            // TODO: This line of code loads data into the 'dataSetQLVT.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.dataSetQLVT.PhieuNhap);
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_DHDataSet.V_DSPM);

            if (Program.userGroup == "CONGTY")
            {
                btnThemPN.Enabled = btnXoaPN.Enabled  = btnReloadPN.Enabled
                    = groupBox.Enabled = groupBoxCT.Enabled = btnThemCTPN.Enabled  = false;
                cbxCNPN.Enabled = true;
            }
            else
            {

                cbxCNPN.Enabled = groupBox.Enabled = groupBoxCT.Enabled = false;
                btnThemPN.Enabled = btnXoaPN.Enabled  = btnReloadPN.Enabled = btnXoaPN.Enabled = btnThemCTPN.Enabled 
                     = true;

            }
            if (Program.mChinhanh == 0)
            {
                cbxCNPN.SelectedItem = cbxCNPN.Items[0];
            }
            else
            {
                cbxCNPN.SelectedItem = cbxCNPN.Items[1];
            }
        }

        private void btExitPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReloadPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.phieuNhapTableAdapter.Fill(this.dataSetQLVT.PhieuNhap);
            this.cTPNTableAdapter.Fill(this.dataSetQLVT.CTPN);
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemCTPN.Enabled =phieuNhapGridControl.Enabled = cTPNGridControl.Enabled = true;
        }

        private void cbxCNPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCNPN.SelectedValue != null)
            {
                if (cbxCNPN.ValueMember != "")
                {
                    if (Program.server != cbxCNPN.SelectedValue.ToString())
                    {
                        Program.server = cbxCNPN.SelectedValue.ToString();
                    }
                    if (cbxCNPN.SelectedIndex != Program.mChinhanh)
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

                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.phieuNhapTableAdapter.Fill(this.dataSetQLVT.PhieuNhap);
                        this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.cTPNTableAdapter.Fill(this.dataSetQLVT.CTPN);
                    }

                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.bdsPN.EndEdit();
            bdsPN.RemoveCurrent();
            btnOK.Visible = btnHuy.Visible = false;
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemPN.Enabled = btnXoaPN.Enabled = cTPNGridControl.Enabled = phieuNhapGridControl.Enabled = true;
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            this.bdsCTPN.EndEdit();
            bdsCTPN.RemoveCurrent();
            btnOKCT.Visible = btnHuyCT.Visible = false;
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemPN.Enabled = btnXoaPN.Enabled = true;
            btnThemCTPN.Enabled = phieuNhapGridControl.Enabled = cTPNGridControl.Enabled = true;
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            bdsPN.AddNew();
            groupBox.Enabled = true;
            txtNgay.DateTime = DateTime.Now;
            string temp = DateTime.Now.ToString("d");
            txtNgay.Enabled = false;
            txtMaNV.Text = Program.userId;

            SqlDataReader myReader1;
            String strlenh1 = "EXEC SP_MADHCHUACOPN";
            myReader1 = Program.ExecSqlDataReader(strlenh1);
            if (myReader1 == null) return;

            while (myReader1.Read())
            {
                txtMaDH.Items.Add(myReader1.GetString(0));
            }
            //txtMAVT.SelectedIndex = 0;

            myReader1.Close();



            btnThemPN.Enabled = btnXoaPN.Enabled = btnThemCTPN.Enabled  =
            cTPNGridControl.Enabled = groupBoxCT.Enabled = phieuNhapGridControl.Enabled = false;

            btnOK.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được để trống!");
                txtMaPN.Focus();
            }
            else if (txtMaDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đơn đặt hàng không được để trống!");
                txtMaDH.Focus();
            }
            else if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống!");
                txtMaKho.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaPhieuNhap] " +
                        "@MAPN = N'" + txtMaPN.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại.Nhập lại.");
                    txtMaPN.Focus();
                }
                else
                {
                    bdsPN.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsPN.ResetCurrentItem();
                    this.phieuNhapTableAdapter.Update(this.dataSetQLVT.PhieuNhap);
                    
                    btnOK.Visible = btnHuy.Visible = false;
                    groupBox.Enabled = groupBoxCT.Enabled = false;
                    btnThemPN.Enabled = btnXoaPN.Enabled = phieuNhapGridControl.Enabled = 
                        cTPNGridControl.Enabled = btnThemCTPN.Enabled =true;
                    txtMaDH.Items.Clear();
                    txtMaDH.Items.Add("");
                    txtMaDH.SelectedItem = 0;
                }
            }
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            btnThemPN.Enabled = phieuNhapGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa phiếu nhập.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaPhieuNhap] " +
                        "@MAPN = N'" + txtMaPN.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Phiếu nhập đã tồn tại trong chi tiết phiếu nhập.Không thể xóa.");
                    return;
                }
                else
                {
                    groupBox.Enabled = false;
                    bdsPN.RemoveCurrent();
                    bdsPN.EndEdit();
                    this.phieuNhapTableAdapter.Update(this.dataSetQLVT.PhieuNhap);
                }
            }
            else
            {
                btnThemPN.Enabled = btnXoaPN.Enabled   = true;

            }
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
                MessageBox.Show("Số lượng tồn không đủ để xuất hàng!");
                txtSL.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaCTPN] " +
            "@MAPN = N'" + txtMaPNCT.Text + "', " + " @MAVT = N'" + txtMAVT.Text + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);

                if (myReader == null) return;

                myReader.Read();
                int value1 = myReader.GetInt32(0);

                myReader.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Chi tiết phiếu nhập đã tồn tại.Nhập lại.");
                    txtMaPN.Focus();
                }
                else
                {
                    bdsCTPN.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsCTPN.ResetCurrentItem();
                    this.cTPNTableAdapter.Update(this.dataSetQLVT.CTPN);
                    btnOKCT.Visible = btnHuyCT.Visible = false;
                    groupBox.Enabled = groupBoxCT.Enabled = btnThemPN.Enabled = btnXoaPN.Enabled = false;
                    phieuNhapGridControl.Enabled = btnThemCTPN.Enabled = true;

                    
                    this.cTPNTableAdapter.Fill(this.dataSetQLVT.CTPN);


                    SqlDataReader myReader1;
                    String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_CAPNHATSOLUONGTON] " +
                "@MAVT = N'" + txtMAVT.Text + "', " + " @SL = N'" + Convert.ToInt32(temp) + "' SELECT  'Return Value' = @return_value";
                    myReader1 = Program.ExecSqlDataReader(strlenh1);
                    myReader1.Close();
                }
                
            }
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {

        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            bdsCTPN.AddNew();

            SqlDataReader myReader;
            String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_MAVTDADH] " +
            "@MaPN = N'" + txtMaPN.Text + "', " + " @MADDH = N'" + txtMaDH.Text + "' SELECT  'Return Value' = @return_value";

            myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;

            while (myReader.Read())
            {
                txtMAVT.Items.Add(myReader.GetString(0));
            }
            //txtMAVT.SelectedIndex = 0;

            myReader.Close();

            groupBoxCT.Enabled = true;
            txtMaPNCT.Text = txtMaPN.Text;
            btnThemCTPN.Enabled = phieuNhapGridControl.Enabled = btnThemPN.Enabled = btnXoaPN.Enabled = false;
            btnOKCT.Visible = true;
            btnHuyCT.Visible = true;
            
        }

        private void txtSL_EditValueChanged(object sender, EventArgs e)
        {

        }
        int SLT; Double DG;
        private void txtMAVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlDataReader myReader;
            String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_LAYSOLUONGDONGIACTPN] " +
            "@MAVT = N'" + txtMAVT.Text + "', " + " @MADDH = N'" + txtMaDH.Text + "' SELECT  'Return Value' = @return_value";
            myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            myReader.Read();
            try
            {
                SLT = myReader.GetInt32(0);
                txtSL.Text = Convert.ToString(SLT);
                DG = myReader.GetDouble(1);
                txtDG.Text = Convert.ToString(DG);
            }
            catch
            {

            }
            myReader.Close();
        }

        private void txtMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
