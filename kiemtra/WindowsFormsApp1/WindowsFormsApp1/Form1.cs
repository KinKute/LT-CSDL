using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<SinhVien> sinhVienList;
        public readonly QuanLySinhVien qlsv;

        public Form1(QuanLySinhVien quanLySinhVien)
        {
            qlsv = quanLySinhVien;
            InitializeComponent();
        }
        private void ShowTreeOnTreeView(List<Khoa> khoas)
        {
            tvwKhoa.Nodes.Clear();
            lvSinhVien.Controls.Clear();
            foreach (var khoa in khoas)
            {
                var khoaNode = tvwKhoa.Nodes.Add(khoa.TenKhoa);
                foreach (var lop in khoa.Lops)
                {
                    khoaNode.Nodes.Add(lop.TenLop);
                }

            }
            tvwKhoa.ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTreeOnTreeView(qlsv.GetNew());
        }

        private void tvwKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
