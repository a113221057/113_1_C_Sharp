namespace Q1
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
            txtlength = new TextBox();
            txtunitcost = new TextBox();
            txtWidth = new TextBox();
            btncalculateArea = new Button();
            btnCalculatePerimeter = new Button();
            btnCalculateCost = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // txtlength
            // 
            txtlength.Location = new Point(327, 84);
            txtlength.Name = "txtlength";
            txtlength.Size = new Size(147, 23);
            txtlength.TabIndex = 0;
            // 
            // txtunitcost
            // 
            txtunitcost.Location = new Point(327, 172);
            txtunitcost.Name = "txtunitcost";
            txtunitcost.Size = new Size(147, 23);
            txtunitcost.TabIndex = 1;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(327, 124);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(147, 23);
            txtWidth.TabIndex = 2;
            // 
            // btncalculateArea
            // 
            btncalculateArea.Location = new Point(150, 331);
            btncalculateArea.Name = "btncalculateArea";
            btncalculateArea.Size = new Size(75, 23);
            btncalculateArea.TabIndex = 3;
            btncalculateArea.Text = "Area";
            btncalculateArea.UseVisualStyleBackColor = true;
            btncalculateArea.Click += btncalculateArea_Click;
            // 
            // btnCalculatePerimeter
            // 
            btnCalculatePerimeter.Location = new Point(258, 331);
            btnCalculatePerimeter.Name = "btnCalculatePerimeter";
            btnCalculatePerimeter.Size = new Size(75, 23);
            btnCalculatePerimeter.TabIndex = 4;
            btnCalculatePerimeter.Text = "Boundary";
            btnCalculatePerimeter.UseVisualStyleBackColor = true;
            btnCalculatePerimeter.Click += btnCalculatePerimeter_Click;
            // 
            // btnCalculateCost
            // 
            btnCalculateCost.Location = new Point(371, 331);
            btnCalculateCost.Name = "btnCalculateCost";
            btnCalculateCost.Size = new Size(75, 23);
            btnCalculateCost.TabIndex = 5;
            btnCalculateCost.Text = "cost";
            btnCalculateCost.UseVisualStyleBackColor = true;
            btnCalculateCost.Click += btnCalculateCost_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 92);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 6;
            label1.Text = "length of the field";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 127);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 7;
            label2.Text = "width of the field";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 175);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 8;
            label3.Text = "Unit cost of the Fencing";
            // 
            // button4
            // 
            button4.Location = new Point(495, 331);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalculateCost);
            Controls.Add(btnCalculatePerimeter);
            Controls.Add(btncalculateArea);
            Controls.Add(txtWidth);
            Controls.Add(txtunitcost);
            Controls.Add(txtlength);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtlength;
        private TextBox txtunitcost;
        private TextBox txtWidth;
        private Button btncalculateArea;
        private Button btnCalculatePerimeter;
        private Button btnCalculateCost;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
    }
}
