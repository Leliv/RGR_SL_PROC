using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_Leonova2
{
    public partial class Form1 : Form
    {
        double x, p, sum, n;
        public Form1()
        {
            InitializeComponent();
            textBox2.MaxLength = 3;
            textBox1.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i <= n; i++)
                try
                {
                    x = Convert.ToDouble(textBox1.Text);
                    p = Convert.ToDouble(textBox2.Text);
                    n = Convert.ToDouble(textBox3.Text);
                    sum = Math.Round(x * Math.Pow((1 + (p / 100)), i), 2);
                    if (sum < 0)
                    {
                        textBox4.Text = "Некорректная сумма";
                    }
                    textBox4.Text = Convert.ToString(sum); //преобразуем число в строку
                    if (p > 0 && n > 0 && x > 0)
                        chart1.Series[0].Points.AddXY(i, sum);
                    else chart1.Series[0].Points.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверный ввод данных");
                }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не введена сумма!");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Не введен процент!");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Не введено количество периодов!");
            }
            if (x < 0)
            {
                MessageBox.Show("Введена некорректная сумма!");
            }
            if (p < 0)
            {
                MessageBox.Show("Процент не моет быть отрицательным!");
            }
            if (n < 0)
            {
                MessageBox.Show("Количество периодов не может быть меньше 0!");
            }
            if (sum < 0)
            {
                textBox4.Text = "Некорректная сумма";
            }
        }
    }
}
