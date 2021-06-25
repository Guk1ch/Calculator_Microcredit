namespace Calculator_Microcredit
{
    partial class Colculator_Form
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
            this.FirstDays = new System.Windows.Forms.Label();
            this.CheckResultsBtn = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.LastYear = new System.Windows.Forms.Label();
            this.LastYearText = new System.Windows.Forms.TextBox();
            this.NextMonth = new System.Windows.Forms.Label();
            this.NextMonthText = new System.Windows.Forms.TextBox();
            this.FirstBid = new System.Windows.Forms.TextBox();
            this.SecondBid = new System.Windows.Forms.TextBox();
            this.ThirdBid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.FirstDaysText.Location = new System.Drawing.Point(77, 202);
            this.FirstDaysText.Name = "FirstDaysText";
            this.FirstDaysText.Size = new System.Drawing.Size(100, 20);
            this.FirstDaysText.TabIndex = 4;
            // 
            // FirstDays
            // 
            this.FirstDays.AutoSize = true;
            this.FirstDays.Location = new System.Drawing.Point(94, 184);
            this.FirstDays.Name = "FirstDays";
            this.FirstDays.Size = new System.Drawing.Size(57, 13);
            this.FirstDays.TabIndex = 8;
            this.FirstDays.Text = " First  days";
            // 
            // CheckResultsBtn
            // 
            this.CheckResultsBtn.Location = new System.Drawing.Point(214, 347);
            this.CheckResultsBtn.Name = "CheckResultsBtn";
            this.CheckResultsBtn.Size = new System.Drawing.Size(110, 48);
            this.CheckResultsBtn.TabIndex = 11;
            this.CheckResultsBtn.Text = "Check results";
            this.CheckResultsBtn.UseVisualStyleBackColor = true;
            this.CheckResultsBtn.Click += new System.EventHandler(this.CheckResultsBtn_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // LastYear
            // 
            this.LastYear.AutoSize = true;
            this.LastYear.Location = new System.Drawing.Point(393, 184);
            this.LastYear.Name = "LastYear";
            this.LastYear.Size = new System.Drawing.Size(50, 13);
            this.LastYear.TabIndex = 10;
            this.LastYear.Text = "Last year";
            // 
            // LastYearText
            // 
            this.LastYearText.Location = new System.Drawing.Point(365, 202);
            this.LastYearText.Name = "LastYearText";
            this.LastYearText.Size = new System.Drawing.Size(100, 20);
            this.LastYearText.TabIndex = 6;
            this.LastYearText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // NextMonth
            // 
            this.NextMonth.AutoSize = true;
            this.NextMonth.Location = new System.Drawing.Point(237, 184);
            this.NextMonth.Name = "NextMonth";
            this.NextMonth.Size = new System.Drawing.Size(61, 13);
            this.NextMonth.TabIndex = 9;
            this.NextMonth.Text = "Next month";
            // 
            // NextMonthText
            // 
            this.NextMonthText.Location = new System.Drawing.Point(224, 202);
            this.NextMonthText.Name = "NextMonthText";
            this.NextMonthText.Size = new System.Drawing.Size(100, 20);
            this.NextMonthText.TabIndex = 5;
            // 
            // FirstBid
            // 
            this.FirstBid.Location = new System.Drawing.Point(77, 269);
            this.FirstBid.Name = "FirstBid";
            this.FirstBid.Size = new System.Drawing.Size(100, 20);
            this.FirstBid.TabIndex = 12;
            // 
            // SecondBid
            // 
            this.SecondBid.Location = new System.Drawing.Point(224, 269);
            this.SecondBid.Name = "SecondBid";
            this.SecondBid.Size = new System.Drawing.Size(100, 20);
            this.SecondBid.TabIndex = 13;
            // 
            // ThirdBid
            // 
            this.ThirdBid.Location = new System.Drawing.Point(365, 269);
            this.ThirdBid.Name = "ThirdBid";
            this.ThirdBid.Size = new System.Drawing.Size(100, 20);
            this.ThirdBid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Days of Bid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Days of Bid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Days of Bid";
            // 
            // Colculator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThirdBid);
            this.Controls.Add(this.SecondBid);
            this.Controls.Add(this.FirstBid);
            this.Controls.Add(this.CheckResultsBtn);
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
            this.Name = "Colculator_Form";
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
        private System.Windows.Forms.Label FirstDays;
        private System.Windows.Forms.Button CheckResultsBtn;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label LastYear;
        private System.Windows.Forms.Label NextMonth;
        private System.Windows.Forms.TextBox LastYearText;
        private System.Windows.Forms.TextBox NextMonthText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ThirdBid;
        private System.Windows.Forms.TextBox SecondBid;
        private System.Windows.Forms.TextBox FirstBid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

