using SuperTelegram.Op.Information;
using SuperTelegram.Op.Ship;
using SuperTelegram.Op.Group;
using message;
using transfer;
using ToAdd;
using AddFriend;
using Conversation;
using ToConversation;
using GroupConversation;
using ToGroup;

namespace main
{
    public partial class Form1 : Form
    {
        public int account;
        public Form1()
        {
            InitializeComponent();
            Refresh();
        }

        public void Refresh()
        {
            account = transferpass.account;
            OpInformation op = new OpInformation(account);
            photo.Image = Image.FromFile(op.GetPhoto());
            name.Text = op.GetName();

            flowLayoutPanel1.Controls.Clear();
            //��֪���Ǹ�ɶ��
            //PictureBox p = new PictureBox();
            //p.Image = Image.FromFile(op.GetPhoto());

            //�ⶼ����
            OpShip ops = new OpShip(account);
            var message = ops.GetAllFriend();
            for (int i = 0; i < message.Count; i++)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Size = new Size(301, 80);
                panel.BackColor= Color.LightBlue;
                PictureBox picture = new PictureBox();
                picture.SizeMode=PictureBoxSizeMode.Zoom;
                picture.Size = new Size(70, 70);
                picture.Location = new Point(0, 5);
                picture.Image=Image.FromFile(message[i].photo);
                Label labelname = new Label();
                labelname.Text = message[i].remark;
                Label labelacc = new Label();
                string friend = message[i].number.ToString();
                labelacc.Text = "("+friend+")";
                panel.Controls.Add(picture);
                panel.Controls.Add(labelname);
                panel.Controls.Add(labelacc);
                flowLayoutPanel1.Controls.Add(panel);

                void Panel_Click(object sender, EventArgs e)
                {
                    ToConversation.Class1.myacc = account;
                    ToConversation.Class1.friendacc = Int32.Parse(friend);
                    Conversation.Form1 form = new Conversation.Form1();
                    form.Show();
                }

                panel.Click += new System.EventHandler(Panel_Click);
            }

            //������Ⱥ����ʾ
            OpGroup opg = new OpGroup();
            var groupme = opg.FindWhereGroup(account);
            for (int i = 0; i < groupme.Count; i++)
            {
                OpGroup group = new OpGroup(groupme[i]);
                FlowLayoutPanel gpanel = new FlowLayoutPanel();
                gpanel.Size = new Size(301, 80);
                gpanel.BackColor = Color.LightBlue;
                PictureBox picture = new PictureBox();
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Size = new Size(70, 70);
                picture.Location = new Point(0, 5);
                picture.Image = Image.FromFile(group.GetPhoto());
                Label labelname = new Label();
                labelname.Text = group.GetName();
                Label labelacc = new Label();
                string friend = groupme[i].ToString();
                labelacc.Text = "(" + friend + ")";
                gpanel.Controls.Add(picture);
                gpanel.Controls.Add(labelname);
                gpanel.Controls.Add(labelacc);
                flowLayoutPanel1.Controls.Add(gpanel);

                int nowGroupNumber = groupme[i];

                void GPanel_Click(object sender, EventArgs e)
                {
                    ToGroup.Class1.groupacc = nowGroupNumber;
                    ToGroup.Class1.myacc = account;

                    //����ط���Ⱥ������������ĵط������ڵ�Form1�Ǹ��˵ģ���Ҫ�޸�
                    GroupConversation.Form1 form = new GroupConversation.Form1(); ;
                    form.Show();
                }

                gpanel.Click += new System.EventHandler(GPanel_Click);
            }
        }
        private void photo_Click(object sender, EventArgs e)
        {
            message.Form1 mess = new message.Form1();
            mess.account = account;
            mess.ShowDialog();
        }

        private void uiSwitch1_ValueChanged(object sender, bool value)
        {
            if (uiPanel1.FillColor == Color.DeepSkyBlue)
            {
                uiSwitch1.BackColor = Color.Black;
                name.BackColor = Color.Black;
                name.ForeColor = Color.White;
                uiPanel1.FillColor = Color.Black;
                uiPanel2.FillColor = Color.Black;
                uiPanel3.FillColor = Color.DimGray;
            }
            else
            {
                uiSwitch1.BackColor= Color.DeepSkyBlue;
                name.BackColor= Color.DeepSkyBlue;
                name.ForeColor= Color.Black;
                uiPanel1.FillColor= Color.DeepSkyBlue;
                uiPanel2.FillColor = Color.DeepSkyBlue;
                uiPanel3.FillColor= Color.Gainsboro;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ToAdd.ToAddAccount.Account = account;
            AddFriend.Form1 form1 = new AddFriend.Form1();
            form1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}