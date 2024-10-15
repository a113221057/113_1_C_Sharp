namespace Tutorial3_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbKM = new TextBox();
            txbLiter = new TextBox();
            lblShow = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(32, 46);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(32, 137);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(32, 236);
            label3.Name = "label3";
            label3.Size = new Size(191, 41);
            label3.TabIndex = 2;
            label3.Text = "公里/每公升";
            // 
            // txbKM
            // 
            txbKM.Font = new Font("Microsoft JhengHei UI", 24F);
            txbKM.Location = new Point(195, 46);
            txbKM.Name = "txbKM";
            txbKM.Size = new Size(215, 48);
            txbKM.TabIndex = 3;
            txbKM.TextChanged += txbKM_TextChanged;
            // 
            // txbLiter
            // 
            txbLiter.Font = new Font("Microsoft JhengHei UI", 24F);
            txbLiter.Location = new Point(195, 134);
            txbLiter.Name = "txbLiter";
            txbLiter.Size = new Size(215, 48);
            txbLiter.TabIndex = 5;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 12F);
            lblShow.Location = new Point(229, 233);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(263, 59);
            lblShow.TabIndex = 6;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            lblShow.Click += lblShow_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(93, 334);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(113, 65);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "計算";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(297, 334);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 65);
            btnExit.TabIndex = 8;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblShow);
            Controls.Add(txbLiter);
            Controls.Add(txbKM);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbKM;
        private TextBox txbLiter;
        private Label lblShow;
        private Button btnCalculate;
        private Button btnExit;
    }
}
