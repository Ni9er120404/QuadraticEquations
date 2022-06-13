using System;
using System.Windows.Forms;

namespace QuadraticEquations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) { }

        private void TextBox2_TextChanged(object sender, EventArgs e) { }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = new QuadraticEquations(ratio: textBox1.Text).Result;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "9");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "8");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "7");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "6");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "5");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "4");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "3");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "2");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "1");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: " ");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(text: "-");
        }
    }

    internal class QuadraticEquations
    {
        public string Result { get; set; }

        private double X_2 { get; set; }

        private double X_1 { get; set; }

        public QuadraticEquations(string ratio)
        {
            string[] numbers = ratio.Split(separator: ' ');
            long[] Ratio = new long[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    Ratio[i] = Convert.ToInt64(value: numbers[i]);
                }

                catch (Exception) { }
            }

            long a = 0;
            long b = 0;
            long c = 0;

            try
            {
                a = Ratio[0];
                b = Ratio[1];
                c = Ratio[2];
                long d = Ratio[3];
                c -= d;
            }

            catch (Exception) { }

            double discriminant = Math.Pow(x: b, y: 2) - (4 * a * c);

            if (discriminant >= 0)
            {
                X_1 = (-b + Math.Sqrt(d: discriminant)) / (2 * a);
                X_2 = (-b - Math.Sqrt(d: discriminant)) / (2 * a);

                try
                {
                    Result = $"Уравнение: "
                             + $"{Ratio[0]}*x^2 + "
                             + $"{Ratio[1]}*x + "
                             + $"{Ratio[2]} = "
                             + $"{Ratio[3]} \t\t\t "
                             + $"x_1 = {X_1}, "
                             + $"x_2 = {X_2}";
                }

                catch (Exception)
                {
                    MessageBox.Show(text: "Ошибка");
                }
            }

            else if (discriminant < 0)
            {
                MessageBox.Show(text: "Дискриминант меньше нуля");
            }
        }
    }
}