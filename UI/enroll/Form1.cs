using SuperTelegram.Op.Information;
using login;
using System.Threading;
namespace enroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sure_Click(object sender, EventArgs e)
        {
            var account = Convert.ToInt32(acc.Text);
            var name = this.name.Text;
            var phone = Convert.ToInt32(this.phone.Text);   
            var email = this.email.Text;   
            var pass1 = this.pass1.Text;
            var pass2 = this.pass2.Text;
            if (pass1 == pass2)
            {
                OpInformation op = new OpInformation(account);

                op.CreatMessage(pass1, email, phone, name);
                login.login log = new login.login();
                Thread.Sleep(1000);
                log.Show();
                this.Close();
            }
            else
            {
                ErrorText.Text = "密码两次输入不一致";
                this.pass1.Text = "";
                this.pass2.Text = "";
            }
        }
    }
}