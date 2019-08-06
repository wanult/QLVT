namespace QLVT
{
    partial class FormKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnExitKho = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCNKho = new System.Windows.Forms.Label();
            this.dataSetQLVT = new QLVT.DataSetQLVT();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT.DataSetQLVTTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT.DataSetQLVTTableAdapters.TableAdapterManager();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxKho = new System.Windows.Forms.GroupBox();
            this.btnHuyKho = new System.Windows.Forms.Button();
            this.btnOKKho = new System.Windows.Forms.Button();
            this.txtMAKHO = new DevExpress.XtraEditors.TextEdit();
            this.txtTENKHO = new DevExpress.XtraEditors.TextEdit();
            this.txtDCKho = new DevExpress.XtraEditors.TextEdit();
            this.txtCNKHO = new DevExpress.XtraEditors.TextEdit();
            this.btnEditKho = new System.Windows.Forms.Button();
            this.qLVT_DHDataSet = new QLVT.QLVT_DHDataSet();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLVT.QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new QLVT.QLVT_DHDataSetTableAdapters.TableAdapterManager();
            this.cbxCNKho = new System.Windows.Forms.ComboBox();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDCKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNKHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemKho,
            this.btnXoaKho,
            this.btnSuaKho,
            this.btnLuuKho,
            this.btnRefreshKho,
            this.btnExitKho});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExitKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemKho
            // 
            this.btnThemKho.Caption = "Insert";
            this.btnThemKho.Id = 0;
            this.btnThemKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKho.ImageOptions.Image")));
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKho_ItemClick);
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.Caption = "Delete";
            this.btnXoaKho.Id = 1;
            this.btnXoaKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKho.ImageOptions.Image")));
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKho_ItemClick);
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.Caption = "Edit";
            this.btnSuaKho.Id = 2;
            this.btnSuaKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKho.ImageOptions.Image")));
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaKho_ItemClick);
            // 
            // btnLuuKho
            // 
            this.btnLuuKho.Caption = "Save";
            this.btnLuuKho.Enabled = false;
            this.btnLuuKho.Id = 3;
            this.btnLuuKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKho.ImageOptions.Image")));
            this.btnLuuKho.Name = "btnLuuKho";
            this.btnLuuKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuKho_ItemClick);
            // 
            // btnRefreshKho
            // 
            this.btnRefreshKho.Caption = "Refresh";
            this.btnRefreshKho.Id = 4;
            this.btnRefreshKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshKho.ImageOptions.Image")));
            this.btnRefreshKho.Name = "btnRefreshKho";
            this.btnRefreshKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshKho_ItemClick);
            // 
            // btnExitKho
            // 
            this.btnExitKho.Caption = "Exit ";
            this.btnExitKho.Id = 5;
            this.btnExitKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitKho.ImageOptions.Image")));
            this.btnExitKho.Name = "btnExitKho";
            this.btnExitKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExitKho_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(804, 67);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 579);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(804, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 67);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 512);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(804, 67);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 512);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxCNKho);
            this.panel1.Controls.Add(this.lbCNKho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 50);
            this.panel1.TabIndex = 4;
            // 
            // lbCNKho
            // 
            this.lbCNKho.AutoSize = true;
            this.lbCNKho.Location = new System.Drawing.Point(13, 17);
            this.lbCNKho.Name = "lbCNKho";
            this.lbCNKho.Size = new System.Drawing.Size(56, 13);
            this.lbCNKho.TabIndex = 0;
            this.lbCNKho.Text = "Chi Nhánh";
            // 
            // dataSetQLVT
            // 
            this.dataSetQLVT.DataSetName = "DataSetQLVT";
            this.dataSetQLVT.EnforceConstraints = false;
            this.dataSetQLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.dataSetQLVT;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DataSetQLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.bdsKho;
            this.khoGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khoGridControl.Location = new System.Drawing.Point(0, 117);
            this.khoGridControl.MainView = this.gridView1;
            this.khoGridControl.MenuManager = this.barManager1;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(804, 209);
            this.khoGridControl.TabIndex = 6;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gridView1.GridControl = this.khoGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.OptionsColumn.AllowEdit = false;
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // groupBoxKho
            // 
            this.groupBoxKho.Controls.Add(this.btnEditKho);
            this.groupBoxKho.Controls.Add(mACNLabel);
            this.groupBoxKho.Controls.Add(this.txtCNKHO);
            this.groupBoxKho.Controls.Add(dIACHILabel);
            this.groupBoxKho.Controls.Add(this.txtDCKho);
            this.groupBoxKho.Controls.Add(tENKHOLabel);
            this.groupBoxKho.Controls.Add(this.txtTENKHO);
            this.groupBoxKho.Controls.Add(mAKHOLabel);
            this.groupBoxKho.Controls.Add(this.txtMAKHO);
            this.groupBoxKho.Controls.Add(this.btnHuyKho);
            this.groupBoxKho.Controls.Add(this.btnOKKho);
            this.groupBoxKho.Enabled = false;
            this.groupBoxKho.Location = new System.Drawing.Point(0, 331);
            this.groupBoxKho.Name = "groupBoxKho";
            this.groupBoxKho.Size = new System.Drawing.Size(792, 220);
            this.groupBoxKho.TabIndex = 7;
            this.groupBoxKho.TabStop = false;
            this.groupBoxKho.Text = "Thông tin Kho";
            // 
            // btnHuyKho
            // 
            this.btnHuyKho.Location = new System.Drawing.Point(303, 153);
            this.btnHuyKho.Name = "btnHuyKho";
            this.btnHuyKho.Size = new System.Drawing.Size(75, 23);
            this.btnHuyKho.TabIndex = 1;
            this.btnHuyKho.Text = "Hủy";
            this.btnHuyKho.UseVisualStyleBackColor = true;
            this.btnHuyKho.Visible = false;
            this.btnHuyKho.Click += new System.EventHandler(this.btnHuyKho_Click);
            // 
            // btnOKKho
            // 
            this.btnOKKho.Location = new System.Drawing.Point(206, 153);
            this.btnOKKho.Name = "btnOKKho";
            this.btnOKKho.Size = new System.Drawing.Size(75, 23);
            this.btnOKKho.TabIndex = 0;
            this.btnOKKho.Text = "OK";
            this.btnOKKho.UseVisualStyleBackColor = true;
            this.btnOKKho.Visible = false;
            this.btnOKKho.Click += new System.EventHandler(this.btnOKKho_Click);
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(25, 49);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(47, 13);
            mAKHOLabel.TabIndex = 2;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "MAKHO", true));
            this.txtMAKHO.Enabled = false;
            this.txtMAKHO.Location = new System.Drawing.Point(78, 46);
            this.txtMAKHO.MenuManager = this.barManager1;
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(149, 20);
            this.txtMAKHO.TabIndex = 3;
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(21, 93);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(51, 13);
            tENKHOLabel.TabIndex = 4;
            tENKHOLabel.Text = "TENKHO:";
            // 
            // txtTENKHO
            // 
            this.txtTENKHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "TENKHO", true));
            this.txtTENKHO.Location = new System.Drawing.Point(78, 90);
            this.txtTENKHO.MenuManager = this.barManager1;
            this.txtTENKHO.Name = "txtTENKHO";
            this.txtTENKHO.Size = new System.Drawing.Size(149, 20);
            this.txtTENKHO.TabIndex = 5;
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(290, 49);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // txtDCKho
            // 
            this.txtDCKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "DIACHI", true));
            this.txtDCKho.Location = new System.Drawing.Point(356, 46);
            this.txtDCKho.MenuManager = this.barManager1;
            this.txtDCKho.Name = "txtDCKho";
            this.txtDCKho.Size = new System.Drawing.Size(212, 20);
            this.txtDCKho.TabIndex = 7;
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(290, 97);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(40, 13);
            mACNLabel.TabIndex = 8;
            mACNLabel.Text = "MACN:";
            // 
            // txtCNKHO
            // 
            this.txtCNKHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "MACN", true));
            this.txtCNKHO.Enabled = false;
            this.txtCNKHO.Location = new System.Drawing.Point(356, 90);
            this.txtCNKHO.MenuManager = this.barManager1;
            this.txtCNKHO.Name = "txtCNKHO";
            this.txtCNKHO.Size = new System.Drawing.Size(212, 20);
            this.txtCNKHO.TabIndex = 9;
            // 
            // btnEditKho
            // 
            this.btnEditKho.Location = new System.Drawing.Point(206, 162);
            this.btnEditKho.Name = "btnEditKho";
            this.btnEditKho.Size = new System.Drawing.Size(75, 23);
            this.btnEditKho.TabIndex = 10;
            this.btnEditKho.Text = "Edit";
            this.btnEditKho.UseVisualStyleBackColor = true;
            this.btnEditKho.Visible = false;
            this.btnEditKho.Click += new System.EventHandler(this.btnEditKho_Click);
            // 
            // qLVT_DHDataSet
            // 
            this.qLVT_DHDataSet.DataSetName = "QLVT_DHDataSet";
            this.qLVT_DHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.qLVT_DHDataSet;
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
            // cbxCNKho
            // 
            this.cbxCNKho.DataSource = this.v_DSPMBindingSource;
            this.cbxCNKho.DisplayMember = "description";
            this.cbxCNKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCNKho.FormattingEnabled = true;
            this.cbxCNKho.Location = new System.Drawing.Point(95, 14);
            this.cbxCNKho.Name = "cbxCNKho";
            this.cbxCNKho.Size = new System.Drawing.Size(235, 21);
            this.cbxCNKho.TabIndex = 2;
            this.cbxCNKho.ValueMember = "subscriber_server";
            this.cbxCNKho.SelectedIndexChanged += new System.EventHandler(this.cbxCNKho_SelectedIndexChanged);
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 579);
            this.Controls.Add(this.groupBoxKho);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKho";
            this.Text = "FormKho";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxKho.ResumeLayout(false);
            this.groupBoxKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDCKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNKHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemKho;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoaKho;
        private DevExpress.XtraBars.BarButtonItem btnSuaKho;
        private DevExpress.XtraBars.BarButtonItem btnLuuKho;
        private DevExpress.XtraBars.BarButtonItem btnRefreshKho;
        private DevExpress.XtraBars.BarButtonItem btnExitKho;
        private System.Windows.Forms.BindingSource bdsKho;
        private DataSetQLVT dataSetQLVT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCNKho;
        private DataSetQLVTTableAdapters.KhoTableAdapter khoTableAdapter;
        private DataSetQLVTTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBoxKho;
        private System.Windows.Forms.Button btnHuyKho;
        private System.Windows.Forms.Button btnOKKho;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.Button btnEditKho;
        private DevExpress.XtraEditors.TextEdit txtCNKHO;
        private DevExpress.XtraEditors.TextEdit txtDCKho;
        private DevExpress.XtraEditors.TextEdit txtTENKHO;
        private DevExpress.XtraEditors.TextEdit txtMAKHO;
        private QLVT_DHDataSet qLVT_DHDataSet;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private QLVT_DHDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbxCNKho;
    }
}