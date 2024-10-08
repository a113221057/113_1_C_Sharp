namespace Tutonial2_5
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
            ptxBack = new PictureBox();
            ptxForm = new PictureBox();
            btnShowBack = new Button();
            btnShowForm = new Button();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxForm).BeginInit();
            SuspendLayout();
            // 
            // ptxBack
            // 
            ptxBack.Image = Properties.Resources.Backface_Blue;
            ptxBack.Location = new Point(25, 43);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(167, 234);
            ptxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxBack.TabIndex = 0;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            ptxBack.Click += pictureBox1_Click;
            // 
            // ptxForm
            // 
            ptxForm.Image = Properties.Resources.Ace_Spades;
            ptxForm.Location = new Point(268, 43);
            ptxForm.Name = "ptxForm";
            ptxForm.Size = new Size(167, 234);
            ptxForm.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxForm.TabIndex = 1;
            ptxForm.TabStop = false;
            ptxForm.Visible = false;
            ptxForm.Click += pictureBox2_Click;
            // 
            // btnShowBack
            // 
            btnShowBack.Font = new Font("Microsoft JhengHei UI", 24F);
            btnShowBack.Location = new Point(6, 315);
            btnShowBack.Name = "btnShowBack";
            btnShowBack.Size = new Size(213, 52);
            btnShowBack.TabIndex = 2;
            btnShowBack.Text = "背面";
            btnShowBack.UseVisualStyleBackColor = true;
            btnShowBack.Visible = false;
            btnShowBack.Click += btnShowBack_Click;
            // 
            // btnShowForm
            // 
            btnShowForm.Font = new Font("Microsoft JhengHei UI", 24F);
            btnShowForm.Location = new Point(268, 315);
            btnShowForm.Name = "btnShowForm";
            btnShowForm.Size = new Size(183, 56);
            btnShowForm.TabIndex = 3;
            btnShowForm.Text = "正面";
            btnShowForm.UseVisualStyleBackColor = true;
            btnShowForm.Visible = false;
            btnShowForm.Click += btnShow;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft JhengHei UI", 16F);
            btnexit.Location = new Point(96, 417);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(318, 66);
            btnexit.TabIndex = 4;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 551);
            Controls.Add(btnexit);
            Controls.Add(btnShowForm);
            Controls.Add(btnShowBack);
            Controls.Add(ptxForm);
            Controls.Add(ptxBack);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxBack;
        private PictureBox ptxForm;
        private Button btnShowBack;
        private Button btnShowForm;
        private Button btnexit;
    }
}
