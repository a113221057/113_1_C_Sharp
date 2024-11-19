namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
               
                double income = double.Parse(txtIncome.Text);
                double taxAmount = 0;  

                
                if (income <= 590000)
                {
                    taxAmount = income * 0.05;  
                }
                else if (income <= 1330000)
                {
                    taxAmount = 590000 * 0.05 + (income - 590000) * 0.12;  
                }
                else if (income <= 2660000)
                {
                    taxAmount = 590000 * 0.05 + (1330000 - 590000) * 0.12 + (income - 1330000) * 0.20; 
                }
                else if (income <= 4980000)
                {
                    taxAmount = 590000 * 0.05 + (1330000 - 590000) * 0.12 + (2660000 - 1330000) * 0.20 + (income - 2660000) * 0.30;  
                }
                else
                {
                    taxAmount = 590000 * 0.05 + (1330000 - 590000) * 0.12 + (2660000 - 1330000) * 0.20 + (4980000 - 2660000) * 0.30 + (income - 4980000) * 0.40;  
                }

                
                double netIncome = income - taxAmount;


                lblTaxAmount.Text = $"應繳稅額: {taxAmount:C}";
                lblNetIncome.Text = $"繳稅後淨收入: {netIncome:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的收入金額！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
            
        
    
