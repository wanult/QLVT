namespace QLVT
{
    partial class FormDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.qLVT_DHDataSet = new QLVT.QLVT_DHDataSet();
            this.v_DSPMTableAdapter1 = new QLVT.QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new QLVT.QLVT_DHDataSetTableAdapters.TableAdapterManager();
            this.BindingSourceDSPM = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDSPM = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceDSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(295, 186);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Đăng Nhập";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(385, 186);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click_1);
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(295, 88);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(165, 21);
            this.txtLoginName.TabIndex = 5;
            this.txtLoginName.Text = "lt";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(295, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 21);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "123";
            // 
            // qLVT_DHDataSet
            // 
            this.qLVT_DHDataSet.DataSetName = "QLVT_DHDataSet";
            this.qLVT_DHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMTableAdapter1
            // 
            this.v_DSPMTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.QLVT_DHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BindingSourceDSPM
            // 
            this.BindingSourceDSPM.DataMember = "V_DSPM";
            this.BindingSourceDSPM.DataSource = this.qLVT_DHDataSet;
            // 
            // cmbDSPM
            // 
            this.cmbDSPM.DataSource = this.BindingSourceDSPM;
            this.cmbDSPM.DisplayMember = "description";
            this.cmbDSPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDSPM.FormattingEnabled = true;
            this.cmbDSPM.Location = new System.Drawing.Point(295, 44);
            this.cmbDSPM.Name = "cmbDSPM";
            this.cmbDSPM.Size = new System.Drawing.Size(165, 21);
            this.cmbDSPM.TabIndex = 9;
            this.cmbDSPM.ValueMember = "subscriber_server";
            // 
            // FormDangNhap
            // 
            this.ClientSize = new System.Drawing.Size(591, 341);
            this.Controls.Add(this.cmbDSPM);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceDSPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCN;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMK;
       
        private System.Windows.Forms.BindingSource bds_DSPM;
        
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtPassword;
        private QLVT_DHDataSet qLVT_DHDataSet;
        private QLVT_DHDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter1;
        private QLVT_DHDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource BindingSourceDSPM;
        private System.Windows.Forms.ComboBox cmbDSPM;
    }
}