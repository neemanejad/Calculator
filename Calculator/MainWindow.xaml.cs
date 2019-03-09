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
    //TODO Fix mathematical calculations with multiple numbers one after another
    //TODO Make window adjustable and allow buttons to scale based on screen size
    //TODO Impliment decimal calculations
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
            //number 0 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("0");
        }

        private void num1Click(object sender, RoutedEventArgs e)
        {
            //number 1 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("1");
        }

        private void num2Click(object sender, RoutedEventArgs e)
        {
            //number 2 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("2");
        }

        private void num3Click(object sender, RoutedEventArgs e)
        {
            //number 3 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("3");
        }

        private void num4Click(object sender, RoutedEventArgs e)
        {
            //number 4 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("4");
        }

        private void num5Click(object sender, RoutedEventArgs e)
        {
            //number 5 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("5");
        }

        private void num6Click(object sender, RoutedEventArgs e)
        {
            //number 6 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("6");
        }

        private void num7Click(object sender, RoutedEventArgs e)
        {
            //number 7 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("7");
        }

        private void num8Click(object sender, RoutedEventArgs e)
        {
            //number 8 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("8");
        }

        private void num9Click(object sender, RoutedEventArgs e)
        {
            //number 9 input
            checkFullNumberDisplayed(sender, e);
            checkIfAnswerDisplayed();
            insertNumInResultBox("9");
        }

        private void clearEntryClick(object sender, RoutedEventArgs e)
        {
            //'C' input
            resultBox.Text = "0";
            calculator.firstNumber = 0;
            calculator.firstNumberSet = false;
            calculator.secondNumber = 0;
            calculator.secondNumberSet = false;
        }

        private void plusClick(object sender, RoutedEventArgs e)
        {
            try
            {
                unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
                calculator.isPlus = true;
                calculator.isThereFullNumber = true;
            } catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void minusClick(object sender, RoutedEventArgs e)
        {
            try
            {
                unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
                calculator.isMinus = true;
                calculator.isThereFullNumber = true;
            } catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void multiplyClick(object sender, RoutedEventArgs e)
        {
            try
            {
                unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
                calculator.isMult = true;
                calculator.isThereFullNumber = true;
            } catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
            }
            
        }

        private void divideClick(object sender, RoutedEventArgs e)
        {
            try
            {
                unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
                calculator.isDiv = true;
                calculator.isThereFullNumber = true;
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
                unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
                calculator.isExp = true;
                calculator.isThereFullNumber = true;
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
                //See which operator was used and perform the calculation
                if (calculator.Check(calculator.isPlus))
                {
                    calculator.secondNumber = (long.Parse(resultBox.Text));
                    calculator.answer = calculator.Add();
                    showAndSetAnswer(calculator.answer, sender, e);
                }
                else if (calculator.Check(calculator.isMinus))
                {
                    calculator.secondNumber = (long.Parse(resultBox.Text));
                    calculator.answer = calculator.Subtract();
                    showAndSetAnswer(calculator.answer, sender, e);
                }
                else if (calculator.Check(calculator.isMult))
                {
                    calculator.secondNumber = (long.Parse(resultBox.Text));
                    calculator.answer = calculator.Multiply();
                    showAndSetAnswer(calculator.answer, sender, e);
                }
                else if (calculator.Check(calculator.isDiv))
                {
                    calculator.secondNumber = (long.Parse(resultBox.Text));
                    calculator.answer = calculator.Divide();
                    showAndSetAnswer(calculator.answer, sender, e);
                }
                else if (calculator.Check(calculator.isExp))
                {
                    calculator.secondNumber = (long.Parse(resultBox.Text));
                    calculator.answer = calculator.Exponentiate();
                    showAndSetAnswer(calculator.answer, sender, e);
                }
            } catch (DivideByZeroException)
            {
                resultBox.Text = "Cannot Divide by Zero";
                unsetAll();
                unsetCurrentOperator();
            } catch (OverflowException)
            {
                resultBox.Text = "Overflow";
                unsetAll();
                unsetCurrentOperator();
            } catch (FormatException)
            {
                resultBox.Text = resultBox.Text;
                unsetAll();
                unsetCurrentOperator();
            }
        }

        public void unsetCurrentOperator()
        {
            //Unset operator if it's active
            if (calculator.Check(calculator.isPlus))
            {
                calculator.isPlus = false;
            }
            else if (calculator.Check(calculator.isMinus))
            {
                calculator.isMinus = false;
            }
            else if (calculator.Check(calculator.isMult))
            {
                calculator.isMult = false;
            }
            else if (calculator.Check(calculator.isDiv))
            {
                calculator.isDiv = false;
            }
            else if (calculator.Check(calculator.isExp))
            {
                calculator.isExp = false;
            }
        }

        private void keyboardNumPress(object sender, KeyEventArgs e)
        {
            //Keyboard input
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
            } else if (e.Key == Key.Back)
            {
                //Remove characters from resultbox
                deleteNum();
            }

        }

        public void insertNumInResultBox(string num)
        {
            //Insert number in result box after user inputs number
            try
            {
                checkIfAnswerDisplayed();
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
            if (calculator.isThereAnswer)
            {
                resultBox.Text = "0";
                calculator.isThereAnswer = false;
            }
        }

        public void showAndSetAnswer(long finalNum, object sender, RoutedEventArgs e)
        {
            //Show answer in result box
            calculator.isThereAnswer = true;
            resultBox.Text = finalNum.ToString();
            calculator.firstNumber = 0;
            calculator.firstNumberSet = false;
            calculator.secondNumber = 0;
            calculator.secondNumberSet = false;
        }

        public void setNum(object sender, RoutedEventArgs e)
        {
            //Decides if number inputted by user should be equal to number 1 or number 2
            if (!calculator.firstNumberSet)
            {
                calculator.firstNumberSet = true;
                calculator.firstNumber = long.Parse(resultBox.Text);
                calculator.isThereFullNumber = false;
            }
            else if (calculator.firstNumberSet)
            {
                calculator.secondNumberSet = true;
                calculator.secondNumber = long.Parse(resultBox.Text);
                calculator.isThereFullNumber = false;
                equalClick(sender, e);
            }
        }

        public void checkFullNumberDisplayed(object sender, RoutedEventArgs e)
        {
            //Checks if user inputted their number after receiving an operator input, then clears result box for new number
            if (checkIfNumberOrNot())
            {
                if (calculator.isThereFullNumber)
                {
                    setNum(sender, e);
                    resultBox.Text = "0";
                }
            }
            else
            {
                resultBox.Text = "0";
            }
            
        }

        public void deleteNum()
        {
            //Deletes numbers from screen if user wants to make changes to inputted number
            if (calculator.isThereFullNumber || calculator.isThereAnswer)
            {
                return;
            }
            else
            {
                resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1, 1);
                if (resultBox.Text.Length == 0)
                {
                    resultBox.Text = "0";
                }
            }
        }

        public bool checkIfNumberOrNot()
        {
            //Checks if content in resultbox is a number or not
            long tmp;
            try
            {
                tmp = long.Parse(resultBox.Text);
                return true;
            } catch (FormatException)
            {
                return false;
            }
        }

        public void unsetAll()
        {
            calculator.isThereAnswer = false;
            calculator.isThereFullNumber = false;
            calculator.firstNumberSet = false;
            calculator.secondNumberSet = false;
        }
    }
}
