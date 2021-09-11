using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ThongTinGiaoVienForm : Form
    {
        private QuanLyGiaoVien quanLyGV;
        public ThongTinGiaoVienForm()
        {
            InitializeComponent();
        }

        public ThongTinGiaoVienForm(QuanLyGiaoVien qlgv) : this()
        {
            quanLyGV = qlgv;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           var kieuTim = KieuTim.TheoHoTen;
            if (rdMaGV.Checked)
            {
                kieuTim = KieuTim.TheoMa;
            }
            else if (rdHoTen.Checked)
            {
                kieuTim = KieuTim.TheoHoTen;
            }
            else if (rdSDT.Checked)
            {
                kieuTim = KieuTim.TheoSDT;
            }

            var ketQua = quanLyGV.Tim(txtSearch.Text, kieuTim);

            if (ketQua is null)
            {
                MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var frmTBGiaoVien = new TBGiaoVienForm();
                frmTBGiaoVien.SetText(ketQua.ToString());
                frmTBGiaoVien.ShowDialog();
            }
        }
    }
}
