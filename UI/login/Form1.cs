using SuperTelegram.Op.Information;
using main;
using transfer;
using System.Threading;

namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            var account = Convert.ToInt32(acc.Text);
            var password = pass.Text;
            var very = verify.Text;
            int i = 3;
            OpInformation op = new OpInformation(account);
            if (true/*op.ComparePassWord(password)&&(very==uiVerificationCode1.Code)*/)
            {
                transferpass.account=account;
                main.Form1 form1 = new main.Form1();
                op.SetUpRealState();
                acc.Text = "";
                pass.Text = "";
                verify.Text = "";
                uiVerificationCode1.Refresh();
                form1.Show();
                //下一个界面
            }
            else
            {
                acc.Text = "";
                pass.Text = "";
                verify.Text = "";
                uiVerificationCode1.Refresh();
                i--;
                if (i == 0)
                {
                    this.Close();
                }
                MessageBox.Show("密码错误/验证码错误", "ERROR");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}