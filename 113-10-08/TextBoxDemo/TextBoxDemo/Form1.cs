namespace TextBoxDemo
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

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            string fullName;//�ܼƤ@�w�n���ŧi���A��A�~�i�H�ϥ�
            string firstName;
            string lastName;

            firstName = txtFirstname.Text;
            lastName = txtLastname.Text;
            fullName = lastName + " " + firstName;

            lblShow.Text=fullName;

        }
    }
}
