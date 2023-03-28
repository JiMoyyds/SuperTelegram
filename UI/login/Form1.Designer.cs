namespace login
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.sure = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.acc = new Sunny.UI.UITextBox();
            this.pass = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiVerificationCode1 = new Sunny.UI.UIVerificationCode();
            this.verify = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sure
            // 
            this.sure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sure.Location = new System.Drawing.Point(42, 433);
            this.sure.MinimumSize = new System.Drawing.Size(1, 1);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(125, 44);
            this.sure.TabIndex = 0;
            this.sure.Text = "登  录";
            this.sure.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(42, 231);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(125, 29);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "账号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acc
            // 
            this.acc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acc.Location = new System.Drawing.Point(145, 231);
            this.acc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acc.MinimumSize = new System.Drawing.Size(1, 16);
            this.acc.Name = "acc";
            this.acc.ShowText = false;
            this.acc.Size = new System.Drawing.Size(188, 36);
            this.acc.TabIndex = 2;
            this.acc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.acc.Watermark = "";
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass.Location = new System.Drawing.Point(145, 304);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass.MinimumSize = new System.Drawing.Size(1, 16);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.ShowText = false;
            this.pass.Size = new System.Drawing.Size(188, 36);
            this.pass.TabIndex = 4;
            this.pass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pass.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(42, 304);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(125, 29);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "密码：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // uiVerificationCode1
            // 
            this.uiVerificationCode1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiVerificationCode1.Location = new System.Drawing.Point(208, 433);
            this.uiVerificationCode1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiVerificationCode1.Name = "uiVerificationCode1";
            this.uiVerificationCode1.Size = new System.Drawing.Size(125, 44);
            this.uiVerificationCode1.TabIndex = 6;
            // 
            // verify
            // 
            this.verify.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verify.Location = new System.Drawing.Point(145, 373);
            this.verify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verify.MinimumSize = new System.Drawing.Size(1, 16);
            this.verify.Name = "verify";
            this.verify.ShowText = false;
            this.verify.Size = new System.Drawing.Size(188, 36);
            this.verify.TabIndex = 8;
            this.verify.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.verify.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiLabel3.Location = new System.Drawing.Point(28, 373);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(125, 29);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "验证码：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(355, 507);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiVerificationCode1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.sure);
            this.Name = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton sure;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox acc;
        private Sunny.UI.UITextBox pass;
        private Sunny.UI.UILabel uiLabel2;
        private PictureBox pictureBox1;
        private Sunny.UI.UIVerificationCode uiVerificationCode1;
        private Sunny.UI.UITextBox verify;
        private Sunny.UI.UILabel uiLabel3;
    }
}