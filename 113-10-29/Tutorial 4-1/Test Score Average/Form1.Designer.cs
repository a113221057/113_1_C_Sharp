﻿namespace Test_Score_Average
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test3promptLabel = new System.Windows.Forms.Label();
            this.test2promptLabel = new System.Windows.Forms.Label();
            this.test1promptLabel = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testScoreGroupBox
            // 
            this.testScoreGroupBox.Controls.Add(this.outputDescriptionLabel);
            this.testScoreGroupBox.Controls.Add(this.averageLabel);
            this.testScoreGroupBox.Controls.Add(this.test3promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test2promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test1promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test3TextBox);
            this.testScoreGroupBox.Controls.Add(this.test2TextBox);
            this.testScoreGroupBox.Controls.Add(this.test1TextBox);
            this.testScoreGroupBox.Location = new System.Drawing.Point(12, 11);
            this.testScoreGroupBox.Name = "testScoreGroupBox";
            this.testScoreGroupBox.Size = new System.Drawing.Size(260, 145);
            this.testScoreGroupBox.TabIndex = 0;
            this.testScoreGroupBox.TabStop = false;
            this.testScoreGroupBox.Text = "Enter Three Test Scores";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(66, 112);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(44, 12);
            this.outputDescriptionLabel.TabIndex = 7;
            this.outputDescriptionLabel.Text = "Average";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(122, 107);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(100, 21);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test3promptLabel
            // 
            this.test3promptLabel.AutoSize = true;
            this.test3promptLabel.Location = new System.Drawing.Point(38, 81);
            this.test3promptLabel.Name = "test3promptLabel";
            this.test3promptLabel.Size = new System.Drawing.Size(68, 12);
            this.test3promptLabel.TabIndex = 5;
            this.test3promptLabel.Text = "Test Score #3";
            // 
            // test2promptLabel
            // 
            this.test2promptLabel.AutoSize = true;
            this.test2promptLabel.Location = new System.Drawing.Point(38, 54);
            this.test2promptLabel.Name = "test2promptLabel";
            this.test2promptLabel.Size = new System.Drawing.Size(68, 12);
            this.test2promptLabel.TabIndex = 4;
            this.test2promptLabel.Text = "Test Score #2";
            // 
            // test1promptLabel
            // 
            this.test1promptLabel.AutoSize = true;
            this.test1promptLabel.Location = new System.Drawing.Point(38, 28);
            this.test1promptLabel.Name = "test1promptLabel";
            this.test1promptLabel.Size = new System.Drawing.Size(68, 12);
            this.test1promptLabel.TabIndex = 3;
            this.test1promptLabel.Text = "Test Score #1";
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(122, 78);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 22);
            this.test3TextBox.TabIndex = 2;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(122, 50);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 22);
            this.test2TextBox.TabIndex = 1;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(122, 24);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 22);
            this.test1TextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(64, 162);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 48);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(145, 162);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 21);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(145, 188);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 21);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 384);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testScoreGroupBox);
            this.Name = "Form1";
            this.Text = "Test Score Average";
            this.testScoreGroupBox.ResumeLayout(false);
            this.testScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox testScoreGroupBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label test3promptLabel;
        private System.Windows.Forms.Label test2promptLabel;
        private System.Windows.Forms.Label test1promptLabel;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

