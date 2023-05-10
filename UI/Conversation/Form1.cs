using ToConversation;
using SuperTelegram.Op.Information;
using SuperTelegram.Op.Ship;
using Tofriend;
using friendinform;
using SuperTelegram.Db.SAR;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System;

namespace Conversation
{
    public partial class Form1 : Form
    {
        public int myacc;
        public int friendacc;
        public int mark;
        public string lastContent="";
        public string lastfile = "1";

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

                    //�������¼
                    string timeNow = System.DateTime.Now.ToString("F");
                    string filename = @"F:\SuperTelegram\" + myacc.ToString() + @"\" + friendacc.ToString() + ".txt";
                    System.IO.File.AppendAllText(filename, timeNow + "\n");
                    System.IO.File.AppendAllText(filename, "���ѣ�" + content + "\n\n");

                    }

                //�����ļ�time
                //�����ļ�time
                //�����ļ�time
                string File = sar.ReceiveFile();
                if (File != lastfile)
                {
                    lastfile = File;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(@"F:\SuperTelegram\Photo\folder.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Size = new Size(150, 150);
                    pictureBox.Dock = DockStyle.Left;

                    Label label1 = new Label();
                    label1.Text = lastfile;

                    Panel panel1 = new Panel();
                    panel1.Controls.Add(pictureBox);
                    label1.Dock = DockStyle.Left;
                    label1.Location = new Point(20, 170);
                    panel1.Controls.Add(label1);
                    panel1.Size = new Size(530, 200);

                    if (this.IsHandleCreated)
                    {
                        this.Invoke(new Action(() =>
                        {
                            flowLayoutPanel1.Controls.Add(panel1);
                        }));
                    }

                    string hexString = sar.ReceivePhoto();
                    //����hexString���û���תΪ���ļ�
                    byte[] data = new byte[hexString.Length / 2];
                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    }

                    string filename = lastfile.Substring(0, File.LastIndexOf("."));
                    string style = lastfile.Substring(lastfile.LastIndexOf("."), lastfile.Length - lastfile.LastIndexOf("."));

                    // �Ӷ����������лָ�ԭʼ�ļ�
                    string restoredFilePath = @"F:\SuperTelegram\" + myacc.ToString() + @"\Temp\" + filename + style;
                    System.IO.File.WriteAllBytes(restoredFilePath, data);

                    void PictureBox_Click(object sender, EventArgs e)
                    {
                        ProcessStartInfo processStartInfo = new ProcessStartInfo(restoredFilePath);
                        Process process = new Process();
                        process.StartInfo = processStartInfo;
                        process.StartInfo.UseShellExecute = true;
                        process.Start();
                    }
                    pictureBox.Click += new System.EventHandler(PictureBox_Click);

                }
                Thread.Sleep(200);
            }
        }

        private void CreateFile()
        {
            //�������¼
            //�����ļ�
            string path = @"F:\SuperTelegram\" + myacc.ToString();
            //�ж��ļ����Ƿ����
            if (!Directory.Exists(path))
            {
                //�����ļ���
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {

                }
            }

            //�ж��ļ��治����
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


            string patht = @"F:\SuperTelegram\" + myacc.ToString()+@"\Temp";
            //�ж��ļ����Ƿ����
            if (!Directory.Exists(patht))
            {
                //�����ļ���
                try
                {
                    Directory.CreateDirectory(patht);
                }
                catch (Exception e)
                {

                }
            }

            string pathf = @"F:\SuperTelegram\" + friendacc.ToString() + @"\Temp";
            //�ж��ļ����Ƿ����
            if (!Directory.Exists(pathf))
            {
                //�����ļ���
                try
                {
                    Directory.CreateDirectory(pathf);
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
            System.IO.File.AppendAllText(filename,"�ң�"+content+"\n\n");
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
            sar.SendFile("1");
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SAR sar = new SAR(mark);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//��ֵȷ���Ƿ����ѡ�����ļ�
            dialog.Title = "��ѡ���ļ���";
            dialog.Filter = "�ļ�(*.jpg;*.jpeg;*.gif;*.png;*.doc;*.pdf;*.docx;*.txt;*.xls)|*.jpg;*.jpeg;*.gif;*.png;*.doc;*.pdf;*.docx;*.txt;*.xls";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                string style = file.Substring(file.LastIndexOf(@"\") + 1,file.Length-1-file.LastIndexOf(@"\"));
                lastfile = style;
                
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(@"F:\SuperTelegram\Photo\folder.png");
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(150, 150);
                pictureBox.Dock = DockStyle.Right;

                Label label = new Label();
                label.Text = style;
                label.Dock = DockStyle.Right;
                label.AutoSize = false;
                label.Location = new Point(500, 1000);

                Panel panel = new Panel();
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                panel.Size = new Size(530, 200);
                flowLayoutPanel1.Controls.Add(panel);

                void PictureBox_Click(object sender, EventArgs e)
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo(file);
                    Process process = new Process();
                    process.StartInfo = processStartInfo;
                    process.StartInfo.UseShellExecute = true;
                    process.Start();
                }

                pictureBox.Click += new System.EventHandler(PictureBox_Click);

                // ��ȡ�ļ�������ת��Ϊ����������
                byte[] binaryData = File.ReadAllBytes(file);

                //��hexString�������ݿ�
                string hexString = BitConverter.ToString(binaryData).Replace("-", "");

                sar.SendPhoto(hexString);
                sar.SendFile(style);

            }
        }
    }
}