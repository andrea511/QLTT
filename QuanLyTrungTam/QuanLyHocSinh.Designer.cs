namespace QuanLyTrungTam
{
    partial class QuanLyHocSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbGioiTinh_Search = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbLop_Search = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTen_HocSinh_Search = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbMa_HocSinh_Search = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btTatCa = new System.Windows.Forms.Button();
            this.dgDanhsach = new System.Windows.Forms.DataGridView();
            this.SoThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_HocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_HocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btChiTiet = new System.Windows.Forms.Button();
            this.btThem_TaiKhoan = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.dgDayHoc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_LopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTen_HocSinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMa_HocSinh = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDayHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbGioiTinh_Search);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cbLop_Search);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txbTen_HocSinh_Search);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txbMa_HocSinh_Search);
            this.panel2.Controls.Add(this.btTimKiem);
            this.panel2.Controls.Add(this.btTatCa);
            this.panel2.Location = new System.Drawing.Point(14, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 242);
            this.panel2.TabIndex = 38;
            // 
            // cbGioiTinh_Search
            // 
            this.cbGioiTinh_Search.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh_Search.FormattingEnabled = true;
            this.cbGioiTinh_Search.Items.AddRange(new object[] {
            " ",
            "Nam",
            "Nữ"});
            this.cbGioiTinh_Search.Location = new System.Drawing.Point(108, 102);
            this.cbGioiTinh_Search.Name = "cbGioiTinh_Search";
            this.cbGioiTinh_Search.Size = new System.Drawing.Size(106, 28);
            this.cbGioiTinh_Search.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 21);
            this.label14.TabIndex = 34;
            this.label14.Text = "Giới tính";
            // 
            // cbLop_Search
            // 
            this.cbLop_Search.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop_Search.FormattingEnabled = true;
            this.cbLop_Search.Items.AddRange(new object[] {
            " ",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbLop_Search.Location = new System.Drawing.Point(108, 145);
            this.cbLop_Search.Name = "cbLop_Search";
            this.cbLop_Search.Size = new System.Drawing.Size(106, 28);
            this.cbLop_Search.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 21);
            this.label15.TabIndex = 32;
            this.label15.Text = "Lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tên học sinh";
            // 
            // txbTen_HocSinh_Search
            // 
            this.txbTen_HocSinh_Search.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen_HocSinh_Search.Location = new System.Drawing.Point(108, 59);
            this.txbTen_HocSinh_Search.Name = "txbTen_HocSinh_Search";
            this.txbTen_HocSinh_Search.Size = new System.Drawing.Size(171, 28);
            this.txbTen_HocSinh_Search.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "Mã học sinh";
            // 
            // txbMa_HocSinh_Search
            // 
            this.txbMa_HocSinh_Search.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMa_HocSinh_Search.Location = new System.Drawing.Point(108, 16);
            this.txbMa_HocSinh_Search.Name = "txbMa_HocSinh_Search";
            this.txbMa_HocSinh_Search.Size = new System.Drawing.Size(171, 28);
            this.txbMa_HocSinh_Search.TabIndex = 1;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(108, 198);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(79, 38);
            this.btTimKiem.TabIndex = 5;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btTatCa
            // 
            this.btTatCa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTatCa.Location = new System.Drawing.Point(195, 198);
            this.btTatCa.Name = "btTatCa";
            this.btTatCa.Size = new System.Drawing.Size(83, 38);
            this.btTatCa.TabIndex = 6;
            this.btTatCa.Text = "Tất cả";
            this.btTatCa.UseVisualStyleBackColor = true;
            this.btTatCa.Click += new System.EventHandler(this.btTatCa_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDanhsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDanhsach.ColumnHeadersHeight = 40;
            this.dgDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThuTu,
            this.Ma_HocSinh,
            this.Ten_HocSinh,
            this.NgaySinh,
            this.GioiTinh,
            this.SDT,
            this.LopHoc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDanhsach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDanhsach.GridColor = System.Drawing.Color.White;
            this.dgDanhsach.Location = new System.Drawing.Point(14, 264);
            this.dgDanhsach.Name = "dgDanhsach";
            this.dgDanhsach.ReadOnly = true;
            this.dgDanhsach.RowHeadersVisible = false;
            this.dgDanhsach.RowHeadersWidth = 60;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgDanhsach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDanhsach.RowTemplate.Height = 50;
            this.dgDanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDanhsach.Size = new System.Drawing.Size(1426, 659);
            this.dgDanhsach.TabIndex = 37;
            this.dgDanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDanhsach_CellClick_1);
            // 
            // SoThuTu
            // 
            this.SoThuTu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoThuTu.HeaderText = "STT";
            this.SoThuTu.MinimumWidth = 6;
            this.SoThuTu.Name = "SoThuTu";
            this.SoThuTu.ReadOnly = true;
            this.SoThuTu.Width = 70;
            // 
            // Ma_HocSinh
            // 
            this.Ma_HocSinh.HeaderText = "Mã học sinh";
            this.Ma_HocSinh.MinimumWidth = 6;
            this.Ma_HocSinh.Name = "Ma_HocSinh";
            this.Ma_HocSinh.ReadOnly = true;
            // 
            // Ten_HocSinh
            // 
            this.Ten_HocSinh.HeaderText = "Tên học sinh";
            this.Ten_HocSinh.MinimumWidth = 6;
            this.Ten_HocSinh.Name = "Ten_HocSinh";
            this.Ten_HocSinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 150;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 250;
            // 
            // LopHoc
            // 
            this.LopHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LopHoc.HeaderText = "Lớp";
            this.LopHoc.MinimumWidth = 6;
            this.LopHoc.Name = "LopHoc";
            this.LopHoc.ReadOnly = true;
            this.LopHoc.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btChiTiet);
            this.panel1.Controls.Add(this.btThem_TaiKhoan);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txbMatKhau);
            this.panel1.Controls.Add(this.btReset);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txbTenDangNhap);
            this.panel1.Controls.Add(this.dgDayHoc);
            this.panel1.Controls.Add(this.cbLop);
            this.panel1.Controls.Add(this.cbGioiTinh);
            this.panel1.Controls.Add(this.dtNgaySinh);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbTen_HocSinh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbDiaChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbSDT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbMa_HocSinh);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(323, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 242);
            this.panel1.TabIndex = 36;
            // 
            // btChiTiet
            // 
            this.btChiTiet.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChiTiet.Location = new System.Drawing.Point(845, 198);
            this.btChiTiet.Name = "btChiTiet";
            this.btChiTiet.Size = new System.Drawing.Size(80, 38);
            this.btChiTiet.TabIndex = 40;
            this.btChiTiet.Text = "Chi tiết";
            this.btChiTiet.UseVisualStyleBackColor = true;
            // 
            // btThem_TaiKhoan
            // 
            this.btThem_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem_TaiKhoan.Location = new System.Drawing.Point(934, 198);
            this.btThem_TaiKhoan.Name = "btThem_TaiKhoan";
            this.btThem_TaiKhoan.Size = new System.Drawing.Size(80, 38);
            this.btThem_TaiKhoan.TabIndex = 30;
            this.btThem_TaiKhoan.Text = "Thêm";
            this.btThem_TaiKhoan.UseVisualStyleBackColor = true;
            this.btThem_TaiKhoan.Click += new System.EventHandler(this.btThem_TaiKhoan_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(842, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 21);
            this.label16.TabIndex = 37;
            this.label16.Text = "Mật khẩu";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(962, 160);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(137, 28);
            this.txbMatKhau.TabIndex = 29;
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(1019, 198);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(80, 38);
            this.btReset.TabIndex = 36;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(406, 198);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(63, 38);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(346, 198);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(54, 38);
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(931, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 21);
            this.label12.TabIndex = 33;
            this.label12.Text = "Tải khoản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(883, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(962, 56);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(137, 28);
            this.txbID.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(842, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tên đăng nhập";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDangNhap.Location = new System.Drawing.Point(962, 107);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(137, 28);
            this.txbTenDangNhap.TabIndex = 28;
            // 
            // dgDayHoc
            // 
            this.dgDayHoc.AllowUserToAddRows = false;
            this.dgDayHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDayHoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDayHoc.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDayHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDayHoc.ColumnHeadersHeight = 32;
            this.dgDayHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ma_LopHoc,
            this.Ten_MonHoc});
            this.dgDayHoc.Location = new System.Drawing.Point(500, 8);
            this.dgDayHoc.Name = "dgDayHoc";
            this.dgDayHoc.RowHeadersVisible = false;
            this.dgDayHoc.RowHeadersWidth = 51;
            this.dgDayHoc.RowTemplate.Height = 24;
            this.dgDayHoc.Size = new System.Drawing.Size(321, 224);
            this.dgDayHoc.TabIndex = 26;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 70;
            // 
            // Ma_LopHoc
            // 
            this.Ma_LopHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ma_LopHoc.HeaderText = "Lớp";
            this.Ma_LopHoc.MinimumWidth = 6;
            this.Ma_LopHoc.Name = "Ma_LopHoc";
            this.Ma_LopHoc.Width = 120;
            // 
            // Ten_MonHoc
            // 
            this.Ten_MonHoc.HeaderText = "Môn học";
            this.Ten_MonHoc.MinimumWidth = 6;
            this.Ten_MonHoc.Name = "Ten_MonHoc";
            // 
            // cbLop
            // 
            this.cbLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbLop.Location = new System.Drawing.Point(363, 121);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(106, 28);
            this.cbLop.TabIndex = 12;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(220, 90);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(66, 28);
            this.cbGioiTinh.TabIndex = 9;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "";
            this.dtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(369, 87);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(100, 28);
            this.dtNgaySinh.TabIndex = 10;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(278, 198);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(63, 38);
            this.btThem.TabIndex = 15;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(78, 208);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(192, 28);
            this.txbEmail.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên học sinh";
            // 
            // txbTen_HocSinh
            // 
            this.txbTen_HocSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen_HocSinh.Location = new System.Drawing.Point(220, 53);
            this.txbTen_HocSinh.Name = "txbTen_HocSinh";
            this.txbTen_HocSinh.Size = new System.Drawing.Size(250, 28);
            this.txbTen_HocSinh.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa chỉ";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(78, 140);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(192, 28);
            this.txbDiaChi.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "SĐT";
            // 
            // txbSDT
            // 
            this.txbSDT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDT.Location = new System.Drawing.Point(78, 174);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(192, 28);
            this.txbSDT.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã học sinh";
            // 
            // txbMa_HocSinh
            // 
            this.txbMa_HocSinh.Enabled = false;
            this.txbMa_HocSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMa_HocSinh.Location = new System.Drawing.Point(220, 16);
            this.txbMa_HocSinh.Name = "txbMa_HocSinh";
            this.txbMa_HocSinh.Size = new System.Drawing.Size(250, 28);
            this.txbMa_HocSinh.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 28);
            this.textBox1.TabIndex = 41;
            // 
            // QuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgDanhsach);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyHocSinh";
            this.Size = new System.Drawing.Size(1455, 938);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDayHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbGioiTinh_Search;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbLop_Search;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbTen_HocSinh_Search;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbMa_HocSinh_Search;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btTatCa;
        private System.Windows.Forms.DataGridView dgDanhsach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.DataGridView dgDayHoc;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTen_HocSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbMa_HocSinh;
        private System.Windows.Forms.Button btThem_TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_HocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopHoc;
        public System.Windows.Forms.Button btChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_LopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_MonHoc;
        private System.Windows.Forms.TextBox textBox1;
    }
}
