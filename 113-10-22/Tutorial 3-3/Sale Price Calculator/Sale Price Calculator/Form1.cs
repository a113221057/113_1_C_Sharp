using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originslPrice;
            decimal discountPercentage;
            decimal salePrice;
            try
            {
                originslPrice = decimal.Parse(originalPriceTextBox.Text);
                discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
                salePrice = originslPrice - (originslPrice * discountPercentage / 100);

                salePriceLabel.Text = salePrice.ToString("c");
            }
            catch
            {

                MessageBox.Show("輸入資料格式錯誤");
                originalPriceTextBox.Text = "";
                discountPercentageTextBox.Text = "";
                originalPriceTextBox.Focus();
            }
            } 

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();


        }
      
    }
}
