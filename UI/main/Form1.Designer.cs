namespace main
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
            this.uiSwitch1 = new Sunny.UI.UISwitch();
            this.photo = new System.Windows.Forms.PictureBox();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.name = new Sunny.UI.UILabel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSwitch1
            // 
            this.uiSwitch1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.uiSwitch1.DisabledColor = System.Drawing.Color.Silver;
            this.uiSwitch1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiSwitch1.Location = new System.Drawing.Point(3, 164);
            this.uiSwitch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitch1.Name = "uiSwitch1";
            this.uiSwitch1.Size = new System.Drawing.Size(62, 47);
            this.uiSwitch1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSwitch1.TabIndex = 2;
            this.uiSwitch1.Text = "夜晚";
            this.uiSwitch1.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.uiSwitch1_ValueChanged);
            // 
            // photo
            // 
            this.photo.Image = ((System.Drawing.Image)(resources.GetObject("photo.Image")));
            this.photo.Location = new System.Drawing.Point(7, 11);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(54, 45);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 0;
            this.photo.TabStop = false;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.name);
            this.uiPanel2.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPanel2.Location = new System.Drawing.Point(68, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(303, 53);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(10, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 29);
            this.name.Style = Sunny.UI.UIStyle.Custom;
            this.name.TabIndex = 0;
            this.name.Text = " ";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.pictureBox1);
            this.uiPanel3.FillColor = System.Drawing.Color.Gainsboro;
            this.uiPanel3.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPanel3.Location = new System.Drawing.Point(68, 463);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.RectColor = System.Drawing.Color.White;
            this.uiPanel3.RectDisableColor = System.Drawing.Color.White;
            this.uiPanel3.Size = new System.Drawing.Size(303, 67);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel3.TabIndex = 2;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.White;
            this.uiPanel1.Controls.Add(this.pictureBox2);
            this.uiPanel1.Controls.Add(this.uiSwitch1);
            this.uiPanel1.Controls.Add(this.photo);
            this.uiPanel1.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.uiPanel1.FillColor2 = System.Drawing.Color.MintCream;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPanel1.Location = new System.Drawing.Point(-1, -7);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.Size = new System.Drawing.Size(71, 532);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(301, 412);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 523);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiPanel2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISwitch uiSwitch1;
        private PictureBox photo;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel name;
        private Sunny.UI.UIPanel uiPanel3;
        private PictureBox pictureBox1;
        private Sunny.UI.UIPanel uiPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
    }
}