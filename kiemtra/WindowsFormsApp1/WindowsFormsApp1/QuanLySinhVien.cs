using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public  class QuanLySinhVien
    { 
        private readonly INewSinhVien _newsSinhVien;
        private List<Khoa> _khoas;
        public List<SinhVien> danhSach;
       
        public QuanLySinhVien(INewSinhVien newsSinhVien)
        {
            _newsSinhVien = newsSinhVien;
        }
        public List<Khoa> GetNew()
        {
            if (_khoas == null)
            {
                _khoas = _newsSinhVien.GetNews();
            }
            return _khoas;
        }
        public void SaveChanges()
        {
            _newsSinhVien.Save(_khoas);
        }
    }
}
