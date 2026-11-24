
namespace taks14
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();

            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();

            // tabControl1
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(523, 100);
            tabControl1.TabIndex = 0;

            // tabPage2
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(515, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Məkan";
            tabPage2.UseVisualStyleBackColor = true;

            // tabPage1
            tabPage1.Controls.Add(linkLabel3);
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(linkLabel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(515, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sosial şəbəkələr";
            tabPage1.UseVisualStyleBackColor = true;

            // linkLabel1 - YouTube
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(15, 3);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "YouTube";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;

            // linkLabel2 - Instagram
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(15, 18);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(60, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "İnstagram";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;

            // linkLabel3 - Facebook
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(15, 33);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(58, 15);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "FaceBook";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";

            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private LinkLabel linkLabel1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
    }
}
