﻿namespace MedicinManagement
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
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 135);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(261, 132);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(356, 39);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(261, 223);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(356, 39);
            tbPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 226);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(96, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(521, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label2;
        private Button btnLogin;
    }
}