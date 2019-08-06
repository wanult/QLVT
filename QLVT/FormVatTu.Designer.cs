namespace QLVT
{
    partial class FormVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnExitVT = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DHDataSet = new QLVT.QLVT_DHDataSet();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLVT = new QLVT.DataSetQLVT();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT.DataSetQLVTTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT.DataSetQLVTTableAdapters.TableAdapterManager();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxVT = new System.Windows.Forms.GroupBox();
            this.btnEditVT = new System.Windows.Forms.Button();
            this.txtSLT = new DevExpress.XtraEditors.SpinEdit();
            this.txtDVT = new DevExpress.XtraEditors.TextEdit();
            this.txtTENVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.btnHuyVT = new System.Windows.Forms.Button();
            this.btnOKVT = new System.Windows.Forms.Button();
            this.v_DSPMTableAdapter = new QLVT.QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new QLVT.QLVT_DHDataSetTableAdapters.TableAdapterManager();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(11, 33);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(38, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(7, 71);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(42, 13);
            tENVTLabel.TabIndex = 4;
            tENVTLabel.Text = "TENVT:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(19, 108);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(30, 13);
            dVTLabel.TabIndex = 6;
            dVTLabel.Text = "DVT:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(223, 33);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(80, 13);
            sOLUONGTONLabel.TabIndex = 8;
            sOLUONGTONLabel.Text = "SOLUONGTON:";
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
            this.btnThemVT,
            this.btnXoaVT,
            this.btnSuaVT,
            this.btnLuuVT,
            this.btnRefreshVT,
            this.btnExitVT});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExitVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemVT
            // 
            this.btnThemVT.Caption = "Insert";
            this.btnThemVT.Id = 0;
            this.btnThemVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVT.ImageOptions.Image")));
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemVT_ItemClick);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Caption = "Delete";
            this.btnXoaVT.Id = 1;
            this.btnXoaVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaVT.ImageOptions.Image")));
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaVT_ItemClick);
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Caption = "Edit";
            this.btnSuaVT.Id = 2;
            this.btnSuaVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaVT.ImageOptions.Image")));
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaVT_ItemClick);
            // 
            // btnLuuVT
            // 
            this.btnLuuVT.Caption = "Save";
            this.btnLuuVT.Enabled = false;
            this.btnLuuVT.Id = 3;
            this.btnLuuVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuVT.ImageOptions.Image")));
            this.btnLuuVT.Name = "btnLuuVT";
            this.btnLuuVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuVT_ItemClick);
            // 
            // btnRefreshVT
            // 
            this.btnRefreshVT.Caption = "Refresh";
            this.btnRefreshVT.Id = 4;
            this.btnRefreshVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshVT.ImageOptions.Image")));
            this.btnRefreshVT.Name = "btnRefreshVT";
            this.btnRefreshVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshVT_ItemClick);
            // 
            // btnExitVT
            // 
            this.btnExitVT.Caption = "Exit";
            this.btnExitVT.Id = 5;
            this.btnExitVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitVT.ImageOptions.Image")));
            this.btnExitVT.Name = "btnExitVT";
            this.btnExitVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExitVT_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(802, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 479);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(802, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(802, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
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
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.qLVT_DHDataSet;
            // 
            // dataSetQLVT
            // 
            this.dataSetQLVT.DataSetName = "DataSetQLVT";
            this.dataSetQLVT.EnforceConstraints = false;
            this.dataSetQLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVT
            // 
            this.bdsVT.DataMember = "Vattu";
            this.bdsVT.DataSource = this.dataSetQLVT;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DataSetQLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.bdsVT;
            this.vattuGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vattuGridControl.Location = new System.Drawing.Point(0, 47);
            this.vattuGridControl.MainView = this.gridView1;
            this.vattuGridControl.MenuManager = this.barManager1;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(802, 241);
            this.vattuGridControl.TabIndex = 6;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.vattuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // groupBoxVT
            // 
            this.groupBoxVT.Controls.Add(this.btnEditVT);
            this.groupBoxVT.Controls.Add(sOLUONGTONLabel);
            this.groupBoxVT.Controls.Add(this.txtSLT);
            this.groupBoxVT.Controls.Add(dVTLabel);
            this.groupBoxVT.Controls.Add(this.txtDVT);
            this.groupBoxVT.Controls.Add(tENVTLabel);
            this.groupBoxVT.Controls.Add(this.txtTENVT);
            this.groupBoxVT.Controls.Add(mAVTLabel);
            this.groupBoxVT.Controls.Add(this.txtMAVT);
            this.groupBoxVT.Controls.Add(this.btnHuyVT);
            this.groupBoxVT.Controls.Add(this.btnOKVT);
            this.groupBoxVT.Enabled = false;
            this.groupBoxVT.Location = new System.Drawing.Point(0, 294);
            this.groupBoxVT.Name = "groupBoxVT";
            this.groupBoxVT.Size = new System.Drawing.Size(790, 179);
            this.groupBoxVT.TabIndex = 7;
            this.groupBoxVT.TabStop = false;
            this.groupBoxVT.Text = "Thông tin Vật Tư";
            // 
            // btnEditVT
            // 
            this.btnEditVT.Location = new System.Drawing.Point(241, 108);
            this.btnEditVT.Name = "btnEditVT";
            this.btnEditVT.Size = new System.Drawing.Size(75, 23);
            this.btnEditVT.TabIndex = 10;
            this.btnEditVT.Text = "Edit";
            this.btnEditVT.UseVisualStyleBackColor = true;
            this.btnEditVT.Visible = false;
            this.btnEditVT.Click += new System.EventHandler(this.btnEditVT_Click);
            // 
            // txtSLT
            // 
            this.txtSLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "SOLUONGTON", true));
            this.txtSLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSLT.Location = new System.Drawing.Point(309, 30);
            this.txtSLT.MenuManager = this.barManager1;
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSLT.Size = new System.Drawing.Size(100, 20);
            this.txtSLT.TabIndex = 9;
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "DVT", true));
            this.txtDVT.Location = new System.Drawing.Point(55, 105);
            this.txtDVT.MenuManager = this.barManager1;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(114, 20);
            this.txtDVT.TabIndex = 7;
            // 
            // txtTENVT
            // 
            this.txtTENVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "TENVT", true));
            this.txtTENVT.Location = new System.Drawing.Point(55, 68);
            this.txtTENVT.MenuManager = this.barManager1;
            this.txtTENVT.Name = "txtTENVT";
            this.txtTENVT.Size = new System.Drawing.Size(114, 20);
            this.txtTENVT.TabIndex = 5;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "MAVT", true));
            this.txtMAVT.Location = new System.Drawing.Point(55, 30);
            this.txtMAVT.MenuManager = this.barManager1;
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(114, 20);
            this.txtMAVT.TabIndex = 3;
            // 
            // btnHuyVT
            // 
            this.btnHuyVT.Location = new System.Drawing.Point(347, 102);
            this.btnHuyVT.Name = "btnHuyVT";
            this.btnHuyVT.Size = new System.Drawing.Size(75, 23);
            this.btnHuyVT.TabIndex = 1;
            this.btnHuyVT.Text = "Hủy";
            this.btnHuyVT.UseVisualStyleBackColor = true;
            this.btnHuyVT.Visible = false;
            this.btnHuyVT.Click += new System.EventHandler(this.btnHuyVT_Click);
            // 
            // btnOKVT
            // 
            this.btnOKVT.Location = new System.Drawing.Point(241, 102);
            this.btnOKVT.Name = "btnOKVT";
            this.btnOKVT.Size = new System.Drawing.Size(75, 23);
            this.btnOKVT.TabIndex = 0;
            this.btnOKVT.Text = "OK";
            this.btnOKVT.UseVisualStyleBackColor = true;
            this.btnOKVT.Visible = false;
            this.btnOKVT.Click += new System.EventHandler(this.btnOKVT_Click);
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
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 479);
            this.Controls.Add(this.groupBoxVT);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormVatTu";
            this.Text = "FormVatTu";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxVT.ResumeLayout(false);
            this.groupBoxVT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemVT;
        private DevExpress.XtraBars.BarButtonItem btnXoaVT;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSuaVT;
        private DevExpress.XtraBars.BarButtonItem btnLuuVT;
        private DevExpress.XtraBars.BarButtonItem btnRefreshVT;
        private DevExpress.XtraBars.BarButtonItem btnExitVT;
        private System.Windows.Forms.BindingSource bdsVT;
        private DataSetQLVT dataSetQLVT;
        private DataSetQLVTTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DataSetQLVTTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private System.Windows.Forms.GroupBox groupBoxVT;
        private System.Windows.Forms.Button btnHuyVT;
        private System.Windows.Forms.Button btnOKVT;
        private QLVT_DHDataSet qLVT_DHDataSet;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private QLVT_DHDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private System.Windows.Forms.Button btnEditVT;
        private DevExpress.XtraEditors.SpinEdit txtSLT;
        private DevExpress.XtraEditors.TextEdit txtDVT;
        private DevExpress.XtraEditors.TextEdit txtTENVT;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
    }
}