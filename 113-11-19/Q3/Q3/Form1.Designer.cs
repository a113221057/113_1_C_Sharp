namespace Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIncome = new TextBox();
            btnCalculate = new Button();
            lblTaxAmount = new Label();
            lblNetIncome = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(346, 117);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(100, 23);
            txtIncome.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(248, 172);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(99, 23);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate tex";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTaxAmount
            // 
            lblTaxAmount.AutoSize = true;
            lblTaxAmount.Location = new Point(455, 218);
            lblTaxAmount.Name = "lblTaxAmount";
            lblTaxAmount.Size = new Size(0, 15);
            lblTaxAmount.TabIndex = 2;
            // 
            // lblNetIncome
            // 
            lblNetIncome.AutoSize = true;
            lblNetIncome.Location = new Point(220, 218);
            lblNetIncome.Name = "lblNetIncome";
            lblNetIncome.Size = new Size(0, 15);
            lblNetIncome.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(359, 290);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 90);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 5;
            label1.Text = "enter your taxable";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblNetIncome);
            Controls.Add(lblTaxAmount);
            Controls.Add(btnCalculate);
            Controls.Add(txtIncome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIncome;
        private Button btnCalculate;
        private Label lblTaxAmount;
        private Label lblNetIncome;
        private Button button1;
        private Label label1;
    }
}
