using System.Runtime.CompilerServices;

namespace Tutorial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            string output;
            output = "����" + txtyear.Text + "�~" + txtMonth.Text + "��" + txtDay.Text + "��" + "�P��" + txtDayOFweek.Text;

            lblshow.Text = output;
        }

        private void lblshow_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtDayOFweek.Text = "";
            txtDay.Text = "";
            txtMonth.Text = "";
            txtyear.Text = "";
            lblshow.Text = "";

        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
