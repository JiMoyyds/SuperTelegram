using ToAdd;
using success;
using SuperTelegram.Op.Information;
using SuperTelegram.Op.Ship;
using SuperTelegram.Op.Group;

namespace AddFriend
{
    public partial class Form1 : Form
    {
        public int account;
        public bool flag = true;
        public string photofile;
        public Form1()
        {
            InitializeComponent();
            account = ToAdd.ToAddAccount.Account;
        }

        private void search_Click(object sender, EventArgs e)
        {
            OpInformation op = new OpInformation(account);
            int findmessage;
            if (people.Checked)
            {
                findmessage = Convert.ToInt32(TextBox.Text);
                var message = op.GetSomeMessage(findmessage);
                if (message!=null)
                {
                    nopeople.Visible = false;
                    pictureBox1.Image = Image.FromFile(message.Value.url);
                    pname.Text = message.Value.name;
                    pacc.Text = message.Value.acc.ToString();
                    pictureBox1.Visible = true;
                    pname.Visible = true;
                    pacc.Visible = true;
                    uiPipe1.Visible = true;
                    add.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    pname.Visible = false;
                    pacc.Visible = false;
                    uiPipe1.Visible = false;
                    add.Visible = false;
                    nopeople.Visible = true;
                }
            }
            if (group.Checked)
            {
                int groupnumber = Convert.ToInt32(TextBox.Text);
                OpGroup gop= new OpGroup(groupnumber);
                nopeople.Visible = false;
                pictureBox1.Image = Image.FromFile(gop.GetPhoto());
                pname.Text = gop.GetName();
                pacc.Text = groupnumber.ToString();
                pictureBox1.Visible = true;
                pname.Visible = true;
                pacc.Visible = true;
                uiPipe1.Visible = true;
                groupjoin.Visible = true;
            }
        }

        private void TextBox_MouseClick(object sender, EventArgs e)
        {
            TextBox.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            OpShip op = new OpShip(account);
            int friend = Convert.ToInt32(pacc.Text);
            op.AddFriend(friend);
            success.Form1 form = new success.Form1();
            form.Show();
        }

        private void people_ValueChanged(object sender, bool value)
        {
            if (group.Checked)
            {
                group.Checked = false;
            }
        }

        private void group_ValueChanged(object sender, bool value)
        {
            if (people.Checked)
            {
                people.Checked = false;
            }
        }

        private void groupjoin_Click(object sender, EventArgs e)
        {
            int groupnumber = Convert.ToInt32(TextBox.Text);
            OpGroup op = new OpGroup(groupnumber);
            op.JoinGroup(account);
            MessageBox.Show("加入成功!");
        }

        private void groupcreat_Click(object sender, EventArgs e)
        {
            group1.Visible = true;
            group2.Visible = true;
            groupname.Visible = true;
            groupnumber.Visible = true;
            groupsure.Visible = true;
            label1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void group_CheckedChanged(object sender, EventArgs e)
        {
            if(flag)
            {
                groupcreat.Visible = true;
                flag = false;
            }
            else
            {
                groupcreat.Visible = false;
                flag = true;
            }
        }   

        private void people_CheckedChanged(object sender, EventArgs e)
        {
            groupcreat.Visible=false;
        }

        private void groupsure_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(groupnumber.Text);
            string name = groupname.Text;
            OpGroup op = new OpGroup(number);
            op.CreateGroup(account, name);
            try
            {
                op.RevisePhoto(photofile);
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            group1.Visible = false;
            group2.Visible = false;
            groupname.Visible = false;
            groupnumber.Visible = false;
            groupsure.Visible = false;
            label1.Visible = false;
            pictureBox2.Visible = false;
            MessageBox.Show("创建成功！");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "图像文件(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                photofile = file;
            }
        }
    }
}