using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_4_1204075
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if ((txtHuruf.Text).All(Char.IsLetter))
            {
                epWarning.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "Betul!");
                epError.SetError(txtHuruf, "");
            }
            else
            {
                epWarning.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
                epError.SetError(txtHuruf, "Inputan hanya boleh huruf!");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if ((txtAngka.Text).All(Char.IsNumber))
            {
                epWarning.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "Betul!");
                epError.SetError(txtAngka, "");
            }
            else
            {
                epWarning.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
                epError.SetError(txtAngka, "Inputan hanya boleh angka!");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "Betul!");
                epError.SetError(txtAngka, "");
            }
            else
            {
                epWarning.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
                epError.SetError(txtAngka, "Format email salah!\nContoh : a@b.c");
            }
        }

        private void txtAkhir_Leave(string[] args)
        {
           
        }

        private void txtAkhir_Leave(object sender, EventArgs e)
        {
 
           

        }

        private void button1_Click(object sender, EventArgs e)

        {
            double a, b, i;
            double.TryParse(txtUTS.Text, out a);
            double.TryParse(txtUAS.Text, out b);
            i = a + b;
            if (i >= 75)
            {
                MessageBox.Show("Nama : " + txtHuruf.Text +
                "\nNPM : " + txtAngka.Text +
                "\nEmail : " + txtEmail.Text +
                "\nSemester : " + numeric.Text +
                "\nMata Kuliah : " + txtMatkul.Text,
                "Kamu Lulus Mata Kuliah ini");

                txtUAS.Text = "";
                txtUTS.Text = "";
                txtUAS.Focus();
            }
            else
            {
                MessageBox.Show("Nama : " + txtHuruf.Text +
                "\nNPM : " + txtAngka.Text +
                "\nEmail : " + txtEmail.Text +
                "\nSemester : " + numeric.Text +
                "\nMata Kuliah : " + txtMatkul.Text , 
                "Kamu Mengulang Mata Kuliah ini");
            }
        }

        private void txtUAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtUTS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
