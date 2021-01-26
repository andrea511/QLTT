namespace QuanLyTrungTam
{
    partial class Mail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btChonEmail = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgSearchResult = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbGuiDen = new System.Windows.Forms.TextBox();
            this.rtxbNoiDung = new System.Windows.Forms.RichTextBox();
            this.btChonFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTieuDe = new System.Windows.Forms.TextBox();
            this.btGui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDangNhap_Email = new System.Windows.Forms.Button();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnGuiDen = new System.Windows.Forms.FlowLayoutPanel();
            this.pnFolder = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btThemEmail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchResult)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btChonEmail);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dgSearchResult);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(54, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 677);
            this.panel1.TabIndex = 0;
            // 
            // btChonEmail
            // 
            this.btChonEmail.Location = new System.Drawing.Point(368, 615);
            this.btChonEmail.Name = "btChonEmail";
            this.btChonEmail.Size = new System.Drawing.Size(104, 41);
            this.btChonEmail.TabIndex = 9;
            this.btChonEmail.Text = "Chọn";
            this.btChonEmail.UseVisualStyleBackColor = true;
            this.btChonEmail.Click += new System.EventHandler(this.btChonEmail_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(368, 37);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(182, 30);
            this.txbSearch.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tìm kiến theo";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã",
            "Họ Tên"});
            this.comboBox1.Location = new System.Drawing.Point(155, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 34);
            this.comboBox1.TabIndex = 1;
            // 
            // dgSearchResult
            // 
            this.dgSearchResult.AllowUserToAddRows = false;
            this.dgSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSearchResult.BackgroundColor = System.Drawing.Color.White;
            this.dgSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.HoTen,
            this.Loai,
            this.Email,
            this.Check});
            this.dgSearchResult.Location = new System.Drawing.Point(35, 88);
            this.dgSearchResult.Name = "dgSearchResult";
            this.dgSearchResult.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgSearchResult.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSearchResult.RowTemplate.Height = 24;
            this.dgSearchResult.Size = new System.Drawing.Size(771, 482);
            this.dgSearchResult.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btThemEmail);
            this.panel2.Controls.Add(this.pnFolder);
            this.panel2.Controls.Add(this.pnGuiDen);
            this.panel2.Controls.Add(this.txbGuiDen);
            this.panel2.Controls.Add(this.rtxbNoiDung);
            this.panel2.Controls.Add(this.btChonFile);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbTieuDe);
            this.panel2.Controls.Add(this.btGui);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(941, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 887);
            this.panel2.TabIndex = 1;
            // 
            // txbGuiDen
            // 
            this.txbGuiDen.Location = new System.Drawing.Point(137, 42);
            this.txbGuiDen.Name = "txbGuiDen";
            this.txbGuiDen.Size = new System.Drawing.Size(487, 30);
            this.txbGuiDen.TabIndex = 10;
            // 
            // rtxbNoiDung
            // 
            this.rtxbNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxbNoiDung.Location = new System.Drawing.Point(137, 254);
            this.rtxbNoiDung.Name = "rtxbNoiDung";
            this.rtxbNoiDung.Size = new System.Drawing.Size(487, 366);
            this.rtxbNoiDung.TabIndex = 9;
            this.rtxbNoiDung.Text = "";
            // 
            // btChonFile
            // 
            this.btChonFile.Location = new System.Drawing.Point(22, 702);
            this.btChonFile.Name = "btChonFile";
            this.btChonFile.Size = new System.Drawing.Size(104, 41);
            this.btChonFile.TabIndex = 8;
            this.btChonFile.Text = "Chọn file";
            this.btChonFile.UseVisualStyleBackColor = true;
            this.btChonFile.Click += new System.EventHandler(this.btChonFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nội dung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiêu đề";
            // 
            // txbTieuDe
            // 
            this.txbTieuDe.Location = new System.Drawing.Point(137, 207);
            this.txbTieuDe.Name = "txbTieuDe";
            this.txbTieuDe.Size = new System.Drawing.Size(487, 30);
            this.txbTieuDe.TabIndex = 3;
            // 
            // btGui
            // 
            this.btGui.Location = new System.Drawing.Point(329, 825);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(82, 41);
            this.btGui.TabIndex = 2;
            this.btGui.Text = "Gửi";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gửi đến";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btDangNhap_Email);
            this.panel3.Controls.Add(this.txbPassWord);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txbEmail);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(54, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 181);
            this.panel3.TabIndex = 8;
            // 
            // btDangNhap_Email
            // 
            this.btDangNhap_Email.Location = new System.Drawing.Point(195, 123);
            this.btDangNhap_Email.Name = "btDangNhap_Email";
            this.btDangNhap_Email.Size = new System.Drawing.Size(128, 41);
            this.btDangNhap_Email.TabIndex = 15;
            this.btDangNhap_Email.Text = "Đăng nhập";
            this.btDangNhap_Email.UseVisualStyleBackColor = true;
            this.btDangNhap_Email.Click += new System.EventHandler(this.btDangNhap_Email_Click);
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(125, 72);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '*';
            this.txbPassWord.Size = new System.Drawing.Size(328, 30);
            this.txbPassWord.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(123, 23);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(328, 30);
            this.txbEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // Ma
            // 
            this.Ma.HeaderText = "Mã";
            this.Ma.Name = "Ma";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // Loai
            // 
            this.Loai.HeaderText = "Loại tài khoản";
            this.Loai.Name = "Loai";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            // 
            // pnGuiDen
            // 
            this.pnGuiDen.AutoScroll = true;
            this.pnGuiDen.Location = new System.Drawing.Point(137, 78);
            this.pnGuiDen.Name = "pnGuiDen";
            this.pnGuiDen.Size = new System.Drawing.Size(487, 123);
            this.pnGuiDen.TabIndex = 11;
            // 
            // pnFolder
            // 
            this.pnFolder.AutoScroll = true;
            this.pnFolder.Location = new System.Drawing.Point(137, 626);
            this.pnFolder.Name = "pnFolder";
            this.pnFolder.Size = new System.Drawing.Size(487, 179);
            this.pnFolder.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyTrungTam.Properties.Resources._4bf2e863380c26afce61fa97c2c71401eadd5656;
            this.pictureBox1.Location = new System.Drawing.Point(655, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button5.BackgroundImage = global::QuanLyTrungTam.Properties.Resources.icons8_search_64__1_;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(569, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 34);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btThemEmail
            // 
            this.btThemEmail.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btThemEmail.BackgroundImage = global::QuanLyTrungTam.Properties.Resources.icons8_search_64__1_;
            this.btThemEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThemEmail.FlatAppearance.BorderSize = 0;
            this.btThemEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemEmail.ForeColor = System.Drawing.Color.Black;
            this.btThemEmail.Location = new System.Drawing.Point(630, 42);
            this.btThemEmail.Name = "btThemEmail";
            this.btThemEmail.Size = new System.Drawing.Size(36, 30);
            this.btThemEmail.TabIndex = 13;
            this.btThemEmail.UseVisualStyleBackColor = false;
            this.btThemEmail.Click += new System.EventHandler(this.btThemEmail_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mail";
            this.Size = new System.Drawing.Size(1663, 938);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchResult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btChonFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTieuDe;
        private System.Windows.Forms.Button btGui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxbNoiDung;
        private System.Windows.Forms.DataGridView dgSearchResult;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btChonEmail;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbGuiDen;
        private System.Windows.Forms.Button btDangNhap_Email;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.FlowLayoutPanel pnFolder;
        private System.Windows.Forms.FlowLayoutPanel pnGuiDen;
        private System.Windows.Forms.Button btThemEmail;
    }
}
