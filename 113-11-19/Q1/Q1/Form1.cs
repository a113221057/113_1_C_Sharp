namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculateArea_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtlength.Text);
            double width = double.Parse(txtWidth.Text);
            double area = length * width;
            MessageBox.Show($"�Цa���n���G{area} ������", "�p�⵲�G");

        }
        private void btnCalculatePerimeter_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtlength.Text);
            double width = double.Parse(txtWidth.Text);
            double perimeter = 2 * (length + width);

            MessageBox.Show($"�Цa�P�����G{perimeter} ���", "�p�⵲�G");
        }
        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtlength.Text);
            double width = double.Parse(txtWidth.Text);
            double unitCost = double.Parse(txtunitcost.Text);
            double perimeter = 2 * (length + width);
            double totalCost = unitCost * perimeter;

            MessageBox.Show($"�����`�������G{totalCost} ���f��", "�p�⵲�G");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




