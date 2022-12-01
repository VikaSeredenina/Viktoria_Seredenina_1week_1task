using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania1._2_form_
{
    public partial class Form1 : Form
    {
        private int a;
        private int num1;
        private int num2;
        private int sum =0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                a = int.Parse(textBox1.Text);


                if (!(a > 10 && a <= 100 || a <= -10 && a >= -100))
                {
                        MessageBox.Show("Число должно быть двухзначным!");
                        return;
                    }
                
            }
            catch
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }

            num1 = a / 10;
            num2 = a % 10;
            sum = num1 + num2;

            if (sum % 2 == 0)
            {
                textBox3.Text=("Сумма четная!");
            }
            else
            {
                textBox3.Text = ("Сумма нечетная!");
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox1.Clear();
            textBox3.Text = "";
            textBox3.Clear();
           
        }
    }
}
