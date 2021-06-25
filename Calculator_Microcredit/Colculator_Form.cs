using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Microcredit
{
    public partial class Colculator_Form : Form
    {
        public Colculator_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoanText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CheckResultsBtn_Click(object sender, EventArgs e)
        {
            var LoanTextResult = LoanText.Text;
            int Loan = Convert.ToInt32(LoanText.Text);
            int LoanPerDays = Convert.ToInt32(LoanPerDaysText.Text);
            double FirstDays = Convert.ToDouble(FirstDaysText.Text);
            double NextMonth = Convert.ToDouble(NextMonthText.Text);
            double LastYear = Convert.ToDouble(LastYearText.Text);
            int FrstBid = Convert.ToInt32(FirstBid.Text);
            int ScndBid = Convert.ToInt32(SecondBid.Text);
            int ThrdBid = Convert.ToInt32(ThirdBid.Text);
            double FirstDaysPersent = Loan * (FirstDays * FrstBid);
            double NextMonthPersent = Loan * (NextMonth * ScndBid);
            double LastYearPersent = Loan * (LastYear * ThrdBid);
            double SumPercent = (FirstDaysPersent) + (NextMonthPersent) + (LastYearPersent);
            int PaymentAmount = (int)SumPercent + Loan;
            decimal EffectiveBid = (int)SumPercent / Loan / LoanPerDays;
            if (Loan >= 500000)
            {
                MessageBox.Show("Предельный размер долговой нагрузки на одно физическое лицо не может превышать 500 тыс. руб");
                Application.Exit();
            }
            else if (FirstDays > 1)
            {
                MessageBox.Show("максимальная ставка установлена на уровне 1% в день");
                Application.Exit();
            }
            else if (PaymentAmount < PaymentAmount * 2.5)
            {
                MessageBox.Show("размер выплаты по микрозайму не может превышать 2,5-кратного размера суммы займа");
                Application.Exit();
            }
            else 
            {
                MessageBox.Show("Общая сумма выплаты" + PaymentAmount.ToString());
                MessageBox.Show("Сумма процентов " + SumPercent.ToString());
                MessageBox.Show("Эффективная ставка " + EffectiveBid.ToString());
            }   
        }
    }
}
