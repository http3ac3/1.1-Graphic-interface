using System;
using System.Windows.Forms;

namespace Exercize_1_WinForms
{
    public partial class Form1 : Form
    {
        double a, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetAnswerButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(AValueTextBox.Text);
            }
            catch 
            {
                AnswerTextBox.Text = "Введено неверное значение у первого числа! К вводу доступны только цифры, запятая и \"минус\"";
                return;
            }

            try
            {
                b = double.Parse(BValueTextBox.Text);
            }
            catch
            {
                AnswerTextBox.Text = "Введено неверное значение у второго числа! К вводу доступны только цифры, запятая и \"минус\"";
                return;
            }

            double aCube = a * a * a;
            double bCube = b * b * b;
            AnswerTextBox.Text = 
                 $"Куб числа {a} равен {aCube}, " +
                 $"куб числа {b} равен {bCube}, " +
                 $"среднее арифметическое кубов чисел {a} и {b} равно {(aCube + bCube) / 2.0}";
        }
    }
}
