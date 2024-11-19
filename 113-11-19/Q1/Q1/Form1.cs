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
            MessageBox.Show($"田地面積為：{area} 平方單位", "計算結果");

        }
        private void btnCalculatePerimeter_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtlength.Text);
            double width = double.Parse(txtWidth.Text);
            double perimeter = 2 * (length + width);

            MessageBox.Show($"田地周長為：{perimeter} 單位", "計算結果");
        }
        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtlength.Text);
            double width = double.Parse(txtWidth.Text);
            double unitCost = double.Parse(txtunitcost.Text);
            double perimeter = 2 * (length + width);
            double totalCost = unitCost * perimeter;

            MessageBox.Show($"圍欄總成本為：{totalCost} 單位貨幣", "計算結果");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




