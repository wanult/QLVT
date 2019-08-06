namespace QLVT
{
    partial class FormXuatHang
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAPXLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXuatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCNPX = new System.Windows.Forms.ComboBox();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DHDataSet = new QLVT.QLVT_DHDataSet();
            this.v_DSPMTableAdapter = new QLVT.QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DHDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxCTPX = new System.Windows.Forms.GroupBox();
            this.btnThemCTPX = new System.Windows.Forms.Button();
            this.groupBoxPX = new System.Windows.Forms.GroupBox();
            this.btnXoaPX = new System.Windows.Forms.Button();
            this.btnThemPX = new System.Windows.Forms.Button();
            this.dataSetQLVT = new QLVT.DataSetQLVT();
            this.tableAdapterManager1 = new QLVT.DataSetQLVTTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new QLVT.DataSetQLVTTableAdapters.CTPXTableAdapter();
            this.phieuXuatTableAdapter = new QLVT.DataSetQLVTTableAdapters.PhieuXuatTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cTPXGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuXuatGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxCT = new System.Windows.Forms.GroupBox();
            this.txtSL = new DevExpress.XtraEditors.SpinEdit();
            this.btnHuyCT = new System.Windows.Forms.Button();
            this.btnOKCT = new System.Windows.Forms.Button();
            this.txtDG = new DevExpress.XtraEditors.TextEdit();
            this.txtMAVT = new System.Windows.Forms.ComboBox();
            this.vDSVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVT = new QLVT.DSVT();
            this.txtMaPXCT = new DevExpress.XtraEditors.TextEdit();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnHuyPX = new System.Windows.Forms.Button();
            this.btnOKPX = new System.Windows.Forms.Button();
            this.txtMaKho = new System.Windows.Forms.ComboBox();
            this.sPLAYMAKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMK = new QLVT.DSMK();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.txtKH = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPX = new DevExpress.XtraEditors.TextEdit();
            this.vLAYMAVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMVT = new QLVT.DSMVT();
            this.sP_LAYMAKHOTableAdapter = new QLVT.DSMKTableAdapters.SP_LAYMAKHOTableAdapter();
            this.v_LAYMAVTTableAdapter = new QLVT.DSMVTTableAdapters.V_LAYMAVTTableAdapter();
            this.v_DSVTTableAdapter = new QLVT.DSVTTableAdapters.V_DSVTTableAdapter();
            descriptionLabel = new System.Windows.Forms.Label();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAPXLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxCTPX.SuspendLayout();
            this.groupBoxPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLVT)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBoxCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPXCT.Properties)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYMAKHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLAYMAVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVT)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(25, 13);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(56, 14);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Chi Nhánh";
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(23, 18);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(39, 14);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "MAPX:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(23, 56);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(39, 14);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(4, 93);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(58, 14);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "HOTENKH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(21, 129);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 14);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(12, 167);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(48, 14);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAPXLabel1
            // 
            mAPXLabel1.AutoSize = true;
            mAPXLabel1.Location = new System.Drawing.Point(52, 37);
            mAPXLabel1.Name = "mAPXLabel1";
            mAPXLabel1.Size = new System.Drawing.Size(39, 14);
            mAPXLabel1.TabIndex = 0;
            mAPXLabel1.Text = "MAPX:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(52, 77);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(38, 14);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(30, 119);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(61, 14);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(41, 164);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(50, 14);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnReload,
            this.btnExit});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(228, 151);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải Lại";
            this.btnReload.Id = 1;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 2;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(881, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(881, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(881, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 521);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.cbxCNPX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 40);
            this.panel1.TabIndex = 4;
            // 
            // cbxCNPX
            // 
            this.cbxCNPX.DataSource = this.v_DSPMBindingSource;
            this.cbxCNPX.DisplayMember = "description";
            this.cbxCNPX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCNPX.FormattingEnabled = true;
            this.cbxCNPX.Location = new System.Drawing.Point(94, 10);
            this.cbxCNPX.Name = "cbxCNPX";
            this.cbxCNPX.Size = new System.Drawing.Size(183, 22);
            this.cbxCNPX.TabIndex = 1;
            this.cbxCNPX.ValueMember = "subscriber_server";
            this.cbxCNPX.SelectedIndexChanged += new System.EventHandler(this.cbxCNPX_SelectedIndexChanged);
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
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxCTPX);
            this.panel2.Controls.Add(this.groupBoxPX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 44);
            this.panel2.TabIndex = 5;
            // 
            // groupBoxCTPX
            // 
            this.groupBoxCTPX.Controls.Add(this.btnThemCTPX);
            this.groupBoxCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCTPX.Location = new System.Drawing.Point(654, 0);
            this.groupBoxCTPX.Name = "groupBoxCTPX";
            this.groupBoxCTPX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxCTPX.Size = new System.Drawing.Size(227, 44);
            this.groupBoxCTPX.TabIndex = 1;
            this.groupBoxCTPX.TabStop = false;
            // 
            // btnThemCTPX
            // 
            this.btnThemCTPX.Location = new System.Drawing.Point(70, 6);
            this.btnThemCTPX.Name = "btnThemCTPX";
            this.btnThemCTPX.Size = new System.Drawing.Size(75, 23);
            this.btnThemCTPX.TabIndex = 0;
            this.btnThemCTPX.Text = "Thêm";
            this.btnThemCTPX.UseVisualStyleBackColor = true;
            this.btnThemCTPX.Click += new System.EventHandler(this.btnThemCTPX_Click);
            // 
            // groupBoxPX
            // 
            this.groupBoxPX.Controls.Add(this.btnXoaPX);
            this.groupBoxPX.Controls.Add(this.btnThemPX);
            this.groupBoxPX.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPX.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPX.Name = "groupBoxPX";
            this.groupBoxPX.Size = new System.Drawing.Size(654, 44);
            this.groupBoxPX.TabIndex = 0;
            this.groupBoxPX.TabStop = false;
            // 
            // btnXoaPX
            // 
            this.btnXoaPX.Location = new System.Drawing.Point(139, 6);
            this.btnXoaPX.Name = "btnXoaPX";
            this.btnXoaPX.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPX.TabIndex = 1;
            this.btnXoaPX.Text = "Xóa";
            this.btnXoaPX.UseVisualStyleBackColor = true;
            this.btnXoaPX.Click += new System.EventHandler(this.btnXoaPX_Click);
            // 
            // btnThemPX
            // 
            this.btnThemPX.Location = new System.Drawing.Point(28, 6);
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.Size = new System.Drawing.Size(75, 23);
            this.btnThemPX.TabIndex = 0;
            this.btnThemPX.Text = "Thêm";
            this.btnThemPX.UseVisualStyleBackColor = true;
            this.btnThemPX.Click += new System.EventHandler(this.btnThemPX_Click);
            // 
            // dataSetQLVT
            // 
            this.dataSetQLVT.DataSetName = "DataSetQLVT";
            this.dataSetQLVT.EnforceConstraints = false;
            this.dataSetQLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.CTDDHTableAdapter = null;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager1.DatHangTableAdapter = null;
            this.tableAdapterManager1.KhoTableAdapter = null;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager1.UpdateOrder = QLVT.DataSetQLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VattuTableAdapter = null;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cTPXGridControl);
            this.panel3.Controls.Add(this.phieuXuatGridControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 159);
            this.panel3.TabIndex = 9;
            // 
            // cTPXGridControl
            // 
            this.cTPXGridControl.DataSource = this.bdsCTPX;
            this.cTPXGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPXGridControl.Location = new System.Drawing.Point(654, 0);
            this.cTPXGridControl.MainView = this.gridView2;
            this.cTPXGridControl.MenuManager = this.barManager1;
            this.cTPXGridControl.Name = "cTPXGridControl";
            this.cTPXGridControl.Size = new System.Drawing.Size(227, 159);
            this.cTPXGridControl.TabIndex = 1;
            this.cTPXGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_PX";
            this.bdsCTPX.DataSource = this.bdsPX;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.dataSetQLVT;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cTPXGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPX1
            // 
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.OptionsColumn.AllowEdit = false;
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // phieuXuatGridControl
            // 
            this.phieuXuatGridControl.DataSource = this.bdsPX;
            this.phieuXuatGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.phieuXuatGridControl.Location = new System.Drawing.Point(0, 0);
            this.phieuXuatGridControl.MainView = this.gridView1;
            this.phieuXuatGridControl.MenuManager = this.barManager1;
            this.phieuXuatGridControl.Name = "phieuXuatGridControl";
            this.phieuXuatGridControl.Size = new System.Drawing.Size(654, 159);
            this.phieuXuatGridControl.TabIndex = 0;
            this.phieuXuatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.phieuXuatGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPX
            // 
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.OptionsColumn.AllowEdit = false;
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.OptionsColumn.AllowEdit = false;
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxCT);
            this.panel4.Controls.Add(this.groupBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(881, 226);
            this.panel4.TabIndex = 10;
            // 
            // groupBoxCT
            // 
            this.groupBoxCT.Controls.Add(this.txtSL);
            this.groupBoxCT.Controls.Add(this.btnHuyCT);
            this.groupBoxCT.Controls.Add(this.btnOKCT);
            this.groupBoxCT.Controls.Add(dONGIALabel);
            this.groupBoxCT.Controls.Add(this.txtDG);
            this.groupBoxCT.Controls.Add(sOLUONGLabel);
            this.groupBoxCT.Controls.Add(mAVTLabel);
            this.groupBoxCT.Controls.Add(this.txtMAVT);
            this.groupBoxCT.Controls.Add(mAPXLabel1);
            this.groupBoxCT.Controls.Add(this.txtMaPXCT);
            this.groupBoxCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCT.Location = new System.Drawing.Point(492, 0);
            this.groupBoxCT.Name = "groupBoxCT";
            this.groupBoxCT.Size = new System.Drawing.Size(389, 226);
            this.groupBoxCT.TabIndex = 1;
            this.groupBoxCT.TabStop = false;
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "SOLUONG", true));
            this.txtSL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSL.Location = new System.Drawing.Point(97, 116);
            this.txtSL.MenuManager = this.barManager1;
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSL.Size = new System.Drawing.Size(120, 20);
            this.txtSL.TabIndex = 11;
            this.txtSL.EditValueChanged += new System.EventHandler(this.txtSL_EditValueChanged);
            // 
            // btnHuyCT
            // 
            this.btnHuyCT.Location = new System.Drawing.Point(267, 77);
            this.btnHuyCT.Name = "btnHuyCT";
            this.btnHuyCT.Size = new System.Drawing.Size(75, 23);
            this.btnHuyCT.TabIndex = 9;
            this.btnHuyCT.Text = "Hủy";
            this.btnHuyCT.UseVisualStyleBackColor = true;
            this.btnHuyCT.Visible = false;
            this.btnHuyCT.Click += new System.EventHandler(this.btnHuyCT_Click);
            // 
            // btnOKCT
            // 
            this.btnOKCT.Location = new System.Drawing.Point(267, 27);
            this.btnOKCT.Name = "btnOKCT";
            this.btnOKCT.Size = new System.Drawing.Size(75, 23);
            this.btnOKCT.TabIndex = 8;
            this.btnOKCT.Text = "OK";
            this.btnOKCT.UseVisualStyleBackColor = true;
            this.btnOKCT.Visible = false;
            this.btnOKCT.Click += new System.EventHandler(this.btnOKCT_Click);
            // 
            // txtDG
            // 
            this.txtDG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "DONGIA", true));
            this.txtDG.Location = new System.Drawing.Point(97, 161);
            this.txtDG.MenuManager = this.barManager1;
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(120, 20);
            this.txtDG.TabIndex = 7;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "MAVT", true));
            this.txtMAVT.DataSource = this.vDSVTBindingSource;
            this.txtMAVT.DisplayMember = "MAVT";
            this.txtMAVT.FormattingEnabled = true;
            this.txtMAVT.Location = new System.Drawing.Point(96, 74);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(121, 22);
            this.txtMAVT.TabIndex = 3;
            this.txtMAVT.ValueMember = "MAVT";
            this.txtMAVT.SelectedIndexChanged += new System.EventHandler(this.txtMAVT_SelectedIndexChanged);
            // 
            // vDSVTBindingSource
            // 
            this.vDSVTBindingSource.DataMember = "V_DSVT";
            this.vDSVTBindingSource.DataSource = this.dSVT;
            // 
            // dSVT
            // 
            this.dSVT.DataSetName = "DSVT";
            this.dSVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaPXCT
            // 
            this.txtMaPXCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "MAPX", true));
            this.txtMaPXCT.Location = new System.Drawing.Point(97, 34);
            this.txtMaPXCT.MenuManager = this.barManager1;
            this.txtMaPXCT.Name = "txtMaPXCT";
            this.txtMaPXCT.Size = new System.Drawing.Size(120, 20);
            this.txtMaPXCT.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnHuyPX);
            this.groupBox.Controls.Add(this.btnOKPX);
            this.groupBox.Controls.Add(mAKHOLabel);
            this.groupBox.Controls.Add(this.txtMaKho);
            this.groupBox.Controls.Add(mANVLabel);
            this.groupBox.Controls.Add(this.txtMANV);
            this.groupBox.Controls.Add(hOTENKHLabel);
            this.groupBox.Controls.Add(this.txtKH);
            this.groupBox.Controls.Add(nGAYLabel);
            this.groupBox.Controls.Add(this.txtNgay);
            this.groupBox.Controls.Add(mAPXLabel);
            this.groupBox.Controls.Add(this.txtMaPX);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(492, 226);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // btnHuyPX
            // 
            this.btnHuyPX.Location = new System.Drawing.Point(243, 56);
            this.btnHuyPX.Name = "btnHuyPX";
            this.btnHuyPX.Size = new System.Drawing.Size(75, 23);
            this.btnHuyPX.TabIndex = 11;
            this.btnHuyPX.Text = "Hủy";
            this.btnHuyPX.UseVisualStyleBackColor = true;
            this.btnHuyPX.Visible = false;
            this.btnHuyPX.Click += new System.EventHandler(this.btnHuyPX_Click);
            // 
            // btnOKPX
            // 
            this.btnOKPX.Location = new System.Drawing.Point(243, 14);
            this.btnOKPX.Name = "btnOKPX";
            this.btnOKPX.Size = new System.Drawing.Size(75, 23);
            this.btnOKPX.TabIndex = 10;
            this.btnOKPX.Text = "OK";
            this.btnOKPX.UseVisualStyleBackColor = true;
            this.btnOKPX.Visible = false;
            this.btnOKPX.Click += new System.EventHandler(this.btnOKPX_Click);
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAKHO", true));
            this.txtMaKho.DataSource = this.sPLAYMAKHOBindingSource;
            this.txtMaKho.DisplayMember = "MAKHO";
            this.txtMaKho.FormattingEnabled = true;
            this.txtMaKho.Location = new System.Drawing.Point(66, 164);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(121, 22);
            this.txtMaKho.TabIndex = 9;
            this.txtMaKho.ValueMember = "MAKHO";
            // 
            // sPLAYMAKHOBindingSource
            // 
            this.sPLAYMAKHOBindingSource.DataMember = "SP_LAYMAKHO";
            this.sPLAYMAKHOBindingSource.DataSource = this.dSMK;
            // 
            // dSMK
            // 
            this.dSMK.DataSetName = "DSMK";
            this.dSMK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(68, 126);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(119, 20);
            this.txtMANV.TabIndex = 7;
            // 
            // txtKH
            // 
            this.txtKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "HOTENKH", true));
            this.txtKH.Location = new System.Drawing.Point(68, 90);
            this.txtKH.MenuManager = this.barManager1;
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(119, 20);
            this.txtKH.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(68, 53);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(119, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaPX
            // 
            this.txtMaPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAPX", true));
            this.txtMaPX.Location = new System.Drawing.Point(68, 15);
            this.txtMaPX.MenuManager = this.barManager1;
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(119, 20);
            this.txtMaPX.TabIndex = 1;
            // 
            // vLAYMAVTBindingSource
            // 
            this.vLAYMAVTBindingSource.DataMember = "V_LAYMAVT";
            this.vLAYMAVTBindingSource.DataSource = this.dSMVTBindingSource;
            // 
            // dSMVTBindingSource
            // 
            this.dSMVTBindingSource.DataSource = this.dSMVT;
            this.dSMVTBindingSource.Position = 0;
            // 
            // dSMVT
            // 
            this.dSMVT.DataSetName = "DSMVT";
            this.dSMVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LAYMAKHOTableAdapter
            // 
            this.sP_LAYMAKHOTableAdapter.ClearBeforeFill = true;
            // 
            // v_LAYMAVTTableAdapter
            // 
            this.v_LAYMAVTTableAdapter.ClearBeforeFill = true;
            // 
            // v_DSVTTableAdapter
            // 
            this.v_DSVTTableAdapter.ClearBeforeFill = true;
            // 
            // FormXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormXuatHang";
            this.Text = "FormXuatHang";
            this.Load += new System.EventHandler(this.FormXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoxCTPX.ResumeLayout(false);
            this.groupBoxPX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLVT)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTPXGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBoxCT.ResumeLayout(false);
            this.groupBoxCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPXCT.Properties)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYMAKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLAYMAVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLVT_DHDataSet qLVT_DHDataSet;
        private System.Windows.Forms.Panel panel1;
        private QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private QLVT_DHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxCNPX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxCTPX;
        private System.Windows.Forms.Button btnThemCTPX;
        private System.Windows.Forms.GroupBox groupBoxPX;
        private System.Windows.Forms.Button btnXoaPX;
        private System.Windows.Forms.Button btnThemPX;
        private DataSetQLVT dataSetQLVT;
        private DataSetQLVTTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DataSetQLVTTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource bdsPX;
        private DevExpress.XtraGrid.GridControl phieuXuatGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DataSetQLVTTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private System.Windows.Forms.GroupBox groupBoxCT;
        private System.Windows.Forms.GroupBox groupBox;
        private DevExpress.XtraGrid.GridControl cTPXGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.Button btnHuyCT;
        private System.Windows.Forms.Button btnOKCT;
        private DevExpress.XtraEditors.TextEdit txtDG;
        private System.Windows.Forms.ComboBox txtMAVT;
        private DevExpress.XtraEditors.TextEdit txtMaPXCT;
        private System.Windows.Forms.Button btnHuyPX;
        private System.Windows.Forms.Button btnOKPX;
        private System.Windows.Forms.ComboBox txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtKH;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtMaPX;
        private DSMK dSMK;
        private System.Windows.Forms.BindingSource sPLAYMAKHOBindingSource;
        private DSMKTableAdapters.SP_LAYMAKHOTableAdapter sP_LAYMAKHOTableAdapter;
        private System.Windows.Forms.BindingSource dSMVTBindingSource;
        private DSMVT dSMVT;
        private System.Windows.Forms.BindingSource vLAYMAVTBindingSource;
        private DSMVTTableAdapters.V_LAYMAVTTableAdapter v_LAYMAVTTableAdapter;
        private DSVT dSVT;
        private System.Windows.Forms.BindingSource vDSVTBindingSource;
        private DSVTTableAdapters.V_DSVTTableAdapter v_DSVTTableAdapter;
        private DevExpress.XtraEditors.SpinEdit txtSL;
    }
}