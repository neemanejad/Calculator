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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        class Calc
        {
            private int firstNumber, secondNumber;


            Calc(int firstNumber, int secondNumber)
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
    }
}
