﻿namespace Calculator_Microcredit
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoanText = new System.Windows.Forms.TextBox();
            this.Loan = new System.Windows.Forms.Label();
            this.LoanPerDaysText = new System.Windows.Forms.TextBox();
            this.LoanPerDays = new System.Windows.Forms.Label();
            this.FirstDaysText = new System.Windows.Forms.TextBox();
            this.NextMonthText = new System.Windows.Forms.TextBox();
            this.LastYearText = new System.Windows.Forms.TextBox();
            this.FirstDays = new System.Windows.Forms.Label();
            this.NextMonth = new System.Windows.Forms.Label();
            this.LastYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoanText
            // 
            this.LoanText.Location = new System.Drawing.Point(77, 55);
            this.LoanText.Name = "LoanText";
            this.LoanText.Size = new System.Drawing.Size(388, 20);
            this.LoanText.TabIndex = 0;
            this.LoanText.TextChanged += new System.EventHandler(this.LoanText_TextChanged);
            // 
            // Loan
            // 
            this.Loan.AutoSize = true;
            this.Loan.Location = new System.Drawing.Point(81, 39);
            this.Loan.Name = "Loan";
            this.Loan.Size = new System.Drawing.Size(31, 13);
            this.Loan.TabIndex = 1;
            this.Loan.Text = "Loan";
            // 
            // LoanPerDaysText
            // 
            this.LoanPerDaysText.Location = new System.Drawing.Point(77, 121);
            this.LoanPerDaysText.Name = "LoanPerDaysText";
            this.LoanPerDaysText.Size = new System.Drawing.Size(84, 20);
            this.LoanPerDaysText.TabIndex = 2;
            // 
            // LoanPerDays
            // 
            this.LoanPerDays.AutoSize = true;
            this.LoanPerDays.Location = new System.Drawing.Point(77, 102);
            this.LoanPerDays.Name = "LoanPerDays";
            this.LoanPerDays.Size = new System.Drawing.Size(74, 13);
            this.LoanPerDays.TabIndex = 3;
            this.LoanPerDays.Text = "Loan per days";
            // 
            // FirstDaysText
            // 
            this.FirstDaysText.Location = new System.Drawing.Point(80, 177);
            this.FirstDaysText.Name = "FirstDaysText";
            this.FirstDaysText.Size = new System.Drawing.Size(100, 20);
            this.FirstDaysText.TabIndex = 4;
            // 
            // NextMonthText
            // 
            this.NextMonthText.Location = new System.Drawing.Point(224, 177);
            this.NextMonthText.Name = "NextMonthText";
            this.NextMonthText.Size = new System.Drawing.Size(100, 20);
            this.NextMonthText.TabIndex = 5;
            // 
            // LastYearText
            // 
            this.LastYearText.Location = new System.Drawing.Point(365, 177);
            this.LastYearText.Name = "LastYearText";
            this.LastYearText.Size = new System.Drawing.Size(100, 20);
            this.LastYearText.TabIndex = 6;
            this.LastYearText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // FirstDays
            // 
            this.FirstDays.AutoSize = true;
            this.FirstDays.Location = new System.Drawing.Point(77, 161);
            this.FirstDays.Name = "FirstDays";
            this.FirstDays.Size = new System.Drawing.Size(69, 13);
            this.FirstDays.TabIndex = 8;
            this.FirstDays.Text = " First 15 days";
            // 
            // NextMonth
            // 
            this.NextMonth.AutoSize = true;
            this.NextMonth.Location = new System.Drawing.Point(221, 161);
            this.NextMonth.Name = "NextMonth";
            this.NextMonth.Size = new System.Drawing.Size(61, 13);
            this.NextMonth.TabIndex = 9;
            this.NextMonth.Text = "Next month";
            // 
            // LastYear
            // 
            this.LastYear.AutoSize = true;
            this.LastYear.Location = new System.Drawing.Point(362, 161);
            this.LastYear.Name = "LastYear";
            this.LastYear.Size = new System.Drawing.Size(50, 13);
            this.LastYear.TabIndex = 10;
            this.LastYear.Text = "Last year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastYear);
            this.Controls.Add(this.NextMonth);
            this.Controls.Add(this.FirstDays);
            this.Controls.Add(this.LastYearText);
            this.Controls.Add(this.NextMonthText);
            this.Controls.Add(this.FirstDaysText);
            this.Controls.Add(this.LoanPerDays);
            this.Controls.Add(this.LoanPerDaysText);
            this.Controls.Add(this.Loan);
            this.Controls.Add(this.LoanText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoanText;
        private System.Windows.Forms.Label Loan;
        private System.Windows.Forms.TextBox LoanPerDaysText;
        private System.Windows.Forms.Label LoanPerDays;
        private System.Windows.Forms.TextBox FirstDaysText;
        private System.Windows.Forms.TextBox NextMonthText;
        private System.Windows.Forms.TextBox LastYearText;
        private System.Windows.Forms.Label FirstDays;
        private System.Windows.Forms.Label NextMonth;
        private System.Windows.Forms.Label LastYear;
    }
}
