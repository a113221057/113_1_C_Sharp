using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0.0m; //用於保存總薪資
            decimal bonus = 0.0m; //保存獎金

           if(InputIsValid(ref grossPay,ref bonus))
            {
                decimal contribution = (grossPay + bonus) * CONTRIB_RATE; //保存員工貢獻
                contributionLabel.Text = contribution.ToString("c");
            }
           else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private bool InputIsValid(ref decimal grossPay,ref decimal bonus)
        {
            //標誌變數,指示輸入是否有效
            bool inputGood = false;
            //嘗試將總薪資文本框傳換十進制
            if(decimal.TryParse(grossPayTextBox.Text,out grossPay))
            {
                //嘗試獎金文本框轉換為10進制
                if(decimal.TryParse(bonusTextBox.Text,out bonus))
                {
                    //兩個輸入都有效
                    inputGood = true;
                }
            }
            //返回結果
            return inputGood;
        }
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
