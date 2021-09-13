using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _1911133_NguyenTranQuangBao_Lab03
{
    public partial class frmTuyChon : Form
    {
        QuanLySinhVien qlsv;
        ListView lv;
        public frmTuyChon()
        {
            InitializeComponent();
        }

        public frmTuyChon(QuanLySinhVien qlsv, ListView lv, bool loai)
        {
            InitializeComponent();
            this.qlsv = qlsv;
            this.lv = lv;

            if (loai)
                btnSapXep.Enabled = false;
            else
            {
                label1.Enabled = false;
                txtThongTin.Enabled = false;
                btnTim.Enabled = false;
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            KieuTim kieu = KieuTim.MaSV;
            if (rdMaSV.Checked)
                kieu = KieuTim.MaSV;
            if (rdHoTen.Checked)
                kieu = KieuTim.HoTen;
            if (rdNgaySinh.Checked)
                kieu = KieuTim.NgaySinh;

            switch (kieu)
            {
                case KieuTim.HoTen:
                    qlsv.DanhSach.Sort((x, y) => x.HoTen.CompareTo(y.HoTen));
                    break;
                case KieuTim.MaSV:
                    qlsv.DanhSach.Sort((x, y) => x.MaSo.CompareTo(y.MaSo));
                    break;
                case KieuTim.NgaySinh:
                    qlsv.DanhSach.Sort((x, y) => x.NgaySinh.CompareTo(y.NgaySinh));
                    break;
                default:
                    break;
            }
            lv.Items.Clear();
            foreach (var sv in qlsv.DanhSach)
            {
                ListViewItem item = new ListViewItem(sv.MaSo);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
                item.SubItems.Add(sv.Hinh);

                lv.Items.Add(item);
            }
            this.Close();
        }

        private void rdMaSV_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nhập mã sinh viên" ;
            txtThongTin.Text = "";
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nhập họ tên sinh viên";
            txtThongTin.Text = "";
        }

        private void rdNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nhập ngày sinh";
            txtThongTin.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SinhVien sv = null;
            KieuTim kieu = KieuTim.MaSV;
            if (rdMaSV.Checked)
                kieu = KieuTim.MaSV;
            if (rdHoTen.Checked)
                kieu = KieuTim.HoTen;
            if (rdNgaySinh.Checked)
                kieu = KieuTim.NgaySinh;

            switch (kieu)
            {
                case KieuTim.HoTen:
                    sv = qlsv.DanhSach.Find(x => x.HoTen == txtThongTin.Text);
                    break;
                case KieuTim.MaSV:
                    sv = qlsv.DanhSach.Find(x => x.MaSo == txtThongTin.Text);
                    break;
                case KieuTim.NgaySinh:
                    sv = qlsv.DanhSach.Find(x => x.NgaySinh.Day == int.Parse(txtThongTin.Text));
                    break;
                default:
                    break;
            }
            if (sv is null)
                MessageBox.Show("Hãy nhập thông tin tìm", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error );
            else
            {
                ListViewItem item = new ListViewItem(sv.MaSo);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
                item.SubItems.Add(sv.Hinh);

                lv.Items.Clear();
                lv.Items.Add(item);
            }
        }
    }
}
