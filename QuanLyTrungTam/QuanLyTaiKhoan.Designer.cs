namespace QuanLyTrungTam
{
    partial class QuanLyTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgDanhsach = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai_TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txbID1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txbTenDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnXacNhan = new System.Windows.Forms.Panel();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMatKhau_XN = new System.Windows.Forms.TextBox();
            this.txbTenDangNhap_XN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsach)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnXacNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDanhsach
            // 
            this.dgDanhsach.AllowUserToAddRows = false;
            this.dgDanhsach.AllowUserToResizeRows = false;
            this.dgDanhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDanhsach.BackgroundColor = System.Drawing.Color.White;
            this.dgDanhsach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDanhsach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDanhsach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDanhsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDanhsach.ColumnHeadersHeight = 30;
            this.dgDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenDangNhap,
            this.Loai_TaiKhoan});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDanhsach.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgDanhsach.GridColor = System.Drawing.Color.White;
            this.dgDanhsach.Location = new System.Drawing.Point(87, 97);
            this.dgDanhsach.Name = "dgDanhsach";
            this.dgDanhsach.ReadOnly = true;
            this.dgDanhsach.RowHeadersVisible = false;
            this.dgDanhsach.RowHeadersWidth = 60;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgDanhsach.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDanhsach.RowTemplate.Height = 50;
            this.dgDanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDanhsach.Size = new System.Drawing.Size(784, 810);
            this.dgDanhsach.TabIndex = 34;
            this.dgDanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDanhsach_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            // 
            // Loai_TaiKhoan
            // 
            this.Loai_TaiKhoan.HeaderText = "Loại tài khoản";
            this.Loai_TaiKhoan.Name = "Loai_TaiKhoan";
            this.Loai_TaiKhoan.ReadOnly = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(390, 43);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(110, 33);
            this.btTimKiem.TabIndex = 42;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // txbID1
            // 
            this.txbID1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID1.Location = new System.Drawing.Point(90, 43);
            this.txbID1.Name = "txbID1";
            this.txbID1.Size = new System.Drawing.Size(294, 33);
            this.txbID1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbThongBao);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.cbLoai);
            this.panel2.Controls.Add(this.txbMa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbMatKhau);
            this.panel2.Controls.Add(this.txbTenDN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(948, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 481);
            this.panel2.TabIndex = 43;
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(235, 386);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(253, 22);
            this.lbThongBao.TabIndex = 52;
            this.lbThongBao.Text = "Vui lòng xác nhận quyền admin";
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(443, 427);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 40);
            this.btXoa.TabIndex = 51;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(239, 427);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(176, 40);
            this.btSua.TabIndex = 50;
            this.btSua.Text = "Đổi mật khẩu";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã HS/GV";
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(89, 427);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(90, 40);
            this.btLuu.TabIndex = 36;
            this.btLuu.Text = "Thêm";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // cbLoai
            // 
            this.cbLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Quản lý",
            "Giáo viên",
            "Học sinh"});
            this.cbLoai.Location = new System.Drawing.Point(239, 276);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(294, 30);
            this.cbLoai.TabIndex = 48;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // txbMa
            // 
            this.txbMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMa.Location = new System.Drawing.Point(239, 338);
            this.txbMa.Name = "txbMa";
            this.txbMa.Size = new System.Drawing.Size(294, 30);
            this.txbMa.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Loại tài khoản";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(239, 214);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(294, 30);
            this.txbMatKhau.TabIndex = 41;
            // 
            // txbTenDN
            // 
            this.txbTenDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDN.Location = new System.Drawing.Point(239, 152);
            this.txbTenDN.Name = "txbTenDN";
            this.txbTenDN.Size = new System.Drawing.Size(294, 30);
            this.txbTenDN.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tên đăng nhập";
            // 
            // txbID
            // 
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbID.Enabled = false;
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(239, 90);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(294, 23);
            this.txbID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "ID";
            // 
            // pnXacNhan
            // 
            this.pnXacNhan.BackColor = System.Drawing.Color.White;
            this.pnXacNhan.Controls.Add(this.btXacNhan);
            this.pnXacNhan.Controls.Add(this.label9);
            this.pnXacNhan.Controls.Add(this.txbMatKhau_XN);
            this.pnXacNhan.Controls.Add(this.txbTenDangNhap_XN);
            this.pnXacNhan.Controls.Add(this.label7);
            this.pnXacNhan.Controls.Add(this.label8);
            this.pnXacNhan.Location = new System.Drawing.Point(948, 596);
            this.pnXacNhan.Name = "pnXacNhan";
            this.pnXacNhan.Size = new System.Drawing.Size(622, 311);
            this.pnXacNhan.TabIndex = 44;
            // 
            // btXacNhan
            // 
            this.btXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan.Location = new System.Drawing.Point(239, 249);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(159, 40);
            this.btXacNhan.TabIndex = 51;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 26);
            this.label9.TabIndex = 46;
            this.label9.Text = "Xác nhận quyền admin";
            // 
            // txbMatKhau_XN
            // 
            this.txbMatKhau_XN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau_XN.Location = new System.Drawing.Point(239, 168);
            this.txbMatKhau_XN.Name = "txbMatKhau_XN";
            this.txbMatKhau_XN.PasswordChar = '*';
            this.txbMatKhau_XN.Size = new System.Drawing.Size(294, 30);
            this.txbMatKhau_XN.TabIndex = 45;
            // 
            // txbTenDangNhap_XN
            // 
            this.txbTenDangNhap_XN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDangNhap_XN.Location = new System.Drawing.Point(239, 106);
            this.txbTenDangNhap_XN.Name = "txbTenDangNhap_XN";
            this.txbTenDangNhap_XN.Size = new System.Drawing.Size(294, 30);
            this.txbTenDangNhap_XN.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tên đăng nhập";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnXacNhan);
            this.Controls.Add(this.txbID1);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgDanhsach);
            this.Name = "QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(1663, 938);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnXacNhan.ResumeLayout(false);
            this.pnXacNhan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDanhsach;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txbID1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.TextBox txbTenDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_TaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Panel pnXacNhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMatKhau_XN;
        private System.Windows.Forms.TextBox txbTenDangNhap_XN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbThongBao;
    }
}
