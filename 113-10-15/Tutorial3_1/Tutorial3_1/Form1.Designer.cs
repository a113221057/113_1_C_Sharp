namespace Tutorial3_1
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
            label4 = new Label();
            txtDayOFweek = new TextBox();
            txtMonth = new TextBox();
            txtyear = new TextBox();
            txtDay = new TextBox();
            lblshow = new Label();
            btnShowDate = new Button();
            btnclear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(22, 57);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(22, 116);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(22, 172);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(22, 231);
            label4.Name = "label4";
            label4.Size = new Size(82, 41);
            label4.TabIndex = 3;
            label4.Text = "年份";
            label4.Click += label4_Click;
            // 
            // txtDayOFweek
            // 
            txtDayOFweek.Font = new Font("Microsoft JhengHei UI", 24F);
            txtDayOFweek.Location = new Point(170, 57);
            txtDayOFweek.Name = "txtDayOFweek";
            txtDayOFweek.Size = new Size(251, 48);
            txtDayOFweek.TabIndex = 4;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Microsoft JhengHei UI", 24F);
            txtMonth.Location = new Point(170, 169);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(251, 48);
            txtMonth.TabIndex = 5;
            // 
            // txtyear
            // 
            txtyear.Font = new Font("Microsoft JhengHei UI", 24F);
            txtyear.Location = new Point(170, 231);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(251, 48);
            txtyear.TabIndex = 6;
            // 
            // txtDay
            // 
            txtDay.Font = new Font("Microsoft JhengHei UI", 24F);
            txtDay.Location = new Point(170, 109);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(251, 48);
            txtDay.TabIndex = 7;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 24F);
            lblshow.Location = new Point(12, 295);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(514, 61);
            lblshow.TabIndex = 8;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            lblshow.Click += lblshow_Click;
            // 
            // btnShowDate
            // 
            btnShowDate.Location = new Point(60, 382);
            btnShowDate.Name = "btnShowDate";
            btnShowDate.Size = new Size(115, 58);
            btnShowDate.TabIndex = 9;
            btnShowDate.Text = "顯示完整日期";
            btnShowDate.UseVisualStyleBackColor = true;
            btnShowDate.Click += btnShowDate_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(181, 382);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(115, 58);
            btnclear.TabIndex = 10;
            btnclear.Text = "清空內容";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(302, 382);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 58);
            btnExit.TabIndex = 11;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 466);
            Controls.Add(btnExit);
            Controls.Add(btnclear);
            Controls.Add(btnShowDate);
            Controls.Add(lblshow);
            Controls.Add(txtDay);
            Controls.Add(txtyear);
            Controls.Add(txtMonth);
            Controls.Add(txtDayOFweek);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox txtDayOFweek;
        private TextBox txtMonth;
        private TextBox txtyear;
        private TextBox txtDay;
        private Label lblshow;
        private Button btnShowDate;
        private Button btnclear;
        private Button btnExit;
    }
}
