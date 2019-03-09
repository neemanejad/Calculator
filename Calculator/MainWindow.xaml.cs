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
            checkIfAnswerDisplayed();
            insertNumInResultBox("0");

        }

        private void num1Click(object sender, RoutedEventArgs e)
        {
            checkIfAnswerDisplayed();
            insertNumInResultBox("1");
        }

        private void num2Click(object sender, RoutedEventArgs e)
        {
            checkIfAnswerDisplayed();
            insertNumInResultBox("2");
        }

        private void num3Click(object sender, RoutedEventArgs e)
        {
            checkIfAnswerDisplayed();
            insertNumInResultBox("3");
        }

        private void num4Click(object sender, RoutedEventArgs e)
        {
            checkIfAnswerDisplayed();
            insertNumInResultBox("4");
        }

        private void num5Click(object sender, RoutedEventArgs e)
        {
            checkIfAnswerDisplayed();
            insertNumInResultBox("5");
        }

        private void num6Click(object sender, RoutedEventArgs e)
        {
            checkIfAnswerDisplayed();
            insertNumInResultBox("6");
        }

        private void num7Click(object sender, RoutedEventArgs e)
        {
            checkIfAnswerDisplayed();
            insertNumInResultBox("7");
        }

        private void num8Click(object sender, RoutedEventArgs e)
        {
            checkIfAnswerDisplayed();
            insertNumInResultBox("8");
        }

        private void num9Click(object sender, RoutedEventArgs e)
        {
            checkIfAnswerDisplayed();
            insertNumInResultBox("9");
        }

        private void clearEntryClick(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "0";
        }

        private void plusClick(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckOperators(); //Checks if user selected a different operator before and unsets it
                calculator.SetFirstNumber(long.Parse(resultBox.Text));
                calculator.setPlus();
                resultBox.Text = "0";
            } catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void minusClick(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckOperators(); //Checks if user selected a different operator before and unsets it
                calculator.SetFirstNumber(long.Parse(resultBox.Text));
                calculator.setMinus();
                resultBox.Text = "0";
            } catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void multiplyClick(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckOperators(); //Checks if user selected a different operator before and unsets it
                calculator.SetFirstNumber(long.Parse(resultBox.Text));
                calculator.setMult();
                resultBox.Text = "0";
            } catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
            }
            
        }

        private void divideClick(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckOperators(); //Checks if user selected a different operator before and unsets it
                calculator.SetFirstNumber(long.Parse(resultBox.Text));
                calculator.setDiv();
                resultBox.Text = "0";
            }
            catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
            }
            
        }

        private void exponentClick(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckOperators(); //Checks if user selected a different operator before and unsets it
                calculator.SetFirstNumber(long.Parse(resultBox.Text));
                calculator.setExp();
                resultBox.Text = "0";
            }
            catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
            }
            
        }

        private void equalClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (calculator.Check(calculator.getIsPlus()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Add();
                    showAndSetAnswer(finalNum);
                }
                else if (calculator.Check(calculator.getIsMinus()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Subtract();
                    showAndSetAnswer(finalNum);
                }
                else if (calculator.Check(calculator.getIsMult()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Multiply();
                    showAndSetAnswer(finalNum);
                }
                else if (calculator.Check(calculator.getIsDiv()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Divide();
                    showAndSetAnswer(finalNum);
                }
                else if (calculator.Check(calculator.getIsExp()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Exponentiate();
                    showAndSetAnswer(finalNum);
                }
            } catch (DivideByZeroException)
            {
                resultBox.Text = "Cannot Divide by Zero";
                calculator.setIsThereAnswer();
            } catch (OverflowException)
            {
                resultBox.Text = "Overflow";
                calculator.setIsThereAnswer();
            } catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
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

        private void keyboardNumPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                num0Click(sender, e);
            }
            else if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                num1Click(sender, e);
            }
            else if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                num2Click(sender, e);
            }
            else if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                num3Click(sender, e);
            }
            else if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                num4Click(sender, e);
            }
            else if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                num5Click(sender, e);
            }
            else if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                num6Click(sender, e);
            }
            else if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                num7Click(sender, e);
            }
            else if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                num8Click(sender, e);
            }
            else if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                num9Click(sender, e);
            }
            else if (e.Key == Key.Add)
            {
                plusClick(sender, e);
            } else if (e.Key == Key.Subtract)
            {
                minusClick(sender, e);
            }
            else if (e.Key == Key.Multiply)
            {
                multiplyClick(sender, e);
            }
            else if (e.Key == Key.Divide)
            {
                divideClick(sender, e);
            }
            else if (e.Key == Key.Enter)
            {
                equalClick(sender, e);
            }

        }

        public void insertNumInResultBox(string num)
        {
            //Insert number in result box after user inputs number
            try
            {
                string newNumStr = resultBox.Text + num;
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        public void checkIfAnswerDisplayed()
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }
        }

        public void showAndSetAnswer(long finalNum)
        {
            calculator.setIsThereAnswer();
            resultBox.Text = finalNum.ToString();
            calculator.SetFirstNumber(finalNum);
        }

    }
}
