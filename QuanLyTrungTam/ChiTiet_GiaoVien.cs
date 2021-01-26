using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang_Entity;
using QuanLyTrungTam_BUS;
using System.Threading;

namespace QuanLyTrungTam
{
    public partial class ChiTiet_GiaoVien : UserControl
    {
        string Ma_GiaoVien;
        public ChiTiet_GiaoVien(string _Ma_GiaoVien)
        {
            InitializeComponent();
            Ma_GiaoVien = _Ma_GiaoVien;
            Load();
        }

        void Load()
        {
            EC_GiaoVien GiaoVien = new BUS_GiaoVien().Select_ByPrimaryKey(Ma_GiaoVien);
            if (GiaoVien.Anh != null)
            {
                picAvt.Image = HinhAnh.ByteToImage(GiaoVien.Anh);
            }
            txbMa_GiaoVien.Text = GiaoVien.Ma_GiaoVien;
            txbTen_GiaoVien.Text = GiaoVien.Ten_GiaoVien;
            txbDiaChi.Text = GiaoVien.DiaChi;
            txbEmail.Text = GiaoVien.Email;
            txbSDT.Text = GiaoVien.SDT;
            dtNgaySinh.Value = GiaoVien.NgaySinh;
            cbGioiTinh.SelectedItem = GiaoVien.GioiTinh == true ? "Nam" : "Nữ";
            cbTrinhDo.SelectedItem = GiaoVien.TrinhDo;

            List<EC_PhanCong_Day> listPhanCong_Day = new BUS_PhanCong_Day().SelectByFields("Ma_GiaoVien", Ma_GiaoVien);
            BUS_MonHoc busMonHoc = new BUS_MonHoc();
            int index = 1;
            foreach(EC_PhanCong_Day ec in listPhanCong_Day)
            {
                EC_MonHoc MonHoc = busMonHoc.Select_ByPrimaryKey(ec.Ma_MonHoc);
                dgPhanCong_Day.Rows.Add(index.ToString(), MonHoc.Ma_MonHoc, MonHoc.Ten_MonHoc, MonHoc.Lop.ToString());
                index++;
            }

            index = 1;
            List<EC_LopHoc> listLopHoc = new BUS_LopHoc().SelectByFields("Ma_GiaoVien", Ma_GiaoVien);
            foreach(EC_LopHoc ec in listLopHoc)
            {
                List<EC_LichHoc> listBuoiHoc = new BUS_LichHoc().SelectByFields("Ma_LopHoc", ec.Ma_LopHoc);
                if (listBuoiHoc.Count == 0)
                {
                    continue;
                }
                List<EC_BuoiHoc_HocSinh> listBHHS = new BUS_BuoiHoc_HocSinh().SelectByFields("Ma_BuoiHoc",listBuoiHoc[0].Ma_BuoiHoc);
                EC_MonHoc MonHoc = busMonHoc.Select_ByPrimaryKey(ec.Ma_MonHoc);
                dgLopDay.Rows.Add(index.ToString(), ec.Ma_LopHoc, MonHoc.Ten_MonHoc, MonHoc.Lop, ec.SoBuoi, listBHHS.Count);
                index++;
            }
        }

        private void btMonHoc_Search_Click(object sender, EventArgs e)
        {
            string text = txbSearch.Text;
            if (text == "")
            {
                return;
            }
            BUS_MonHoc busMonHoc = new BUS_MonHoc();
            EC_MonHoc MonHoc1 = busMonHoc.Select_ByPrimaryKey(text);
            List<EC_MonHoc> listResult = new List<EC_MonHoc>();
            if (MonHoc1 != null)
            {
                listResult.Add(MonHoc1);
            }
            List<EC_MonHoc> listMonHoc2 = busMonHoc.SelectByFields("Ten_MonHoc", text);
            foreach(EC_MonHoc ec in listMonHoc2)
            {
                listResult.Add(ec);
            }
            dgSearchResult.Rows.Clear();
            foreach(EC_MonHoc ec in listResult)
            {
                dgSearchResult.Rows.Add(ec.Ma_MonHoc, ec.Ten_MonHoc, ec.Lop, null);
            }
        }

        private void btThem_MonHoc_Click(object sender, EventArgs e)
        {
            if (dgSearchResult.Rows.Count == 0)
            {
                return;
            }
            int count_Check = 0;
            List<EC_MonHoc> listChecked = new List<EC_MonHoc>();
            foreach(DataGridViewRow row in dgSearchResult.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    if (Convert.ToBoolean(row.Cells[3].Value.ToString()) == true)
                    {
                        count_Check++;
                        EC_MonHoc MonHoc = new BUS_MonHoc().Select_ByPrimaryKey(row.Cells[0].Value.ToString());
                        listChecked.Add(MonHoc);
                    }
                }
            }
            if (count_Check == 0)
            {
                MessageBox.Show("Chọn môn học để thêm!", "Thông báo");
                return;
            }
            List<EC_PhanCong_Day> listPhanCong_Day = new BUS_PhanCong_Day().SelectByFields("Ma_GiaoVien", Ma_GiaoVien);
            int count_Success = 0;
            foreach (EC_MonHoc i in listChecked)
            {
                bool check = true;
                foreach (EC_PhanCong_Day ec in listPhanCong_Day)
                {
                    if (ec.Ma_MonHoc == i.Ma_MonHoc)
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    new BUS_PhanCong_Day().ThemDuLieu(new EC_PhanCong_Day(Ma_GiaoVien, i.Ma_MonHoc));
                    count_Success++;
                }
            }
            MessageBox.Show("Thêm thành công " + count_Success.ToString() + " môn học", "Thông báo");

            dgPhanCong_Day.Rows.Clear();
            List<EC_PhanCong_Day> list = new BUS_PhanCong_Day().SelectByFields("Ma_GiaoVien", Ma_GiaoVien);
            BUS_MonHoc busMonHoc = new BUS_MonHoc();
            int index = 1;
            foreach (EC_PhanCong_Day ec in listPhanCong_Day)
            {
                EC_MonHoc MonHoc = busMonHoc.Select_ByPrimaryKey(ec.Ma_MonHoc);
                dgPhanCong_Day.Rows.Add(index.ToString(), MonHoc.Ma_MonHoc, MonHoc.Ten_MonHoc, MonHoc.Lop.ToString());
                index++;
            }
        }

        private void dgLopDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Ma_LopHoc = dgLopDay.Rows[e.RowIndex].Cells["Ma_LopHoc"].Value.ToString();
            if (Ma_LopHoc == "")
            {
                return;
            }
            EC_LopHoc LopHoc = new BUS_LopHoc().Select_ByPrimaryKey(Ma_LopHoc);
            EC_MonHoc MonHoc = new BUS_MonHoc().Select_ByPrimaryKey(LopHoc.Ma_MonHoc);
            EC_GiaoVien GiaoVien = new BUS_GiaoVien().Select_ByPrimaryKey(LopHoc.Ma_GiaoVien);
            txbMa_LopHoc.Text = Ma_LopHoc;
            txbTen.Text = GiaoVien.Ten_GiaoVien;
            txbTen_MonHoc.Text = MonHoc.Ten_MonHoc;
            txbLop.Text = MonHoc.Lop.ToString();
            txbMucDo.Text = LopHoc.TrinhDo;
            txbTongHP.Text = LopHoc.TongHocPhi_KhoaHoc.ToString();
            txbSoBuoi.Text = LopHoc.SoBuoi.ToString();
        }
        byte[] byteAnh;
        private void picAvt_DoubleClick(object sender, EventArgs e)
        {
            string filename = "";
            Thread thr = new Thread((ThreadStart)(() =>
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    filename = open.FileName.ToString();
                }
            }));
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
            thr.Join();

            if (filename == "")
            {
                return;
            }

            byte[] arrByte = HinhAnh.StringToByte(filename);
            byteAnh = arrByte;
            picAvt.Image = HinhAnh.ByteToImage(arrByte);
            if (txbMa_GiaoVien.Text == "")
            {
                return;
            }
            else
            {
                EC_GiaoVien gv = new BUS_GiaoVien().Select_ByPrimaryKey(txbMa_GiaoVien.Text);
                gv.Anh = arrByte;
                try
                {
                    new BUS_GiaoVien().SuaDuLieu(gv);
                    MessageBox.Show("Lưu ảnh thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Lưu ảnh không thành công", "Thông báo");
                }
            }
        }

        private void btLuuThongTin_Click(object sender, EventArgs e)
        {
            if (txbMa_GiaoVien.Text == "")
            {
                return;
            }
            bool GioiTinh = cbGioiTinh.SelectedIndex == 0 ? true : false;
            EC_GiaoVien GiaoVien1 = new BUS_GiaoVien().Select_ByPrimaryKey(txbMa_GiaoVien.Text);
            EC_GiaoVien GiaoVien = new EC_GiaoVien(txbMa_GiaoVien.Text, txbTen_GiaoVien.Text, dtNgaySinh.Value, GioiTinh,
                txbDiaChi.Text, txbSDT.Text, txbEmail.Text, cbTrinhDo.SelectedItem.ToString(), GiaoVien1.ID, byteAnh);
            try
            {
                new BUS_GiaoVien().SuaDuLieu(GiaoVien);
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo");
            }
        }
    }
}
