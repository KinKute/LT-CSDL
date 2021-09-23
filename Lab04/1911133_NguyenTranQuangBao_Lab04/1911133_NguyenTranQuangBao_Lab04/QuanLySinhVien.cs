using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _1911133_NguyenTranQuangBao_Lab04
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }

        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }

        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }

        public void DocTuFile()
        {
            string filename = "DanhSachSV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.GioiTinh = false;
                if (s[2] == "1")
                    sv.GioiTinh = true;
                sv.NgaySinh = DateTime.Parse(s[3]);
                sv.Lop = s[4];
                sv.SDT = s[5];
                sv.Email = s[6];
                sv.DiaChi = s[7];
                sv.Hinh = s[8];
                this.Them(sv);
            }
        }

        public SinhVien Tim(object obj1, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
            {
                if (ss(obj1, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            }
            return svresult;
        }

        public void Xoa(object obj1, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
            {
                if (ss(obj1, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
            }
        }

        public bool Sua(SinhVien svSua, object obj1, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count - 1;
            for (i = 0 ; i < count; i++)
            {
                if (ss(obj1,this[i])==0)
                {
                    this[i] = svSua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }

    }
}
