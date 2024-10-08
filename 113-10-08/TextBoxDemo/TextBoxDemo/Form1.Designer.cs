namespace TextBoxDemo
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
            btnconfirm = new Button();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            lblShow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(58, 68);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 0;
            label1.Text = "Firstname:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(64, 163);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 1;
            label2.Text = "Lastname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(64, 261);
            label3.Name = "label3";
            label3.Size = new Size(162, 41);
            label3.TabIndex = 2;
            label3.Text = "Fullname:";
            // 
            // btnconfirm
            // 
            btnconfirm.Font = new Font("Microsoft JhengHei UI", 22F);
            btnconfirm.Location = new Point(264, 318);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(231, 94);
            btnconfirm.TabIndex = 3;
            btnconfirm.Text = "Confirm";
            btnconfirm.UseVisualStyleBackColor = true;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Microsoft JhengHei UI", 24F);
            txtFirstname.Location = new Point(238, 68);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(184, 48);
            txtFirstname.TabIndex = 4;
            txtFirstname.TextChanged += txtFirstname_TextChanged;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Microsoft JhengHei UI", 24F);
            txtLastname.Location = new Point(238, 163);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(184, 48);
            txtLastname.TabIndex = 5;
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 24F);
            lblShow.Location = new Point(252, 261);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(2, 43);
            lblShow.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblShow);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(btnconfirm);
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
        private Button btnconfirm;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private Label lblShow;
    }
}
