using login;
using enroll;
using findpass;

namespace First
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void log_Click(object sender, EventArgs e)
        {
            login.login log = new login.login();
            log.Show();
            this.Hide();
        }

        private void en_Click(object sender, EventArgs e)
        {
            enroll.Form1 enrollForm = new enroll.Form1();
            enrollForm.ShowDialog();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {
            findpass.Form1 find = new findpass.Form1();
            find.ShowDialog();
        }
    }
}