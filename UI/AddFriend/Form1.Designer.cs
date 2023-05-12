namespace AddFriend
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
            this.uiLine1 = new Sunny.UI.UILine();
            this.people = new Sunny.UI.UICheckBox();
            this.group = new Sunny.UI.UICheckBox();
            this.TextBox = new Sunny.UI.UITextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pname = new Sunny.UI.UILabel();
            this.pacc = new Sunny.UI.UILabel();
            this.add = new Sunny.UI.UIButton();
            this.uiPipe1 = new Sunny.UI.UIPipe();
            this.nopeople = new Sunny.UI.UILabel();
            this.search = new Sunny.UI.UIImageButton();
            this.groupjoin = new Sunny.UI.UIButton();
            this.groupcreat = new Sunny.UI.UIButton();
            this.groupsure = new Sunny.UI.UIButton();
            this.group1 = new Sunny.UI.UILabel();
            this.groupnumber = new Sunny.UI.UITextBox();
            this.groupname = new Sunny.UI.UITextBox();
            this.group2 = new Sunny.UI.UILabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.uiLine1.LineColor2 = System.Drawing.Color.White;
            this.uiLine1.Location = new System.Drawing.Point(-1, 161);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(802, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            this.uiLine1.Text = "查    找    结    果";
            // 
            // people
            // 
            this.people.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.people.Location = new System.Drawing.Point(180, 34);
            this.people.MinimumSize = new System.Drawing.Size(1, 1);
            this.people.Name = "people";
            this.people.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.people.Size = new System.Drawing.Size(188, 36);
            this.people.TabIndex = 1;
            this.people.Text = "查找人";
            this.people.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.people_ValueChanged);
            this.people.CheckedChanged += new System.EventHandler(this.people_CheckedChanged);
            // 
            // group
            // 
            this.group.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group.Location = new System.Drawing.Point(476, 34);
            this.group.MinimumSize = new System.Drawing.Size(1, 1);
            this.group.Name = "group";
            this.group.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.group.Size = new System.Drawing.Size(188, 36);
            this.group.TabIndex = 2;
            this.group.Text = "查找群组";
            this.group.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.group_ValueChanged);
            this.group.CheckedChanged += new System.EventHandler(this.group_CheckedChanged);
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.Color.Silver;
            this.TextBox.ForeReadOnlyColor = System.Drawing.Color.Silver;
            this.TextBox.Location = new System.Drawing.Point(159, 97);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox.Name = "TextBox";
            this.TextBox.ShowText = false;
            this.TextBox.Size = new System.Drawing.Size(414, 39);
            this.TextBox.Style = Sunny.UI.UIStyle.Custom;
            this.TextBox.TabIndex = 6;
            this.TextBox.Text = "请输入账号/手机号";
            this.TextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBox.Watermark = "";
            this.TextBox.MouseClick += new System.EventHandler(this.TextBox_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(99, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pname.Location = new System.Drawing.Point(263, 215);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(125, 29);
            this.pname.TabIndex = 8;
            this.pname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pname.Visible = false;
            // 
            // pacc
            // 
            this.pacc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pacc.Location = new System.Drawing.Point(263, 262);
            this.pacc.Name = "pacc";
            this.pacc.Size = new System.Drawing.Size(125, 29);
            this.pacc.TabIndex = 9;
            this.pacc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pacc.Visible = false;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(461, 249);
            this.add.MinimumSize = new System.Drawing.Size(1, 1);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(107, 42);
            this.add.TabIndex = 10;
            this.add.Text = "添加";
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // uiPipe1
            // 
            this.uiPipe1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPipe1.Location = new System.Drawing.Point(64, 310);
            this.uiPipe1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe1.Name = "uiPipe1";
            this.uiPipe1.Radius = 10;
            this.uiPipe1.Size = new System.Drawing.Size(612, 10);
            this.uiPipe1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe1.StyleCustomMode = true;
            this.uiPipe1.TabIndex = 11;
            this.uiPipe1.Text = "uiPipe1";
            this.uiPipe1.Visible = false;
            this.uiPipe1.ZoomScaleDisabled = true;
            // 
            // nopeople
            // 
            this.nopeople.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nopeople.Location = new System.Drawing.Point(64, 249);
            this.nopeople.Name = "nopeople";
            this.nopeople.Size = new System.Drawing.Size(652, 118);
            this.nopeople.TabIndex = 12;
            this.nopeople.Text = "查        无        此        人";
            this.nopeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nopeople.Visible = false;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(570, 97);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(47, 39);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search.Style = Sunny.UI.UIStyle.Custom;
            this.search.TabIndex = 5;
            this.search.TabStop = false;
            this.search.Text = null;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // groupjoin
            // 
            this.groupjoin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupjoin.Location = new System.Drawing.Point(492, 247);
            this.groupjoin.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupjoin.Name = "groupjoin";
            this.groupjoin.Size = new System.Drawing.Size(125, 44);
            this.groupjoin.TabIndex = 13;
            this.groupjoin.Text = "加  入";
            this.groupjoin.Visible = false;
            this.groupjoin.Click += new System.EventHandler(this.groupjoin_Click);
            // 
            // groupcreat
            // 
            this.groupcreat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupcreat.Location = new System.Drawing.Point(648, 111);
            this.groupcreat.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupcreat.Name = "groupcreat";
            this.groupcreat.Size = new System.Drawing.Size(113, 44);
            this.groupcreat.TabIndex = 14;
            this.groupcreat.Text = "创建群组";
            this.groupcreat.Visible = false;
            this.groupcreat.Click += new System.EventHandler(this.groupcreat_Click);
            // 
            // groupsure
            // 
            this.groupsure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupsure.Location = new System.Drawing.Point(519, 296);
            this.groupsure.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupsure.Name = "groupsure";
            this.groupsure.Size = new System.Drawing.Size(113, 41);
            this.groupsure.TabIndex = 15;
            this.groupsure.Text = "创  建";
            this.groupsure.Visible = false;
            this.groupsure.Click += new System.EventHandler(this.groupsure_Click);
            // 
            // group1
            // 
            this.group1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group1.Location = new System.Drawing.Point(109, 230);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(125, 29);
            this.group1.TabIndex = 16;
            this.group1.Text = "群组号：";
            this.group1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.group1.Visible = false;
            // 
            // groupnumber
            // 
            this.groupnumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupnumber.Location = new System.Drawing.Point(251, 223);
            this.groupnumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupnumber.MinimumSize = new System.Drawing.Size(1, 16);
            this.groupnumber.Name = "groupnumber";
            this.groupnumber.ShowText = false;
            this.groupnumber.Size = new System.Drawing.Size(188, 36);
            this.groupnumber.TabIndex = 17;
            this.groupnumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupnumber.Visible = false;
            this.groupnumber.Watermark = "";
            // 
            // groupname
            // 
            this.groupname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupname.Location = new System.Drawing.Point(251, 296);
            this.groupname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupname.MinimumSize = new System.Drawing.Size(1, 16);
            this.groupname.Name = "groupname";
            this.groupname.ShowText = false;
            this.groupname.Size = new System.Drawing.Size(188, 36);
            this.groupname.TabIndex = 19;
            this.groupname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupname.Visible = false;
            this.groupname.Watermark = "";
            // 
            // group2
            // 
            this.group2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group2.Location = new System.Drawing.Point(109, 303);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(125, 29);
            this.group2.TabIndex = 18;
            this.group2.Text = "群组名：";
            this.group2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.group2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "群组头像：";
            this.label1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(251, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 487);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupname);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.groupnumber);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.groupsure);
            this.Controls.Add(this.groupcreat);
            this.Controls.Add(this.groupjoin);
            this.Controls.Add(this.uiPipe1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pacc);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.group);
            this.Controls.Add(this.people);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.nopeople);
            this.Name = "Form1";
            this.Text = "查找";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UICheckBox people;
        private Sunny.UI.UICheckBox group;
        private Sunny.UI.UITextBox TextBox;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel pname;
        private Sunny.UI.UILabel pacc;
        private Sunny.UI.UIButton add;
        private Sunny.UI.UIPipe uiPipe1;
        private Sunny.UI.UILabel nopeople;
        private Sunny.UI.UIImageButton search;
        private Sunny.UI.UIButton groupjoin;
        private Sunny.UI.UIButton groupcreat;
        private Sunny.UI.UIButton groupsure;
        private Sunny.UI.UILabel group1;
        private Sunny.UI.UITextBox groupnumber;
        private Sunny.UI.UITextBox groupname;
        private Sunny.UI.UILabel group2;
        private Label label1;
        private PictureBox pictureBox2;
    }
}