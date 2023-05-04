using ToGroup;
using SuperTelegram.Op.Group;
using SuperTelegram.Db.SAR;
using SuperTelegram.Op.Information;
using SuperTelegram.Op.Ship;


namespace GroupConversation
{
    public partial class Form1 : Form
    {
        public int myacc;
        public int groupacc;
        public string lastContent = "";

        public Form1()
        {
            InitializeComponent();

            myacc = ToGroup.Class1.myacc;
            groupacc = ToGroup.Class1.groupacc;

            OpGroup opg = new OpGroup(groupacc);
            
            //用来判定是不是群主
            if (opg.IsCreated(myacc))
            {
                pictureBox3.Visible= true;
            }
            pictureBox3.DoubleClick += new EventHandler(pictureBox3_DoubleClick);

            nameL.Text = opg.GetName();
            accL.Text = groupacc.ToString();
            flowLayoutPanel1.WrapContents = false;

            pictureBox1.Image = Image.FromFile(opg.GetPhoto());

            //这一部分是新panel中显示该群有什么人
            var list = opg.AllMember();
            if (list.Count == 1)
            {
                OpInformation opi = new OpInformation(list[0]);
                picture1.Visible= true;
                picture1.Image = Image.FromFile(opi.GetPhoto());
                label1.Visible= true;
                label1.Text=list[0].ToString();
            }
            if (list.Count == 2)
            {
                OpInformation opi1 = new OpInformation(list[0]);
                picture1.Visible = true;
                picture1.Image = Image.FromFile(opi1.GetPhoto());
                label1.Visible = true;
                label1.Text = list[0].ToString();

                OpInformation opi2 = new OpInformation(list[1]);
                picture1.Visible = true;
                picture1.Image = Image.FromFile(opi2.GetPhoto());
                label1.Visible = true;
                label1.Text = list[1].ToString();
            }
            if (list.Count == 3)
            {
                OpInformation opi1 = new OpInformation(list[0]);
                picture1.Visible = true;
                picture1.Image = Image.FromFile(opi1.GetPhoto());
                label1.Visible = true;
                label1.Text = list[0].ToString();

                OpInformation opi2 = new OpInformation(list[1]);
                picture2.Visible = true;
                picture2.Image = Image.FromFile(opi2.GetPhoto());
                label2.Visible = true;
                label2.Text = list[1].ToString();

                OpInformation opi3 = new OpInformation(list[2]);
                picture3.Visible = true;
                picture3.Image = Image.FromFile(opi2.GetPhoto());
                label3.Visible = true;
                label3.Text = list[2].ToString();
            }


            //下面一部分都是跟通信有关系
            CreateFile();

            SAR sar = new SAR(groupacc);
            if (sar.IsCreate())
            {
                sar.Create();
            }

            CheckForIllegalCrossThreadCalls = false;

            Thread thread = new Thread(Receive);
            thread.Start();
        }

        
        private void Receive()
        {
             SAR sar = new SAR(groupacc);
             while (true)
             {
                 string content = sar.Receive();
                 if (lastContent != content)
                 {
                     lastContent = content;
                     
                     string str = content.Substring(content.IndexOf(":") + 1, content.Length - content.IndexOf(":") - 1);
                     string number = content.Substring(0, content.IndexOf(":"));

                     Label label = new Label();
                     label.Text = str;
                     label.Font = new Font(label.Font.FontFamily, 10);
                     label.BackColor = Color.White;
                     label.Location = new Point(5, 50);

                     OpInformation opi = new OpInformation(Convert.ToInt32(number));
                     PictureBox picture = new PictureBox();
                     picture.Image = Image.FromFile(opi.GetPhoto());
                     picture.Size=new Size(40,40);
                     picture.Location = new Point(5,5);
                     picture.SizeMode=PictureBoxSizeMode.Zoom;

                     Label label2 = new Label();
                     label2.Text = number;
                     label2.Location = new Point(50,5);

                     Panel panel = new Panel();
                     panel.Controls.Add(picture);
                     panel.Controls.Add(label2);
                     panel.Controls.Add(label);
                     panel.Size = new Size(530, 90);

                     if (this.IsHandleCreated)
                     {
                         this.Invoke(new Action(() =>
                         {

                             flowLayoutPanel1.Controls.Add(panel);
                         }));
                     }

                     //存聊天记录
                     string timeNow = System.DateTime.Now.ToString("F");
                     string filename = @"F:\SuperTelegram\" + myacc.ToString() + @"\群组" + groupacc.ToString() + ".txt";
                     System.IO.File.AppendAllText(filename, timeNow + "\n");
                     System.IO.File.AppendAllText(filename, "好友：" +content + "\n\n");
                 }
                 Thread.Sleep(200);
             }
 
        }

        private void sure_Click(object sender, EventArgs e)
        {
            SAR sar = new SAR(groupacc);
            string str = sendmessage.Text;
            string content = myacc.ToString()+":"+str;
            sendmessage.Text = "";
            lastContent = content;

            Label label = new Label();
            label.Text = str;
            label.BackColor = Color.LightGreen;
            label.Font = new Font(label.Font.FontFamily, 10);

            Panel panel = new Panel();
            label.Dock = DockStyle.Right;
            label.AutoSize = false;
            panel.Size = new Size(530, 25);


            //换行未能实现
/*            if (label.Width > 8)
            {
                int times = label.Width/8+1;
                label.AutoSize=false;
                label.Size = new Size(400, times * 20);
                panel.Size=new Size(530,times * 20);
            }
*/
            panel.Controls.Add(label);
            flowLayoutPanel1.Controls.Add(panel);
            sar.Send(content);

            string timeNow = System.DateTime.Now.ToString("F");
            string filename = @"F:\SuperTelegram\" + myacc.ToString() + @"\群组" + groupacc.ToString() + ".txt";
            System.IO.File.AppendAllText(filename, timeNow + "\n");
            System.IO.File.AppendAllText(filename, "我：" + str + "\n\n");
        }

        private void CreateFile()
        {
            //存聊天记录
            //存入文件
            string path = @"F:\SuperTelegram\" + myacc.ToString();
            //判断文件夹是否存在
            if (!Directory.Exists(path))
            {
                //创建文件夹
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {

                }
            }

            //判定文件存不存在
            string filename = @"F:\SuperTelegram\" + myacc.ToString() + @"\群组" + groupacc.ToString() + ".txt";
            if (!File.Exists(filename))
            {
                try
                {
                    File.Create(filename).Close();
                }
                catch (Exception e)
                {

                }
            }
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            var name = revisename.Text;
            OpGroup opg = new OpGroup(groupacc);
            opg.ReviseGroupName(name);
            revisename.Visible = false;
            revisename.Text = "";
            nameL.Text = opg.GetName();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            revisename.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpGroup opg = new OpGroup(groupacc);
            if (opg.IsCreated(myacc))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;//该值确定是否可以选择多个文件
                dialog.Title = "请选择文件夹";
                dialog.Filter = "图像文件(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string file = dialog.FileName;
                    pictureBox1.Image = Image.FromFile(file);
                    opg.RevisePhoto(file);
                }
                pictureBox1.Image = Image.FromFile(opg.GetPhoto());
            }
        }


        private void uiButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SAR sar = new SAR(groupacc);
            sar.Send("");
        }
    }
}