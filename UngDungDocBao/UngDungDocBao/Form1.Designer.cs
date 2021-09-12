
namespace UngDungDocBao
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvwPublisher = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNews = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvwPublisher
            // 
            this.tvwPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwPublisher.Location = new System.Drawing.Point(12, 56);
            this.tvwPublisher.Name = "tvwPublisher";
            this.tvwPublisher.Size = new System.Drawing.Size(236, 382);
            this.tvwPublisher.TabIndex = 0;
            this.tvwPublisher.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPublisher_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn toà soạn hoặc chuyên mục";
            // 
            // pnlNews
            // 
            this.pnlNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNews.AutoScroll = true;
            this.pnlNews.BackgroundImage = global::UngDungDocBao.Properties.Resources.bg_avatar;
            this.pnlNews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNews.Location = new System.Drawing.Point(271, 56);
            this.pnlNews.Name = "pnlNews";
            this.pnlNews.Size = new System.Drawing.Size(517, 382);
            this.pnlNews.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(240, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(278, 18);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 29);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlNews);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvwPublisher);
            this.Name = "Mainform";
            this.Text = "Quản lý tin tức";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNews;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}

