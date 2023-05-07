﻿namespace Cinema
{
    partial class Cinema
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
            this.Movies_Data = new System.Windows.Forms.DataGridView();
            this.Book_btn = new System.Windows.Forms.Button();
            this.Screen_tb = new System.Windows.Forms.TextBox();
            this.FindScreen_btn = new System.Windows.Forms.Button();
            this.FindCompany_btn = new System.Windows.Forms.Button();
            this.Company_tb = new System.Windows.Forms.TextBox();
            this.FindActor_btn = new System.Windows.Forms.Button();
            this.Actor_tb = new System.Windows.Forms.TextBox();
            this.InDay_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.Name_lb = new System.Windows.Forms.Label();
            this.Balance_lb = new System.Windows.Forms.Label();
            this.Point_lb = new System.Windows.Forms.Label();
            this.VIP_lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Booked_btn = new System.Windows.Forms.Button();
            this.Coming_btn = new System.Windows.Forms.Button();
            this.Available_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Comment_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Movies_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Movies_Data
            // 
            this.Movies_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Movies_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Movies_Data.Location = new System.Drawing.Point(529, 14);
            this.Movies_Data.Name = "Movies_Data";
            this.Movies_Data.Size = new System.Drawing.Size(727, 263);
            this.Movies_Data.TabIndex = 14;
            this.Movies_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Movies_Data_CellClick);
            // 
            // Book_btn
            // 
            this.Book_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_btn.Location = new System.Drawing.Point(274, 412);
            this.Book_btn.Name = "Book_btn";
            this.Book_btn.Size = new System.Drawing.Size(90, 29);
            this.Book_btn.TabIndex = 15;
            this.Book_btn.Tag = "NoDel";
            this.Book_btn.Text = "Book";
            this.Book_btn.UseVisualStyleBackColor = true;
            this.Book_btn.Click += new System.EventHandler(this.Book_btn_Click);
            // 
            // Screen_tb
            // 
            this.Screen_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen_tb.Location = new System.Drawing.Point(694, 301);
            this.Screen_tb.Name = "Screen_tb";
            this.Screen_tb.Size = new System.Drawing.Size(141, 29);
            this.Screen_tb.TabIndex = 16;
            // 
            // FindScreen_btn
            // 
            this.FindScreen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindScreen_btn.Location = new System.Drawing.Point(854, 301);
            this.FindScreen_btn.Name = "FindScreen_btn";
            this.FindScreen_btn.Size = new System.Drawing.Size(84, 29);
            this.FindScreen_btn.TabIndex = 17;
            this.FindScreen_btn.Tag = "NoDel";
            this.FindScreen_btn.Text = "Find";
            this.FindScreen_btn.UseVisualStyleBackColor = true;
            this.FindScreen_btn.Click += new System.EventHandler(this.FindScreen_btn_Click);
            // 
            // FindCompany_btn
            // 
            this.FindCompany_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindCompany_btn.Location = new System.Drawing.Point(854, 336);
            this.FindCompany_btn.Name = "FindCompany_btn";
            this.FindCompany_btn.Size = new System.Drawing.Size(84, 29);
            this.FindCompany_btn.TabIndex = 19;
            this.FindCompany_btn.Tag = "NoDel";
            this.FindCompany_btn.Text = "Find";
            this.FindCompany_btn.UseVisualStyleBackColor = true;
            this.FindCompany_btn.Click += new System.EventHandler(this.FindCompany_btn_Click);
            // 
            // Company_tb
            // 
            this.Company_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_tb.Location = new System.Drawing.Point(694, 336);
            this.Company_tb.Name = "Company_tb";
            this.Company_tb.Size = new System.Drawing.Size(141, 29);
            this.Company_tb.TabIndex = 18;
            // 
            // FindActor_btn
            // 
            this.FindActor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindActor_btn.Location = new System.Drawing.Point(854, 371);
            this.FindActor_btn.Name = "FindActor_btn";
            this.FindActor_btn.Size = new System.Drawing.Size(84, 29);
            this.FindActor_btn.TabIndex = 21;
            this.FindActor_btn.Tag = "NoDel";
            this.FindActor_btn.Text = "Find";
            this.FindActor_btn.UseVisualStyleBackColor = true;
            this.FindActor_btn.Click += new System.EventHandler(this.FindActor_btn_Click);
            // 
            // Actor_tb
            // 
            this.Actor_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actor_tb.Location = new System.Drawing.Point(694, 371);
            this.Actor_tb.Name = "Actor_tb";
            this.Actor_tb.Size = new System.Drawing.Size(141, 29);
            this.Actor_tb.TabIndex = 20;
            // 
            // InDay_btn
            // 
            this.InDay_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InDay_btn.Location = new System.Drawing.Point(646, 413);
            this.InDay_btn.Name = "InDay_btn";
            this.InDay_btn.Size = new System.Drawing.Size(84, 29);
            this.InDay_btn.TabIndex = 22;
            this.InDay_btn.Tag = "NoDel";
            this.InDay_btn.Text = "In Day";
            this.InDay_btn.UseVisualStyleBackColor = true;
            this.InDay_btn.Click += new System.EventHandler(this.InDay_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Movie by Resolution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Movie by Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Movie by Main Actor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Point:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "VIP:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(57, 313);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(26, 20);
            this.ID_lb.TabIndex = 31;
            this.ID_lb.Text = "ID";
            // 
            // Name_lb
            // 
            this.Name_lb.AutoSize = true;
            this.Name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lb.Location = new System.Drawing.Point(82, 342);
            this.Name_lb.Name = "Name_lb";
            this.Name_lb.Size = new System.Drawing.Size(51, 20);
            this.Name_lb.TabIndex = 32;
            this.Name_lb.Text = "Name";
            // 
            // Balance_lb
            // 
            this.Balance_lb.AutoSize = true;
            this.Balance_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_lb.Location = new System.Drawing.Point(98, 371);
            this.Balance_lb.Name = "Balance_lb";
            this.Balance_lb.Size = new System.Drawing.Size(67, 20);
            this.Balance_lb.TabIndex = 33;
            this.Balance_lb.Text = "Balance";
            // 
            // Point_lb
            // 
            this.Point_lb.AutoSize = true;
            this.Point_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point_lb.Location = new System.Drawing.Point(319, 313);
            this.Point_lb.Name = "Point_lb";
            this.Point_lb.Size = new System.Drawing.Size(45, 20);
            this.Point_lb.TabIndex = 34;
            this.Point_lb.Text = "Point";
            // 
            // VIP_lb
            // 
            this.VIP_lb.AutoSize = true;
            this.VIP_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIP_lb.Location = new System.Drawing.Point(319, 340);
            this.VIP_lb.Name = "VIP_lb";
            this.VIP_lb.Size = new System.Drawing.Size(35, 20);
            this.VIP_lb.TabIndex = 35;
            this.VIP_lb.Text = "VIP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "------Screen-------";
            // 
            // Booked_btn
            // 
            this.Booked_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booked_btn.Location = new System.Drawing.Point(25, 412);
            this.Booked_btn.Name = "Booked_btn";
            this.Booked_btn.Size = new System.Drawing.Size(90, 29);
            this.Booked_btn.TabIndex = 37;
            this.Booked_btn.Tag = "NoDel";
            this.Booked_btn.Text = "Booked";
            this.Booked_btn.UseVisualStyleBackColor = true;
            this.Booked_btn.Click += new System.EventHandler(this.Booked_btn_Click);
            // 
            // Coming_btn
            // 
            this.Coming_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coming_btn.Location = new System.Drawing.Point(854, 412);
            this.Coming_btn.Name = "Coming_btn";
            this.Coming_btn.Size = new System.Drawing.Size(84, 29);
            this.Coming_btn.TabIndex = 38;
            this.Coming_btn.Tag = "NoDel";
            this.Coming_btn.Text = "Coming";
            this.Coming_btn.UseVisualStyleBackColor = true;
            this.Coming_btn.Click += new System.EventHandler(this.Coming_btn_Click);
            // 
            // Available_btn
            // 
            this.Available_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available_btn.Location = new System.Drawing.Point(751, 413);
            this.Available_btn.Name = "Available_btn";
            this.Available_btn.Size = new System.Drawing.Size(84, 29);
            this.Available_btn.TabIndex = 41;
            this.Available_btn.Tag = "NoDel";
            this.Available_btn.Text = "Available";
            this.Available_btn.UseVisualStyleBackColor = true;
            this.Available_btn.Click += new System.EventHandler(this.Available_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(533, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Movie in Day";
            // 
            // Comment_btn
            // 
            this.Comment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_btn.Location = new System.Drawing.Point(125, 412);
            this.Comment_btn.Name = "Comment_btn";
            this.Comment_btn.Size = new System.Drawing.Size(90, 29);
            this.Comment_btn.TabIndex = 43;
            this.Comment_btn.Tag = "NoDel";
            this.Comment_btn.Text = "Comment";
            this.Comment_btn.UseVisualStyleBackColor = true;
            this.Comment_btn.Click += new System.EventHandler(this.Comment_btn_Click);
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 451);
            this.Controls.Add(this.Comment_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Available_btn);
            this.Controls.Add(this.Coming_btn);
            this.Controls.Add(this.Booked_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VIP_lb);
            this.Controls.Add(this.Point_lb);
            this.Controls.Add(this.Balance_lb);
            this.Controls.Add(this.Name_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InDay_btn);
            this.Controls.Add(this.FindActor_btn);
            this.Controls.Add(this.Actor_tb);
            this.Controls.Add(this.FindCompany_btn);
            this.Controls.Add(this.Company_tb);
            this.Controls.Add(this.FindScreen_btn);
            this.Controls.Add(this.Screen_tb);
            this.Controls.Add(this.Book_btn);
            this.Controls.Add(this.Movies_Data);
            this.Name = "Cinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.Cinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Movies_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Movies_Data;
        private System.Windows.Forms.Button Book_btn;
        private System.Windows.Forms.TextBox Screen_tb;
        private System.Windows.Forms.Button FindScreen_btn;
        private System.Windows.Forms.Button FindCompany_btn;
        private System.Windows.Forms.TextBox Company_tb;
        private System.Windows.Forms.Button FindActor_btn;
        private System.Windows.Forms.TextBox Actor_tb;
        private System.Windows.Forms.Button InDay_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label Name_lb;
        private System.Windows.Forms.Label Balance_lb;
        private System.Windows.Forms.Label Point_lb;
        private System.Windows.Forms.Label VIP_lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Booked_btn;
        private System.Windows.Forms.Button Coming_btn;
        private System.Windows.Forms.Button Available_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Comment_btn;
    }
}

