using SuperTelegram.Op.Information;
using Tofriend;

namespace friendinform
{
    public partial class Form1 : Form
    {
        public int acc;
        public Form1()
        {
            InitializeComponent();
            acc = Tofriend.Class1.friendacc;
            OpInformation op = new OpInformation(acc);
            nameL.Text = op.GetName();
            phoneL.Text = op.GetPhone().ToString();
            emailL.Text = op.GetEmail();
            introduceL.Text = op.GetIntroduce();
        }
    }
}