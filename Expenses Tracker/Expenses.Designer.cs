namespace Expenses_Tracker
{
    partial class Expenses
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExpNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpAmtTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpDescTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpCatCb = new System.Windows.Forms.ComboBox();
            this.ExpDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 72);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Expenses_Tracker.Properties.Resources.handmoney;
            this.pictureBox2.Location = new System.Drawing.Point(11, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Add Expenses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expenses_Tracker.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(709, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ExpNameTb
            // 
            this.ExpNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpNameTb.Location = new System.Drawing.Point(134, 145);
            this.ExpNameTb.Name = "ExpNameTb";
            this.ExpNameTb.Size = new System.Drawing.Size(319, 35);
            this.ExpNameTb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Expense Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Expense Amount";
            // 
            // ExpAmtTb
            // 
            this.ExpAmtTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpAmtTb.Location = new System.Drawing.Point(134, 255);
            this.ExpAmtTb.Name = "ExpAmtTb";
            this.ExpAmtTb.Size = new System.Drawing.Size(319, 35);
            this.ExpAmtTb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Expense Description";
            // 
            // ExpDescTb
            // 
            this.ExpDescTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDescTb.Location = new System.Drawing.Point(134, 569);
            this.ExpDescTb.Multiline = true;
            this.ExpDescTb.Name = "ExpDescTb";
            this.ExpDescTb.Size = new System.Drawing.Size(319, 99);
            this.ExpDescTb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(129, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Expense Category";
            // 
            // ExpCatCb
            // 
            this.ExpCatCb.FormattingEnabled = true;
            this.ExpCatCb.Items.AddRange(new object[] {
            "Food",
            "Shopping",
            "Household",
            "Bills",
            "Other"});
            this.ExpCatCb.Location = new System.Drawing.Point(134, 363);
            this.ExpCatCb.Name = "ExpCatCb";
            this.ExpCatCb.Size = new System.Drawing.Size(319, 28);
            this.ExpCatCb.TabIndex = 16;
            // 
            // ExpDOB
            // 
            this.ExpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpDOB.Location = new System.Drawing.Point(134, 461);
            this.ExpDOB.Name = "ExpDOB";
            this.ExpDOB.Size = new System.Drawing.Size(319, 35);
            this.ExpDOB.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(129, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Expense Date";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(268, 697);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(230, 56);
            this.AddBtn.TabIndex = 19;
            this.AddBtn.Text = "Add Expense";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 797);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExpDOB);
            this.Controls.Add(this.ExpCatCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpDescTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpAmtTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpNameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ExpNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExpAmtTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExpDescTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ExpCatCb;
        private System.Windows.Forms.DateTimePicker ExpDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
    }
}