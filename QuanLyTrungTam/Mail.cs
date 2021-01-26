using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Web;
using System.Threading;
using QuanLyNhaHang_Entity;
using QuanLyTrungTam_BUS;
using Limilabs.Client.IMAP;

namespace QuanLyTrungTam
{
    public partial class Mail : UserControl
    {
        private string username;
        private string password;
        private Imap imap;
        List<string> listFolder;
        List<Button> listButton;
        List<string> listMail;
        List<Button> listButtonEmail;
        bool TrangThai_DangNhap;
        public Mail()
        {
            InitializeComponent();
            listFolder = new List<string>();
            listButton = new List<Button>();
            listMail = new List<string>();
            listButtonEmail = new List<Button>();
            TrangThai_DangNhap = false;
        }

        private void btChonFile_Click(object sender, EventArgs e)
        {
            string folder = "";
            Thread thr = new Thread((ThreadStart)(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    folder = openFileDialog.FileName.ToString();
                    listFolder.Add(folder);
                }
            }));
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
            thr.Join();
            if (folder == "")
            {
                return;
            }
            int j = 0;
            for (int i = 0; i < folder.Length; i++)
            {
                if (Convert.ToInt32(folder[i]) == 92)
                {
                    j = i;
                }
            }
            string fo = folder.Substring(j + 1);
            Button btn = new Button();
            btn.Text = fo;
            btn.Enabled = true;
            btn.Width = 400;
            btn.Height = 30;
            btn.BackColor = Color.Silver;
            btn.ForeColor = System.Drawing.Color.Blue;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listButton.Add(btn);
            btn.Click += Btn_Click;
            pnFolder.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DialogResult result = MessageBox.Show("Bạn chắc là muốn xóa file này chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = listButton.IndexOf(btn);
                listButton.Remove(btn);
                listFolder.RemoveAt(i);
                pnFolder.Controls.Clear();
                foreach (Button bt in listButton)
                {
                    pnFolder.Controls.Add(bt);
                }
            }
            else
            {
                return;
            }
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (string email in listMail)
            {
                try
                {
                    MailMessage mail = new MailMessage(username, email, txbTieuDe.Text, rtxbNoiDung.Text);
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    foreach (string item in listFolder)
                    {
                        Attachment att = new Attachment(item);
                        mail.Attachments.Add(att);
                    }
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential(username, password);
                    client.EnableSsl = true;
                    client.Send(mail);
                    index++;
                }
                catch
                {

                }
            }
            MessageBox.Show("Gửi thành công "+index+" mail!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        bool Stt = true;

        private void button5_Click(object sender, EventArgs e)
        {
            string text = txbSearch.Text;
            if (text == "")
            {
                return;
            }
            dgSearchResult.Rows.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                EC_LopHoc LopHoc = new BUS_LopHoc().Select_ByPrimaryKey(text);
                if (LopHoc != null)
                {
                    List<EC_LichHoc> listBuoiHoc = new BUS_LichHoc().SelectByFields("Ma_LopHoc", LopHoc.Ma_LopHoc);
                    if (listBuoiHoc.Count == 0)
                    {
                        dgSearchResult.Rows.Clear();
                        return;
                    }
                    List<EC_BuoiHoc_HocSinh> listBHHS = new BUS_BuoiHoc_HocSinh().SelectByFields("Ma_BuoiHoc", listBuoiHoc[0].Ma_BuoiHoc);

                    foreach (EC_BuoiHoc_HocSinh ec in listBHHS)
                    {
                        EC_HocSinh hs = new BUS_HocSinh().Select_ByPrimaryKey(ec.Ma_HocSinh);
                        dgSearchResult.Rows.Add(hs.Ma_HocSinh, hs.Ten_HocSinh, "Học sinh", hs.Email, null);
                    }
                }

                EC_HocSinh HocSinh = new BUS_HocSinh().Select_ByPrimaryKey(text);
                if (HocSinh != null)
                {
                    dgSearchResult.Rows.Add(HocSinh.Ma_HocSinh, HocSinh.Ten_HocSinh, "Học sinh", HocSinh.Email, null);
                    return;
                }

                EC_GiaoVien GiaoVien = new BUS_GiaoVien().Select_ByPrimaryKey(text);
                if (GiaoVien != null)
                {
                    dgSearchResult.Rows.Add(GiaoVien.Ma_GiaoVien, GiaoVien.Ten_GiaoVien, "Giáo viên", GiaoVien.Email, null);
                    return;
                }
            }
            else
            {
                List<EC_HocSinh> listHocSinh = new BUS_HocSinh().SelectByFields("Ten_HocSinh", text);
                foreach(EC_HocSinh HocSinh in listHocSinh)
                {
                    dgSearchResult.Rows.Add(HocSinh.Ma_HocSinh, HocSinh.Ten_HocSinh, "Học sinh", HocSinh.Email, null);
                }
                List<EC_GiaoVien> listGiaoVien = new BUS_GiaoVien().SelectByFields("Ten_GiaoVien", text);
                foreach(EC_GiaoVien GiaoVien in listGiaoVien)
                {
                    dgSearchResult.Rows.Add(GiaoVien.Ma_GiaoVien, GiaoVien.Ten_GiaoVien, "Giáo viên", GiaoVien.Email, null);
                }
            }
        }

        private void btChonEmail_Click(object sender, EventArgs e)
        {

            listMail = new List<string>();
            if (dgSearchResult.Rows.Count == 0)
            {
                return;
            }
            foreach(DataGridViewRow row in dgSearchResult.Rows)
            {
                if (row.Cells["Check"].Value != null) 
                {
                    if (Convert.ToBoolean(row.Cells["Check"].Value.ToString()) == true)
                    {
                        listMail.Add(row.Cells["Email"].Value.ToString());
                    }
                }
            }
            pnGuiDen.Controls.Clear();
            foreach (string mail in listMail)
            {
                Button btn = new Button();
                btn.Text = mail;
                btn.Enabled = true;
                btn.Width = 400;
                btn.Height = 30;
                btn.BackColor = Color.Silver;
                btn.ForeColor = System.Drawing.Color.Blue;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnGuiDen.Controls.Add(btn);
                btn.Click += Btn_Click1;
            }
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DialogResult result = MessageBox.Show("Bạn chắc là muốn xóa email này chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = listButtonEmail.IndexOf(btn);
                listButtonEmail.Remove(btn);
                listMail.Remove(btn.Text);
                pnGuiDen.Controls.Clear();
                foreach (Button bt in listButtonEmail)
                {
                    pnGuiDen.Controls.Add(bt);
                }
            }
            else
            {
                return;
            }
        }

        private void btDangNhap_Email_Click(object sender, EventArgs e)
        {
            try
            {
                imap = new Imap();
                imap.ConnectSSL("imap.gmail.com", 993);

                username = txbEmail.Text;
                password = txbPassWord.Text;

                imap.Login(username, password);

                DialogResult result = MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    TrangThai_DangNhap = true;
                }
            }
            catch
            {
                DialogResult result = MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    txbPassWord.Text = "";
                }
                Panel panel1 = new Panel();
            }
        }

        private void btThemEmail_Click(object sender, EventArgs e)
        {
            string email = txbGuiDen.Text;
            if (email == "")
            {
                return;
            }
            listMail.Add(email);
            pnGuiDen.Controls.Clear();
            foreach (string mail in listMail)
            {
                Button btn = new Button();
                btn.Text = mail;
                btn.Enabled = true;
                btn.Width = 400;
                btn.Height = 30;
                btn.BackColor = Color.Silver;
                btn.ForeColor = System.Drawing.Color.Blue;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnGuiDen.Controls.Add(btn);
                btn.Click += Btn_Click2;
            }
        }

        private void Btn_Click2(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DialogResult result = MessageBox.Show("Bạn chắc là muốn xóa email này chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = listButtonEmail.IndexOf(btn);
                listButtonEmail.Remove(btn);
                listMail.Remove(btn.Text);
                pnGuiDen.Controls.Clear();
                foreach (Button bt in listButtonEmail)
                {
                    pnGuiDen.Controls.Add(bt);
                }
            }
            else
            {
                return;
            }
        }
    }
}
