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
            string fullName;
            string firstName;
            string lastName;

            firstName = txtFirstname.Text;
            lastName = txtFirstname.Text;
            fullName = lastName + " " + firstName;

            lblShow.Text=fullName;

        }
    }
}
