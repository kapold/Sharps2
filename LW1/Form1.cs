using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button1.Click += button1_Click;
            button9.Click += button9_Click;
        }

        public Calculator calc = new Calculator();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(750, 450);
            this.Text = "Common Calculator";
        }

        private void button1_Click(object sender, EventArgs e) // +
        {
            calc.Plus(textBox1, textBox2, textBox3);
        }

        private void button3_Click(object sender, EventArgs e) // -
        {
            calc.Minus(textBox1, textBox2, textBox3);
        }

        private void button2_Click(object sender, EventArgs e) // /
        {
            calc.Divide(textBox1, textBox2, textBox3);
        }

        private void button4_Click(object sender, EventArgs e) // *
        {
            calc.Multiply(textBox1, textBox2, textBox3);
        }

        private void button5_Click(object sender, EventArgs e) // % rest
        {
            calc.Rest(textBox1, textBox2, textBox3);
        }

        private void button7_Click(object sender, EventArgs e) // clear box
        {
            calc.Clear(textBox1, textBox2, textBox3);
        }

        private void button6_Click(object sender, EventArgs e) // % integer
        {
            calc.Integer(textBox1, textBox2, textBox3);
        }

        private void button8_Click(object sender, EventArgs e) // store
        {
            calc.Store(textBox3);
        }

        private void button9_Click(object sender, EventArgs e) // extract
        {
            calc.Extract(textBox3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // textBox1
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // textBox2
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // textBox3
        {

        }
    }

    interface ICalculator
    {
        void Plus(TextBox a, TextBox b, TextBox c);
        void Minus(TextBox a, TextBox b, TextBox c);
        void Divide(TextBox a, TextBox b, TextBox c);
        void Multiply(TextBox a, TextBox b, TextBox c);
        void Rest(TextBox a, TextBox b, TextBox c);
        void Integer(TextBox a, TextBox b, TextBox c);
        void Clear(TextBox a, TextBox b, TextBox c);
        void Store(TextBox c);
        void Extract(TextBox c);
    }

    public class Calculator : ICalculator
    {
        public string buffer;
        public void Clear(TextBox a, TextBox b, TextBox c)
        {
            a.Text = "0";
            b.Text = "0";
            c.Text = "0";
        }

        public void Divide(TextBox a, TextBox b, TextBox c)
        {
            double i1 = Convert.ToInt32(a.Text);
            double i2 = Convert.ToInt32(b.Text);

            double res = i1 / i2;
            c.Text = res.ToString();
        }

        public void Minus(TextBox a, TextBox b, TextBox c)
        {
            int i1 = Convert.ToInt32(a.Text);
            int i2 = Convert.ToInt32(b.Text);

            int res = i1 - i2;
            c.Text = res.ToString();
        }

        public void Multiply(TextBox a, TextBox b, TextBox c)
        {
            int i1 = Convert.ToInt32(a.Text);
            int i2 = Convert.ToInt32(b.Text);

            int res = i1 * i2;
            c.Text = res.ToString();
        }

        public void Plus(TextBox a, TextBox b, TextBox c)
        {
            int i1 = Convert.ToInt32(a.Text);
            int i2 = Convert.ToInt32(b.Text);

            int res = i1 + i2;
            c.Text = res.ToString();
        }

        public void Rest(TextBox a, TextBox b, TextBox c)
        {
            float i1 = Convert.ToInt32(a.Text);
            float i2 = Convert.ToInt32(b.Text);

            float res = i1 % i2;
            c.Text = res.ToString();
        }

        public void Integer(TextBox a, TextBox b, TextBox c)
        {
            int i1 = Convert.ToInt32(a.Text);
            int i2 = Convert.ToInt32(b.Text);

            float res = i1 / i2;
            c.Text = Math.Floor(res).ToString();
        }

        public void Store(TextBox c)
        {
            buffer = c.Text;
        }

        public void Extract(TextBox c)
        {
            c.Text = buffer;
        }
    }
}