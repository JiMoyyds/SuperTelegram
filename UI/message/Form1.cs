using SuperTelegram.Op.Information;
using transfer;


namespace message
{
    public partial class Form1 : Form
    {
        public int account;
        public Form1()
        {
            InitializeComponent();
            account = transferpass.account;
            OpInformation op = new OpInformation(account);
            pictureBox1.Image = Image.FromFile(op.GetPhoto());
            name.Text=op.GetName();
            introduce.Text=op.GetIntroduce();
            phone.Text =op.GetPhone().ToString();
            email.Text=op.GetEmail();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpInformation op = new OpInformation(account);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//��ֵȷ���Ƿ����ѡ�����ļ�
            dialog.Title = "��ѡ���ļ���";
            dialog.Filter = "ͼ���ļ�(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               string file = dialog.FileName;
               pictureBox1.Image = Image.FromFile(file);
               op.RevisePhoto(file);
            }
        }

        private void introduce_TextChanged(object sender, EventArgs e)
        {

        }

        private void mod_Click(object sender, EventArgs e)
        {
            name.ReadOnly = false;
            introduce.ReadOnly = false;
            phone.ReadOnly = false;
            email.ReadOnly = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string introduce = this.introduce.Text;
            int phone = Convert.ToInt32(this.phone.Text);
            string email = this.email.Text;
            OpInformation op = new OpInformation(account);
            op.ReviseMessage(name, introduce, phone, email);
            this.name.ReadOnly = true;
            this.introduce.ReadOnly = true;
            this.phone.ReadOnly = true;
            this.email.ReadOnly = true;
        }
    }
}