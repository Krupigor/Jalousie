using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jalousie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("пластик");
            comboBox1.Items.Add("алюминий");
            comboBox1.Items.Add("бамбук");
            comboBox1.Items.Add("соломка");
            comboBox1.Items.Add("текстиль");
            comboBox1.SelectedIndex = 0;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (sender.Equals(textBox1))
                {
                    textBox2.Focus();
                }
                else
                {
                    comboBox1.Focus();
                }
              return;
            }
            
            e.Handled = true; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length == 0) ||
                (textBox2.Text.Length == 0))
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double w, h, cena = 0, sum;
            w = Convert.ToDouble(textBox1.Text);
            h = Convert.ToDouble(textBox2.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0: cena = 50; break;
                case 1: cena = 100; break;
                case 2: cena = 40; break;
                case 3: cena = 59; break;
                case 4: cena = 85; break;

                default:
                    break;
            }
            sum = (w * h) / 10000 * cena;
            label4.Text =
                "Размер: " + w + "x" + h + "см.\n" +
                "Цена (р./м.кв.):" + cena.ToString("c") +
                "\nСумма: " + sum.ToString("c");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
