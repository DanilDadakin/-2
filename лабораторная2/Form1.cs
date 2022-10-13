using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лабораторная2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nal=0, doh, vich = 0, deti, dsumm;
            doh = Convert.ToDouble(textBox1.Text);
            dsumm = Convert.ToDouble(textBox2.Text);
            deti = Convert.ToDouble(textBox3.Text);
            if (dsumm >= 40000)
                nal = 0.13 * doh;
            if (dsumm < 40000)
            {
                if (checkBox1.Checked == true)
                    vich = 600 + 1200 * deti;
                else if (checkBox1.Checked == false)
                    vich = 600 + 600 * deti;
                nal = 0.13 * (doh - vich);
            }
            label5.Text ="Сумма подоходного налога: "+Convert.ToString(nal)+Environment.NewLine+"Сумма чистого дохода: "+Convert.ToString(doh-nal);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }
    }
}
