
namespace UngDungDocBao.Components
{
    partial class NewsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDes = new System.Windows.Forms.Label();
            this.llb = new System.Windows.Forms.LinkLabel();
            this.lbDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(16, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(50, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            // 
            // lbDes
            // 
            this.lbDes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDes.Location = new System.Drawing.Point(19, 29);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(516, 41);
            this.lbDes.TabIndex = 1;
            this.lbDes.Text = "label2";
            // 
            // llb
            // 
            this.llb.AutoSize = true;
            this.llb.Location = new System.Drawing.Point(406, 70);
            this.llb.Name = "llb";
            this.llb.Size = new System.Drawing.Size(56, 20);
            this.llb.TabIndex = 2;
            this.llb.TabStop = true;
            this.llb.Text = "Chi tiết";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(19, 70);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(50, 20);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "label3";
            // 
            // NewsControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.llb);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.lbTitle);
            this.Name = "NewsControl1";
            this.Size = new System.Drawing.Size(556, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.LinkLabel llb;
        private System.Windows.Forms.Label lbDate;
    }
}
