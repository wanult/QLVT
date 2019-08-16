namespace QLVT
{
    partial class FormTaoLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCN = new System.Windows.Forms.ComboBox();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DHDataSet = new QLVT.QLVT_DHDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.v_DSNVCHUACOLOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSNV = new QLVT.DSNV();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassCF = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v_DSNVCHUACOLOGINTableAdapter = new QLVT.DSNVTableAdapters.V_DSNVCHUACOLOGINTableAdapter();
            this.tableAdapterManager = new QLVT.DSNVTableAdapters.TableAdapterManager();
            this.v_DSNVCHUACOLOGINGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_DSPMTableAdapter = new QLVT.QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new QLVT.QLVT_DHDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNVCHUACOLOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNVCHUACOLOGINGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxCN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 63);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chi Nhánh";
            // 
            // cbxCN
            // 
            this.cbxCN.DataSource = this.v_DSPMBindingSource;
            this.cbxCN.DisplayMember = "description";
            this.cbxCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCN.FormattingEnabled = true;
            this.cbxCN.Location = new System.Drawing.Point(189, 19);
            this.cbxCN.Name = "cbxCN";
            this.cbxCN.Size = new System.Drawing.Size(230, 21);
            this.cbxCN.TabIndex = 0;
            this.cbxCN.ValueMember = "subscriber_server";
            this.cbxCN.SelectedIndexChanged += new System.EventHandler(this.cbxCN_SelectedIndexChanged);
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.qLVT_DHDataSet;
            // 
            // qLVT_DHDataSet
            // 
            this.qLVT_DHDataSet.DataSetName = "QLVT_DHDataSet";
            this.qLVT_DHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPassCF);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.cbNhom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMK);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 325);
            this.panel2.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.v_DSNVCHUACOLOGINBindingSource, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(369, 106);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(173, 20);
            this.txtMaNV.TabIndex = 23;
            // 
            // v_DSNVCHUACOLOGINBindingSource
            // 
            this.v_DSNVCHUACOLOGINBindingSource.DataMember = "V_DSNVCHUACOLOGIN";
            this.v_DSNVCHUACOLOGINBindingSource.DataSource = this.dSNV;
            // 
            // dSNV
            // 
            this.dSNV.DataSetName = "DSNV";
            this.dSNV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Xác nhận mật khẩu";
            // 
            // txtPassCF
            // 
            this.txtPassCF.Location = new System.Drawing.Point(369, 193);
            this.txtPassCF.Name = "txtPassCF";
            this.txtPassCF.PasswordChar = '*';
            this.txtPassCF.Size = new System.Drawing.Size(173, 21);
            this.txtPassCF.TabIndex = 21;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(467, 286);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(369, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbNhom
            // 
            this.cbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Location = new System.Drawing.Point(369, 242);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(173, 21);
            this.cbNhom.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã NV";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(369, 151);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(173, 21);
            this.txtMK.TabIndex = 12;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(369, 64);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(173, 21);
            this.txtTen.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // v_DSNVCHUACOLOGINTableAdapter
            // 
            this.v_DSNVCHUACOLOGINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSNVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_DSNVCHUACOLOGINGridControl
            // 
            this.v_DSNVCHUACOLOGINGridControl.DataSource = this.v_DSNVCHUACOLOGINBindingSource;
            this.v_DSNVCHUACOLOGINGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_DSNVCHUACOLOGINGridControl.Location = new System.Drawing.Point(0, 63);
            this.v_DSNVCHUACOLOGINGridControl.MainView = this.gridView1;
            this.v_DSNVCHUACOLOGINGridControl.Name = "v_DSNVCHUACOLOGINGridControl";
            this.v_DSNVCHUACOLOGINGridControl.Size = new System.Drawing.Size(825, 212);
            this.v_DSNVCHUACOLOGINGridControl.TabIndex = 3;
            this.v_DSNVCHUACOLOGINGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.v_DSNVCHUACOLOGINGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.OptionsColumn.AllowEdit = false;
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.OptionsColumn.AllowEdit = false;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.QLVT_DHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(825, 600);
            this.Controls.Add(this.v_DSNVCHUACOLOGINGridControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormTaoLogin";
            this.Text = "FormTaoLogin";
            this.Load += new System.EventHandler(this.FormTaoLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNVCHUACOLOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNVCHUACOLOGINGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DSNV dSNV;
        private System.Windows.Forms.BindingSource v_DSNVCHUACOLOGINBindingSource;
        private DSNVTableAdapters.V_DSNVCHUACOLOGINTableAdapter v_DSNVCHUACOLOGINTableAdapter;
        private DSNVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl v_DSNVCHUACOLOGINGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVT_DHDataSet qLVT_DHDataSet;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private QLVT_DHDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassCF;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
    }
}