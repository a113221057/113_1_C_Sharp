namespace Tutorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double average;

            kms = double.Parse(txbKM.Text);
            liters = double.Parse(txbLiter.Text);
            average = kms / liters;

            lblShow.Text = average.ToString("F3");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
