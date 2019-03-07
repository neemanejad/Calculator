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
        //Make calculator object for calculation
        Calc calculator = new Calc();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void num0Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "0";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }

        }

        private void num1Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "1";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num2Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "2";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            } catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num3Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "3";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num4Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "4";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num5Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "5";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num6Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "6";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num7Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "7";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num8Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "8";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num9Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "9";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void clearEntryClick(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "0";
        }

        private void plusClick(object sender, RoutedEventArgs e)
        {

            CheckOperators(); //Checks if user selected a different operator before and unsets it
            calculator.SetFirstNumber(long.Parse(resultBox.Text));
            calculator.setPlus();
            resultBox.Text = "0";
            
        }

        private void minusClick(object sender, RoutedEventArgs e)
        {
            CheckOperators(); //Checks if user selected a different operator before and unsets it
            calculator.SetFirstNumber(long.Parse(resultBox.Text));
            calculator.setMinus();
            resultBox.Text = "0";
        }

        private void multiplyClick(object sender, RoutedEventArgs e)
        {
            CheckOperators(); //Checks if user selected a different operator before and unsets it
            calculator.SetFirstNumber(long.Parse(resultBox.Text));
            calculator.setMult();
            resultBox.Text = "0";
        }

        private void divideClick(object sender, RoutedEventArgs e)
        {
            CheckOperators(); //Checks if user selected a different operator before and unsets it
            calculator.SetFirstNumber(long.Parse(resultBox.Text));
            calculator.setDiv();
            resultBox.Text = "0";
        }

        private void exponentClick(object sender, RoutedEventArgs e)
        {
            CheckOperators(); //Checks if user selected a different operator before and unsets it
            calculator.SetFirstNumber(long.Parse(resultBox.Text));
            calculator.setExp();
            resultBox.Text = "0";
        }

        private void equalClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (calculator.Check(calculator.getIsPlus()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Add();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
                else if (calculator.Check(calculator.getIsMinus()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Subtract();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
                else if (calculator.Check(calculator.getIsMult()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Multiply();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
                else if (calculator.Check(calculator.getIsDiv()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Divide();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
                else if (calculator.Check(calculator.getIsExp()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Exponentiate();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
            } catch (DivideByZeroException)
            {
                resultBox.Text = "Cannot Divide by Zero";
                calculator.setIsThereAnswer();
            }
        }

        public void CheckOperators()
        {
            if (calculator.Check(calculator.getIsPlus()))
            {
                calculator.unsetPlus();
            }
            else if (calculator.Check(calculator.getIsMinus()))
            {
                calculator.unsetMinus();
            }
            else if (calculator.Check(calculator.getIsMult()))
            {
                calculator.unsetMult();
            }
            else if (calculator.Check(calculator.getIsDiv()))
            {
                calculator.unsetDiv();
            }
            else if (calculator.Check(calculator.getIsExp()))
            {
                calculator.unsetExp();
            }
        }

        
    }
}
