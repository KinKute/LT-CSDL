using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    public class MonHoc
    {
        public int ID { get; set; }
        public string TenMH { get; set; }
        public int SoTC { get; set; }
        public MonHoc()
        {
        }

        public MonHoc(string ten)
        {
            TenMH = ten;
        }

        public MonHoc(int iD, string ten, int soTC)
        {
            ID = iD;
            TenMH = ten;
            SoTC = soTC;
        }
        public override string ToString()
        {
            return TenMH;
        }
    }
}
