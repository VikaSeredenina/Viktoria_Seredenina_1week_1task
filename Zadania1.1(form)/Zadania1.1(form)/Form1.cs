using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadania1._1_form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения s
            double s = double.Parse(textBox1.Text);
            if (double.Parse(textBox1.Text)  == 0)
            {
                MessageBox.Show("Число не может равняться 0!");
                return;
            }
            if (double.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("Число не может быть отрицательным!");
                return;
            }
            // Вычисляем арифметическое выражение
            double a = Math.Sqrt(s / 6);
            // Выводим результат в окно
            textBox2.Text +=  "Результат A = " + a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
        }
    }
}
