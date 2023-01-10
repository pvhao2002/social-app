
namespace Social_App
{
    partial class frmComment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbPost = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picFriend1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picMe1 = new System.Windows.Forms.PictureBox();
            this.rtxtCmt = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFriend1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMe1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbPost);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 52);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(884, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbPost
            // 
            this.lbPost.AutoSize = true;
            this.lbPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPost.Location = new System.Drawing.Point(354, 3);
            this.lbPost.Name = "lbPost";
            this.lbPost.Size = new System.Drawing.Size(201, 48);
            this.lbPost.TabIndex = 1;
            this.lbPost.Text = "Comment";
            this.lbPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.picFriend1);
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 715);
            this.panel2.TabIndex = 1;
            // 
            // picFriend1
            // 
            this.picFriend1.Location = new System.Drawing.Point(3, 3);
            this.picFriend1.Name = "picFriend1";
            this.picFriend1.Size = new System.Drawing.Size(131, 125);
            this.picFriend1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFriend1.TabIndex = 0;
            this.picFriend1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(140, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(770, 32);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(142, 68);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(771, 23);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(3, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 478);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rtxtCmt);
            this.panel4.Controls.Add(this.picMe1);
            this.panel4.Location = new System.Drawing.Point(4, 632);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(909, 80);
            this.panel4.TabIndex = 4;
            // 
            // picMe1
            // 
            this.picMe1.Location = new System.Drawing.Point(9, 4);
            this.picMe1.Name = "picMe1";
            this.picMe1.Size = new System.Drawing.Size(87, 73);
            this.picMe1.TabIndex = 0;
            this.picMe1.TabStop = false;
            // 
            // rtxtCmt
            // 
            this.rtxtCmt.Location = new System.Drawing.Point(102, 14);
            this.rtxtCmt.Name = "rtxtCmt";
            this.rtxtCmt.Size = new System.Drawing.Size(713, 58);
            this.rtxtCmt.TabIndex = 1;
            this.rtxtCmt.Text = "";
            // 
            // frmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 774);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCommetn";
            this.Load += new System.EventHandler(this.frmComment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFriend1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMe1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbPost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picFriend1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtxtCmt;
        private System.Windows.Forms.PictureBox picMe1;
    }
}