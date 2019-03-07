using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        class Calc
        {
            private int firstNumber, secondNumber;

            public Calc()
            {
                firstNumber = 0;
                secondNumber = 0;
            }

            public Calc(int firstNumber, int secondNumber)
            {
                this.firstNumber = firstNumber;
                this.secondNumber = secondNumber;
            }

            public static int Add(int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            }

            public static int Subtract(int firstNumber, int secondNumber)
            {
                return firstNumber - secondNumber;
            }

            public static int Multiply(int firstNumber, int secondNumber)
            {
                return firstNumber * secondNumber;
            }

            public static int Divide(int firstNumber, int secondNumber)
            {
                return firstNumber / secondNumber;
            }

            public static int Exponentiate(int number, int exponent)
            {
                for (int i = 1; i < exponent; i++)
                {
                    number *= number;
                }

                return number;
            }

            public void Clear()
            {
                firstNumber = 0;
                secondNumber = 0;
            }

        }

        private void num0Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "0";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();

        }

        private void num1Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "1";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();
        }

        private void num2Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "2";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();
        }

        private void num3Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "3";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();
        }

        private void num4Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "4";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();
        }

        private void num5Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "5";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();
        }

        private void num6Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "6";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();
        }

        private void num7Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "7";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();
        }

        private void num8Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "8";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();
        }

        private void num9Click(object sender, RoutedEventArgs e)
        {
            string newNumStr = resultBox.Text + "9";
            long newNum = long.Parse(newNumStr);
            resultBox.Text = newNum.ToString();
        }

        private void clearEntryClick(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "0";
        }

        private void plucClick(object sender, RoutedEventArgs e)
        {
             
        }
    }
}
