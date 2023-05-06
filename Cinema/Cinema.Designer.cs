namespace Cinema
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
            this.All_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Movies_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Movies_Data
            // 
            this.Movies_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Movies_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Movies_Data.Location = new System.Drawing.Point(529, 73);
            this.Movies_Data.Name = "Movies_Data";
            this.Movies_Data.Size = new System.Drawing.Size(727, 252);
            this.Movies_Data.TabIndex = 14;
            this.Movies_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Movies_Data_CellClick);
            // 
            // Book_btn
            // 
            this.Book_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_btn.Location = new System.Drawing.Point(1166, 22);
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
            this.Screen_tb.Location = new System.Drawing.Point(37, 372);
            this.Screen_tb.Name = "Screen_tb";
            this.Screen_tb.Size = new System.Drawing.Size(141, 29);
            this.Screen_tb.TabIndex = 16;
            // 
            // FindScreen_btn
            // 
            this.FindScreen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindScreen_btn.Location = new System.Drawing.Point(197, 372);
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
            this.FindCompany_btn.Location = new System.Drawing.Point(529, 370);
            this.FindCompany_btn.Name = "FindCompany_btn";
            this.FindCompany_btn.Size = new System.Drawing.Size(84, 29);
            this.FindCompany_btn.TabIndex = 19;
            this.FindCompany_btn.Tag = "NoDel";
            this.FindCompany_btn.Text = "Find";
            this.FindCompany_btn.UseVisualStyleBackColor = true;
            // 
            // Company_tb
            // 
            this.Company_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_tb.Location = new System.Drawing.Point(369, 370);
            this.Company_tb.Name = "Company_tb";
            this.Company_tb.Size = new System.Drawing.Size(141, 29);
            this.Company_tb.TabIndex = 18;
            // 
            // FindActor_btn
            // 
            this.FindActor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindActor_btn.Location = new System.Drawing.Point(861, 370);
            this.FindActor_btn.Name = "FindActor_btn";
            this.FindActor_btn.Size = new System.Drawing.Size(84, 29);
            this.FindActor_btn.TabIndex = 21;
            this.FindActor_btn.Tag = "NoDel";
            this.FindActor_btn.Text = "Find";
            this.FindActor_btn.UseVisualStyleBackColor = true;
            // 
            // Actor_tb
            // 
            this.Actor_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actor_tb.Location = new System.Drawing.Point(701, 370);
            this.Actor_tb.Name = "Actor_tb";
            this.Actor_tb.Size = new System.Drawing.Size(141, 29);
            this.Actor_tb.TabIndex = 20;
            // 
            // All_btn
            // 
            this.All_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_btn.Location = new System.Drawing.Point(529, 22);
            this.All_btn.Name = "All_btn";
            this.All_btn.Size = new System.Drawing.Size(84, 29);
            this.All_btn.TabIndex = 22;
            this.All_btn.Tag = "NoDel";
            this.All_btn.Text = "All";
            this.All_btn.UseVisualStyleBackColor = true;
            this.All_btn.Click += new System.EventHandler(this.All_btn_Click);
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 455);
            this.Controls.Add(this.All_btn);
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
        private System.Windows.Forms.Button All_btn;
    }
}

