using SuperTelegram.Op.Information;

namespace findpass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sure_Click(object sender, EventArgs e)
        {
            var account = Convert.ToInt32(acc.Text);
            var email = this.email.Text;
            var phone = Convert.ToInt32(this.phone.Text);
            var pass1 = this.pass1.Text;
            var pass2 = this.pass2.Text;
            OpInformation op = new OpInformation(account);
            if (op.CompareMessage(phone, email))
            {
                if (pass1 == pass2)
                {
                    op.RevisePassWord(pass1);
                    ErrorText.Text = "�����޸ĳɹ�";
                }
                else
                {
                    ErrorText.Text = "�����������벻һ��";
                    this.pass1.Text ="";
                    this.pass2.Text = "";
                }
            }
            else
            {
                ErrorText.Text = "������Ϣ����";
                this.acc.Text = "";
                this.email.Text = "";
                this.phone.Text = "";
                this.pass1.Text = "";
                this.pass2.Text = "";
            }
        }
    }
}