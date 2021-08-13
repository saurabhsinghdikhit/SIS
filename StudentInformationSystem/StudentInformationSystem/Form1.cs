using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTotalMarks_TextChanged(object sender, EventArgs e)
        {
            txtAverage.Text=(Convert.ToInt32(txtTotalMarks.Text) / 5).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckGrade_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtAverage.Text) >= 90)
            {
                txtGrade.Text = "S";
            }
            else if (Convert.ToDouble(txtAverage.Text) >= 80 && Convert.ToDouble(txtAverage.Text) < 90)
            {
                txtGrade.Text = "A";
            }
            else if (Convert.ToDouble(txtAverage.Text) >= 70 && Convert.ToDouble(txtAverage.Text) < 80)
            {
                txtGrade.Text = "B";
            }
            else if (Convert.ToDouble(txtAverage.Text) >= 60 && Convert.ToDouble(txtAverage.Text) < 70)
            {
                txtGrade.Text = "C";
            }
            else if (Convert.ToDouble(txtAverage.Text) >= 50 && Convert.ToDouble(txtAverage.Text) < 60)
            {
                txtGrade.Text = "D";
            }
            else
            {
                txtGrade.Text = "Fail";
            }
        }

        private void txtTotalMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
