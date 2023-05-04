using ToConversation;
using SuperTelegram.Op.Information;
using SuperTelegram.Op.Ship;
using Tofriend;
using friendinform;
using SuperTelegram.Db.SAR;
using System.Threading;

namespace Conversation
{
    public partial class Form1 : Form
    {
        public int myacc;
        public int friendacc;
        public int mark;
        public string lastContent="";

        public Form1()
        {
            InitializeComponent();
            myacc = ToConversation.Class1.myacc;
            friendacc = ToConversation.Class1.friendacc;
            OpShip sop = new OpShip(myacc);
            nameL.Text = sop.GetOneName(friendacc);
            accL.Text = friendacc.ToString();
            flowLayoutPanel1.WrapContents = false;

            OpInformation fop = new OpInformation(friendacc);
            pictureBox1.Image = Image.FromFile(fop.GetPhoto());
            int fmark = fop.GetMark(); 

            OpInformation mop = new OpInformation(myacc);
            pictureBox2.Image = Image.FromFile(mop.GetPhoto());
            int mmark = mop.GetMark();  

            pictureBox3.DoubleClick+=new EventHandler(pictureBox3_DoubleClick);

            CreateFile();

            mark = (fmark + mmark) / 2;
            SAR sar = new SAR(mark);
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
            SAR sar = new SAR(mark);
            while (true)
            {
                string content = sar.Receive();
                if (lastContent != content)
                {
                    lastContent = content;
                    Label label = new Label();
                    label.Text = content;
                    label.BackColor = Color.White;
                    label.AutoSize = true;
                    label.Font = new Font(label.Font.FontFamily, 10);

                    Panel panel = new Panel();
                    panel.Controls.Add(label);
                    label.Dock = DockStyle.Left;
                    panel.Size = new Size(555, 25);

                    if (this.IsHandleCreated)
                    {
                        this.Invoke(new Action(() =>
                        {

                            flowLayoutPanel1.Controls.Add(panel);
                        }));
                    }

                    //存聊天记录
                    string timeNow = System.DateTime.Now.ToString("F");
                    string filename = @"F:\SuperTelegram\" + myacc.ToString() + @"\" + friendacc.ToString() + ".txt";
                    System.IO.File.AppendAllText(filename, timeNow + "\n");
                    System.IO.File.AppendAllText(filename, "好友：" + content + "\n\n");
                }
                Thread.Sleep(200);
            }
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
            string filename = @"F:\SuperTelegram\" + myacc.ToString() + @"\" + friendacc.ToString() + ".txt";
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            SAR sar = new SAR(mark);
            string content = sendmessage.Text;
            sendmessage.Text = "";
            lastContent = content;
            Label label = new Label();
            label.Text = content;
            label.BackColor = Color.LightGreen;
            label.AutoSize = true;
            label.Font = new Font(label.Font.FontFamily,10);

            Panel panel = new Panel();
            panel.Controls.Add(label);
            label.Dock = DockStyle.Right;
            label.AutoSize = false;
            panel.Size = new Size(530, 25);
            flowLayoutPanel1.Controls.Add(panel);
            sar.Send(content);

            string timeNow = System.DateTime.Now.ToString("F");
            string filename = @"F:\SuperTelegram\" +myacc.ToString()+ @"\"+friendacc.ToString()+".txt";
            System.IO.File.AppendAllText(filename, timeNow+ "\n");
            System.IO.File.AppendAllText(filename,"我："+content+"\n\n");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            revisename.Visible = true;
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            var name = revisename.Text;
            OpShip ship = new OpShip(myacc);
            ship.ReviseRemark(friendacc, name);
            revisename.Visible=false;
            revisename.Text = "";
            nameL.Text = ship.GetOneName(friendacc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tofriend.Class1.friendacc = friendacc;
            friendinform.Form1 form = new friendinform.Form1();
            form.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SAR sar = new SAR(mark);
            sar.Send("");
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}