namespace QLVT
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btDX = new DevExpress.XtraBars.BarButtonItem();
            this.btNV = new DevExpress.XtraBars.BarButtonItem();
            this.btVT = new DevExpress.XtraBars.BarButtonItem();
            this.btKho = new DevExpress.XtraBars.BarButtonItem();
            this.btDDH = new DevExpress.XtraBars.BarButtonItem();
            this.ntPN = new DevExpress.XtraBars.BarButtonItem();
            this.btPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSVT = new DevExpress.XtraBars.BarButtonItem();
            this.btBKDN = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.rp_ddhchuacopn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.NV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.VT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.KHO = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DDH = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PN = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PX = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTenNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbNhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btDX,
            this.btNV,
            this.btVT,
            this.btKho,
            this.btDDH,
            this.ntPN,
            this.btPX,
            this.btnDSNV,
            this.btnDSVT,
            this.btBKDN,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15,
            this.rp_ddhchuacopn,
            this.barButtonItem17,
            this.barButtonItem18});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonHeThong,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btDX
            // 
            this.btDX.Caption = "Đăng Xuất";
            this.btDX.Id = 1;
            this.btDX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btDX.ImageOptions.Image")));
            this.btDX.Name = "btDX";
            this.btDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btDX_ItemClick);
            // 
            // btNV
            // 
            this.btNV.Caption = "NHÂN VIÊN";
            this.btNV.Id = 2;
            this.btNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btNV.ImageOptions.Image")));
            this.btNV.Name = "btNV";
            this.btNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btNV_ItemClick);
            // 
            // btVT
            // 
            this.btVT.Caption = "VẬT TƯ";
            this.btVT.Id = 3;
            this.btVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btVT.ImageOptions.Image")));
            this.btVT.Name = "btVT";
            this.btVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btVT_ItemClick);
            // 
            // btKho
            // 
            this.btKho.Caption = "KHO";
            this.btKho.Id = 4;
            this.btKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btKho.ImageOptions.Image")));
            this.btKho.Name = "btKho";
            this.btKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btKho_ItemClick);
            // 
            // btDDH
            // 
            this.btDDH.Caption = "ĐƠN ĐẶT HÀNG";
            this.btDDH.Id = 5;
            this.btDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btDDH.ImageOptions.Image")));
            this.btDDH.Name = "btDDH";
            this.btDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btDDH_ItemClick);
            // 
            // ntPN
            // 
            this.ntPN.Caption = "PHIẾU NHẬP";
            this.ntPN.Id = 6;
            this.ntPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ntPN.ImageOptions.Image")));
            this.ntPN.Name = "ntPN";
            this.ntPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ntPN_ItemClick);
            // 
            // btPX
            // 
            this.btPX.Caption = "PHIẾU XUẤT";
            this.btPX.Id = 7;
            this.btPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btPX.ImageOptions.Image")));
            this.btPX.Name = "btPX";
            this.btPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btPX_ItemClick);
            // 
            // btnDSNV
            // 
            this.btnDSNV.Caption = "DS NHÂN VIÊN";
            this.btnDSNV.Id = 8;
            this.btnDSNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSNV.ImageOptions.Image")));
            this.btnDSNV.Name = "btnDSNV";
            // 
            // btnDSVT
            // 
            this.btnDSVT.Caption = "DS VẬT TƯ";
            this.btnDSVT.Id = 9;
            this.btnDSVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSVT.ImageOptions.Image")));
            this.btnDSVT.Name = "btnDSVT";
            // 
            // btBKDN
            // 
            this.btBKDN.Caption = "BẢNG KÊ HÀNG NHẬP";
            this.btBKDN.Id = 10;
            this.btBKDN.Name = "btBKDN";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "TÌNH HÌNH CỦA NHÂN VIÊN";
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "barButtonItem13";
            this.barButtonItem13.Id = 13;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "BẢNG KÊ HÀNG XUẤT";
            this.barButtonItem14.Id = 14;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "DSĐH CHƯA CÓ PN";
            this.barButtonItem15.Id = 15;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // rp_ddhchuacopn
            // 
            this.rp_ddhchuacopn.Caption = "DSĐĐH CHƯA CÓ PN";
            this.rp_ddhchuacopn.Id = 16;
            this.rp_ddhchuacopn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rp_ddhchuacopn.ImageOptions.Image")));
            this.rp_ddhchuacopn.Name = "rp_ddhchuacopn";
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "HĐ CỦA NV";
            this.barButtonItem17.Id = 17;
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Caption = "TỔNG HỢP NHẬP XUẤT";
            this.barButtonItem18.Id = 18;
            this.barButtonItem18.Name = "barButtonItem18";
            // 
            // ribbonHeThong
            // 
            this.ribbonHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonHeThong.Name = "ribbonHeThong";
            this.ribbonHeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btDX);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.NV,
            this.VT,
            this.KHO,
            this.DDH,
            this.PN,
            this.PX});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh Mục";
            // 
            // NV
            // 
            this.NV.ItemLinks.Add(this.btNV);
            this.NV.Name = "NV";
            // 
            // VT
            // 
            this.VT.ItemLinks.Add(this.btVT);
            this.VT.Name = "VT";
            // 
            // KHO
            // 
            this.KHO.ItemLinks.Add(this.btKho);
            this.KHO.Name = "KHO";
            // 
            // DDH
            // 
            this.DDH.ItemLinks.Add(this.btDDH);
            this.DDH.Name = "DDH";
            // 
            // PN
            // 
            this.PN.ItemLinks.Add(this.ntPN);
            this.PN.Name = "PN";
            // 
            // PX
            // 
            this.PX.ItemLinks.Add(this.btPX);
            this.PX.Name = "PX";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Báo Cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDSNV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSVT);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.rp_ddhchuacopn);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMaNV,
            this.lbTenNV,
            this.lbNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbMaNV
            // 
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(49, 17);
            this.lbMaNV.Text = "Mã NV: ";
            // 
            // lbTenNV
            // 
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(51, 17);
            this.lbTenNV.Text = "Tên NV: ";
            // 
            // lbNhom
            // 
            this.lbNhom.Name = "lbNhom";
            this.lbNhom.Size = new System.Drawing.Size(47, 17);
            this.lbNhom.Text = "Nhóm: ";
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Vật Tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btDX;
        private DevExpress.XtraBars.BarButtonItem btNV;
        private DevExpress.XtraBars.BarButtonItem btVT;
        private DevExpress.XtraBars.BarButtonItem btKho;
        private DevExpress.XtraBars.BarButtonItem btDDH;
        private DevExpress.XtraBars.BarButtonItem ntPN;
        private DevExpress.XtraBars.BarButtonItem btPX;
        private DevExpress.XtraBars.BarButtonItem btnDSNV;
        private DevExpress.XtraBars.BarButtonItem btnDSVT;
        private DevExpress.XtraBars.BarButtonItem btBKDN;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem rp_ddhchuacopn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup NV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup VT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup KHO;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DDH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PN;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PX;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbMaNV;
        private System.Windows.Forms.ToolStripStatusLabel lbTenNV;
        private System.Windows.Forms.ToolStripStatusLabel lbNhom;
    }
}

