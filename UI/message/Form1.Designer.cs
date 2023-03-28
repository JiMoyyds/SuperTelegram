namespace message
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.email = new Sunny.UI.UITextBox();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.mod = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.phone = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.name = new Sunny.UI.UITextBox();
            this.introduce = new Sunny.UI.UITextBox();
            this.save = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.email.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 173);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "名称：";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.mod);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.introduce);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 504);
            this.panel1.TabIndex = 2;
            // 
            // email
            // 
            this.email.Controls.Add(this.uiTextBox2);
            this.email.Controls.Add(this.uiLabel4);
            this.email.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(31, 494);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.MinimumSize = new System.Drawing.Size(1, 16);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.ShowText = false;
            this.email.Size = new System.Drawing.Size(286, 39);
            this.email.TabIndex = 8;
            this.email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.email.Watermark = "";
            this.email.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox2.Location = new System.Drawing.Point(6, 79);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(286, 36);
            this.uiTextBox2.TabIndex = 10;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "";
            this.uiTextBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(-14, 45);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(76, 29);
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "名称：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mod.Location = new System.Drawing.Point(43, 576);
            this.mod.MinimumSize = new System.Drawing.Size(1, 1);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(110, 41);
            this.mod.TabIndex = 8;
            this.mod.Text = "修改";
            this.mod.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(12, 460);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(76, 29);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "邮箱：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(32, 425);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.MinimumSize = new System.Drawing.Size(1, 16);
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.ShowText = false;
            this.phone.Size = new System.Drawing.Size(286, 36);
            this.phone.TabIndex = 6;
            this.phone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.phone.Watermark = "";
            this.phone.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(12, 391);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(76, 29);
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "手机号：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(12, 248);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(178, 29);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "个人简介";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(32, 207);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.MinimumSize = new System.Drawing.Size(1, 16);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ShowText = false;
            this.name.Size = new System.Drawing.Size(286, 36);
            this.name.TabIndex = 3;
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.Watermark = "";
            this.name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // introduce
            // 
            this.introduce.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.introduce.Location = new System.Drawing.Point(32, 282);
            this.introduce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.introduce.MinimumSize = new System.Drawing.Size(1, 16);
            this.introduce.Multiline = true;
            this.introduce.Name = "introduce";
            this.introduce.ReadOnly = true;
            this.introduce.ShowText = false;
            this.introduce.Size = new System.Drawing.Size(286, 105);
            this.introduce.TabIndex = 2;
            this.introduce.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.introduce.Watermark = "";
            this.introduce.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.introduce.TextChanged += new System.EventHandler(this.introduce_TextChanged);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save.Location = new System.Drawing.Point(190, 576);
            this.save.MinimumSize = new System.Drawing.Size(1, 1);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 41);
            this.save.TabIndex = 9;
            this.save.Text = "保存";
            this.save.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 494);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.email.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Sunny.UI.UILabel nameLabel;
        private Panel panel1;
        private Sunny.UI.UITextBox introduce;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox phone;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox email;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton mod;
        private Sunny.UI.UIButton save;
    }
}