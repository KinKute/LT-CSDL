using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungDocBao.Components
{
    public partial class NewsControl : UserControl
    {
        public void SetArticle(Models.Article news)
        {
            lbTitle.Text = news.Title;
            lbDes.Text = news.Description;
            lbDate.Text = news.PublishedDate.ToString("dd/MM/yyyy HH:mm");
            llb.LinkClicked += (sender, args) =>
            {
                Process.Start(news.Link);
            };
        }

        public NewsControl()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black, 0, 1, Width - 1, Height - 2);
        }
    }
}
