using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    public class QuanLyGiaoVien
    {
        public List<GiaoVien> dsGiaoVien;
        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }

        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index]; }
            set { dsGiaoVien[index] = value; }
        }

        public bool Them(GiaoVien giaoVien)
        {
            var already = dsGiaoVien.Exists(gv => gv.MaSo == giaoVien.MaSo);
            if (already) return false;

            dsGiaoVien.Add(giaoVien);

            return true;
        }

        public void Xoa(GiaoVien gv)
        {
            var isExisted = dsGiaoVien.Find(x => x.MaSo == gv.MaSo);
            if (isExisted != null) dsGiaoVien.Remove(gv);
        }

        public GiaoVien Tim(string value, KieuTim kieuTim)
        {
            GiaoVien giaoVien = null;

            switch (kieuTim)
            {
                case KieuTim.TheoHoTen:
                    giaoVien = dsGiaoVien.Find(gv => gv.HoTen == value);
                    break;
                case KieuTim.TheoMa:
                    giaoVien = dsGiaoVien.Find(gv => gv.MaSo == value);
                    break;
                case KieuTim.TheoSDT:
                    giaoVien = dsGiaoVien.Find(gv => gv.SoDT == value);
                    break;
                default:
                    break;
            }

            return giaoVien;
        }

        public int Dem()
        {
            return dsGiaoVien.Count;
        }

    }
}
