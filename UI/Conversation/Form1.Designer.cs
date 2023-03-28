namespace Conversation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sure = new Sunny.UI.UIButton();
            this.sendmessage = new System.Windows.Forms.TextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameL = new Sunny.UI.UILabel();
            this.accL = new Sunny.UI.UILabel();
            this.revisename = new Sunny.UI.UITextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // sure
            // 
            this.sure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sure.Location = new System.Drawing.Point(486, 473);
            this.sure.MinimumSize = new System.Drawing.Size(1, 1);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(111, 37);
            this.sure.TabIndex = 1;
            this.sure.Text = "发  送";
            this.sure.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // sendmessage
            // 
            this.sendmessage.Location = new System.Drawing.Point(36, 333);
            this.sendmessage.Multiline = true;
            this.sendmessage.Name = "sendmessage";
            this.sendmessage.Size = new System.Drawing.Size(561, 111);
            this.sendmessage.TabIndex = 3;
            // 
            // uiButton1
            // 
            this.uiButton1.FillColor = System.Drawing.Color.White;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.ForeColor = System.Drawing.Color.Black;
            this.uiButton1.Location = new System.Drawing.Point(354, 473);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(96, 37);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "关  闭";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(612, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(612, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // nameL
            // 
            this.nameL.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameL.Location = new System.Drawing.Point(299, 9);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(125, 29);
            this.nameL.TabIndex = 7;
            this.nameL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // accL
            // 
            this.accL.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accL.Location = new System.Drawing.Point(638, 226);
            this.accL.Name = "accL";
            this.accL.Size = new System.Drawing.Size(125, 29);
            this.accL.TabIndex = 8;
            this.accL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // revisename
            // 
            this.revisename.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.revisename.Location = new System.Drawing.Point(486, 6);
            this.revisename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.revisename.MinimumSize = new System.Drawing.Size(1, 16);
            this.revisename.Name = "revisename";
            this.revisename.ShowText = false;
            this.revisename.Size = new System.Drawing.Size(188, 36);
            this.revisename.TabIndex = 9;
            this.revisename.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.revisename.Visible = false;
            this.revisename.Watermark = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(435, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 248);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 538);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.revisename);
            this.Controls.Add(this.accL);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.sendmessage);
            this.Controls.Add(this.sure);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIButton sure;
        private TextBox sendmessage;
        private Sunny.UI.UIButton uiButton1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Sunny.UI.UILabel nameL;
        private Sunny.UI.UILabel accL;
        private Sunny.UI.UITextBox revisename;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}