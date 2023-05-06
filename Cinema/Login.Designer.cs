﻿namespace Cinema
{
    partial class Login
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
            this.UserID_tb = new System.Windows.Forms.TextBox();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UserID_tb
            // 
            this.UserID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID_tb.Location = new System.Drawing.Point(72, 55);
            this.UserID_tb.Name = "UserID_tb";
            this.UserID_tb.Size = new System.Drawing.Size(141, 29);
            this.UserID_tb.TabIndex = 20;
            // 
            // Password_tb
            // 
            this.Password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_tb.Location = new System.Drawing.Point(72, 101);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(141, 29);
            this.Password_tb.TabIndex = 22;
            // 
            // Login_btn
            // 
            this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(236, 55);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(84, 29);
            this.Login_btn.TabIndex = 23;
            this.Login_btn.Tag = "NoDel";
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.Location = new System.Drawing.Point(236, 101);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(84, 29);
            this.Register_btn.TabIndex = 24;
            this.Register_btn.Tag = "NoDel";
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(243, 19);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(68, 22);
            this.Admin.TabIndex = 25;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 166);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.UserID_tb);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserID_tb;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.CheckBox Admin;
    }
}