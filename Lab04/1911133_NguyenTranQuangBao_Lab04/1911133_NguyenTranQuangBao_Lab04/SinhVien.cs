using System;
using System.Collections.Generic;
using System.Text;

namespace _1911133_NguyenTranQuangBao_Lab04
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }

        public SinhVien()
        {

        }

        public SinhVien(string ms, string ht, bool gt, DateTime ngay, string lop, string sDT, string email, string diaChi, string hinh)
        {
            MaSo = ms;
            HoTen = ht;
            GioiTinh = gt;
            NgaySinh = ngay;
            Lop = lop;
            SDT = sDT;
            Email = email;
            DiaChi = diaChi;
            Hinh = hinh;
        }
    }
}
